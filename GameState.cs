using System;
using System.Collections.Generic;
using System.Text;

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
        private class AutoClickerTier
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
        private readonly List<AutoClickerTier> autoClickerTiers = new()
        {
            new AutoClickerTier { Count = 0, BaseCost = 50, CostMultiplier = 1.6, PointsPerSecondPerUnit = 1 },
            new AutoClickerTier { Count = 0, BaseCost = 150, CostMultiplier = 1.6, PointsPerSecondPerUnit = 2 },
            new AutoClickerTier { Count = 0, BaseCost = 400, CostMultiplier = 1.7, PointsPerSecondPerUnit = 4 },
            new AutoClickerTier { Count = 0, BaseCost = 800, CostMultiplier = 1.8, PointsPerSecondPerUnit = 8 },
            new AutoClickerTier { Count = 0, BaseCost = 1200, CostMultiplier = 2, PointsPerSecondPerUnit = 12 },


        };

        // Backwards-compatible properties that map to tier 0 (so existing UI keeps working)
        public int AutoClickers => autoClickerTiers.Count > 0 ? autoClickerTiers[0].Count : 0;
        public long AutoClickerBaseCost => autoClickerTiers.Count > 0 ? autoClickerTiers[0].BaseCost : 0;
        public double AutoClickerCostMultiplier => autoClickerTiers.Count > 0 ? autoClickerTiers[0].CostMultiplier : 1.0;
        public long PointsPerAutoClickPerUnit => autoClickerTiers.Count > 0 ? autoClickerTiers[0].PointsPerSecondPerUnit : 0;

        public int AutoClickers2 => autoClickerTiers.Count > 1 ? autoClickerTiers[1].Count : 0;
        public long AutoClicker2BaseCost => autoClickerTiers.Count > 1 ? autoClickerTiers[1].BaseCost : 0;

        // ————— Core actions —————

        public void Click()
        {
            Points += PointsPerClick;
        }

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

        // buy an auto-clicker of a specific tier (0-based)
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

        // ————— Costs —————

        public long GetClickPowerCost()
        {
            // cost = base * multiplier^level (rounded)
            double raw = ClickPowerBaseCost * Math.Pow(ClickPowerCostMultiplier, ClickPowerLevel);
            return (long)Math.Ceiling(raw);
        }

        // cost for arbitrary tier (0-based)
        public long GetAutoClickerCostAt(int tierIndex)
        {
            if (tierIndex < 0 || tierIndex >= autoClickerTiers.Count) return long.MaxValue;
            return autoClickerTiers[tierIndex].GetCost();
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
