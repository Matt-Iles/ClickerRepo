using System;
using System.Collections.Generic;
using System.Text;

using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Clicker.Tests")] // allowing unit tests to access internal members

namespace Clicker
{

    public class GameState
    {
        // Core state
        public long Points { get; private set; } = 0; //Total points

        private double pendingPoints = 0; // fractional points from auto-clickers
        public long PointsPerClick { get; private set; } = 1; // points gained per click
        public double ClickPowerCostMultiplier { get; } = 1.5; // cost growth per level

        // Click power upgrade
        public int ClickPowerLevel { get; private set; } = 1; // current level of click power
        public int ClickPowerBaseCost { get; } = 10; // base cost for first level

        // -------- Auto-clicker tiers --------
        internal class AutoClickerTier
        {
            public int Count;
            public long BaseCost;
            public double CostMultiplier;
            public long PointsPerSecondPerUnit;

            public long GetCost()
            {
                double raw = BaseCost * Math.Pow(CostMultiplier, Count);
                return (long)Math.Ceiling(raw);
            }
        }

        // Tiers of auto-clickers
        internal readonly List<AutoClickerTier> autoClickerTiers = new()
        {
            new AutoClickerTier { Count = 0, BaseCost = 50, CostMultiplier = 1.2, PointsPerSecondPerUnit = 1 },
            new AutoClickerTier { Count = 0, BaseCost = 150, CostMultiplier = 1.35, PointsPerSecondPerUnit = 2 },
            new AutoClickerTier { Count = 0, BaseCost = 400, CostMultiplier = 1.45, PointsPerSecondPerUnit = 4 },
            new AutoClickerTier { Count = 0, BaseCost = 800, CostMultiplier = 1.6, PointsPerSecondPerUnit = 8 },
            new AutoClickerTier { Count = 0, BaseCost = 1200, CostMultiplier = 1.85, PointsPerSecondPerUnit = 12 },

        };

        // Info about each auto-clicker tier for UI - read-only
        public record AutoClickerTierInfo(int TierIndex, int Count, long PointsPerSecondPerUnit, long NextCost,long NextMaxCount);

        public IReadOnlyList<AutoClickerTierInfo> GetAutoClickerTierInfos()
        {
            var infos = new List<AutoClickerTierInfo>(autoClickerTiers.Count);
            for (int i = 0; i < autoClickerTiers.Count; i++)
            {
                var t = autoClickerTiers[i];
                int purchasable = CalculateMaxPurchasableForTier(i, Points);
                infos.Add(new AutoClickerTierInfo(i, t.Count, t.PointsPerSecondPerUnit, t.GetCost(), purchasable));
            }
            return infos.AsReadOnly();
        }

        // how many units of `tierIndex` the supplied `availablePoints` can buy right now without changing game state.
        public int CalculateMaxPurchasableForTier(int tierIndex, long availablePoints)
        {
            if (tierIndex < 0 || tierIndex >= autoClickerTiers.Count) return 0;

            var tier = autoClickerTiers[tierIndex];
            int purchases = 0;
            int currentCount = tier.Count;

            while (true)
            {
                double raw = tier.BaseCost * Math.Pow(tier.CostMultiplier, currentCount + purchases);
                long cost = (long)Math.Ceiling(raw);
                if (availablePoints >= cost)
                {
                    availablePoints -= cost;
                    purchases++;
                }
                else {break;}
            }
            return purchases;
        }

        public int CalculateMaxPurchasableClickPower()
        {   
            long availablePoints = Points;
            int purchases = 0;
            int currentLevel = ClickPowerLevel;
            while (true)
            {
                double raw = ClickPowerBaseCost * Math.Pow(ClickPowerCostMultiplier, currentLevel + purchases);
                long cost = (long)Math.Ceiling(raw);
                if (availablePoints >= cost)
                {
                    availablePoints -= cost;
                    purchases++;
                }
                else { break; }
            }
            return purchases;
        }

        // ————— Core actions —————

        public void Click()
        {
            Points += PointsPerClick;
        }

        // buy click power upgrade
        public bool TryBuyClickPower()
        {
            long cost = GetClickPowerCost();
            if (Points >= cost)
            {
                Points -= cost;
                ClickPowerLevel++;
                PointsPerClick += 1;
                return true;
            }
            return false;
        }

        //Buy max amount of click power upgrade
        public bool TryBuyMaxClickPower()
        {
            bool boughtAny = false;
            while (true)
            {
                long cost = GetClickPowerCost();
                if (Points >= cost)
                {
                    Points -= cost;
                    ClickPowerLevel++;
                    PointsPerClick += 1;
                    boughtAny = true;
                }
                else
                {
                    break;
                }
            }
            return boughtAny;
        }

        // Buy an auto-clicker of a specific tier (0-based)
        public bool TryBuyAutoClickerTier(int tierIndex)
        {
            if (tierIndex < 0 || tierIndex >= autoClickerTiers.Count) return false;
            var tier = autoClickerTiers[tierIndex];
            long cost = tier.GetCost();
            if (Points >= cost)
            {
                Points -= cost;
                tier.Count++;
                return true;
            }
            return false;
        }

        //Buy max amount of auto-clickers of a specific tier (0-based)
        public bool TryBuyMaxAutoClicker(int tierIndex)
        {
            if (tierIndex < 0 || tierIndex >= autoClickerTiers.Count) return false;
            var tier = autoClickerTiers[tierIndex];
            bool boughtAny = false;
            while (true)
            {
                long cost = tier.GetCost();
                if (Points >= cost)
                {
                    Points -= cost;
                    tier.Count++;
                    boughtAny = true;
                }
                else
                {
                    break;
                }
            }
            return boughtAny;
        }

        // Called by a Timer tick (e.g., once per 0.1 second)
        public void AutoClickTickSmooth(double deltaSeconds)
        {
            // Sum the total points-per-second contributed by all tiers
            long totalPps = 0;
            foreach (var tier in autoClickerTiers)
            {
                totalPps += (long)tier.Count * tier.PointsPerSecondPerUnit;
            }

            double pointsThisTick = totalPps * deltaSeconds;

            pendingPoints += pointsThisTick;

            while (pendingPoints >= 1.0)
            {
                Points++;
                pendingPoints -= 1.0;
            }
        }

        //Get total auto clickers points per second
        public long GetTotalAutoClickerPointsPerSecond()
        {
            long totalPps = 0;
            foreach (var tier in autoClickerTiers)
            {
                totalPps += (long)tier.Count * tier.PointsPerSecondPerUnit;
            }
            return totalPps;
        }

        // ————— Costs —————

        public long GetClickPowerCost()
        {
            // cost = base * multiplier^level (rounded)
            double raw = ClickPowerBaseCost * Math.Pow(ClickPowerCostMultiplier, ClickPowerLevel);
            return (long)Math.Ceiling(raw);
        }

        // ————— Reset Game—————
        public void Reset()
        {
            Points = 0;
            pendingPoints = 0;
            PointsPerClick = 1;
            ClickPowerLevel = 1;
            // reset all tiers
            foreach (var tier in autoClickerTiers)
            {
                tier.Count = 0;
            }
        }
    }

}
