using Clicker;
using Newtonsoft.Json.Bson;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Xunit;
using static Clicker.GameState;

namespace Clicker.Tests
{
    public class GameStateTests
    {

        // Test that clicking increases points by PointsPerClick
        [Fact]
        public void Click_increments_points_by_pointsPerClick()
        {
            var gs = new GameState();
            long before = gs.Points;
            gs.Click();
            Assert.Equal(before + gs.PointsPerClick, gs.Points);
        }

        // Test that TryBuyClickPower reduces points and increases ClickPowerLevel
        [Fact]
        public void TryBuyClickPower_reduces_points_and_increases_level()
        {
            var gs = new GameState();

            // give the GameState enough points via reflection
            var prop = typeof(GameState).GetProperty("Points", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            prop!.SetValue(gs, 100L);

            long cost = gs.GetClickPowerCost();
            bool bought = gs.TryBuyClickPower();

            Assert.True(bought);
            Assert.True(gs.ClickPowerLevel == 2);
            Assert.Equal(100L - cost, gs.Points);
        }

        // Test that GetAutoClickerTierInfos reports NextMaxCount without mutating state
        [Fact]
        public void GetAutoClickerTierInfos_reports_nextMaxCount_without_mutation()
        {
            var gs = new GameState();

            // set Points high enough to buy several of tier 0
            var prop = typeof(GameState).GetProperty("Points", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            prop!.SetValue(gs, 1000L);

            var infos = gs.GetAutoClickerTierInfos();

            // NextMaxCostCount should be computed and non-negative
            Assert.True(infos.Count > 0);
            Assert.True(infos[0].NextMaxCount >= 0);

            // Ensure the call did not change actual owned count
            Assert.Equal(0, infos[0].Count);
        }

        // Test that AutoClickTickSmooth accumulates fractional points correctly
        [Fact]
        public void AutoClickTickSmooth_accumulates_points_correctly()
        {
            var gs = new GameState();

            // get base cost for tier 0 via the public info method (safer than reflecting internal list)
            var tierInfos = gs.GetAutoClickerTierInfos();
            long baseCost = tierInfos[0].NextCost;

            // give enough points to buy one tier-0 auto-clicker
            var prop = typeof(GameState).GetProperty("Points", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            prop!.SetValue(gs, baseCost);

            // buy one tier-0 auto-clicker using the public API
            bool bought = gs.TryBuyAutoClickerTier(0);
            Assert.True(bought); // sanity check

            // Each tier 0 auto-clicker gives 1 point/sec 
            gs.AutoClickTickSmooth(0.5); // half a second -> 0.5 pending
            Assert.Equal(0, gs.Points);   // still 0
            gs.AutoClickTickSmooth(0.5); // another half second -> total 1.0 -> 1 point
            Assert.Equal(1, gs.Points);
        }

        //Buy one of each upgrade and verify points deducted correctly
        [Fact]
        public void BuyOneOfEachUpgrade()
        {
            var gs = new GameState();

            //get base cost for clicker
            long baseCostClicker = (long)(gs.ClickPowerBaseCost * gs.ClickPowerCostMultiplier);

            // get base cost for each auto-clicker tier via the public info method
            var tierInfos = gs.GetAutoClickerTierInfos();
            long baseCostTier0 = tierInfos[0].NextCost;
            long baseCostTier1 = tierInfos[1].NextCost;
            long baseCostTier2 = tierInfos[2].NextCost;
            long baseCostTier3 = tierInfos[3].NextCost;
            long baseCostTier4 = tierInfos[4].NextCost;

            // total cost to buy one of each
            long totalCost = baseCostClicker + baseCostTier0 + baseCostTier1 + baseCostTier2 + baseCostTier3 + baseCostTier4;

            // Test with enough points to buy 1 of each upgrade
            var prop = typeof(GameState).GetProperty("Points", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            prop!.SetValue(gs, totalCost);

            // Verify max purchasable calculations
            gs.TryBuyClickPower();
            totalCost -= baseCostClicker;
            Assert.Equal(totalCost, gs.Points);

            gs.TryBuyAutoClickerTier(0);
            totalCost -= baseCostTier0;
            Assert.Equal(totalCost, gs.Points);

            gs.TryBuyAutoClickerTier(1);
            totalCost -= baseCostTier1;
            Assert.Equal(totalCost, gs.Points);

            gs.TryBuyAutoClickerTier(2);
            totalCost -= baseCostTier2;
            Assert.Equal(totalCost, gs.Points);

            gs.TryBuyAutoClickerTier(3);
            totalCost -= baseCostTier3;
            Assert.Equal(totalCost, gs.Points);

            gs.TryBuyAutoClickerTier(4);
            totalCost -= baseCostTier4;
            Assert.Equal(totalCost, gs.Points);
        }


        //Test that Reset clears points and upgrades
        [Fact]
        public void Reset_clears_points_and_upgrades()
        {
            var gs = new GameState();

            //give some points and buy some upgrades
            var prop = typeof(GameState).GetProperty("Points", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            prop!.SetValue(gs, 10000L);

            // Buy some upgrades and verify they were bought
            Assert.True(gs.TryBuyClickPower());
            Assert.True(gs.TryBuyAutoClickerTier(0));
            Assert.True(gs.TryBuyAutoClickerTier(1));

            // Now reset
            gs.Reset();

            // Verify state is back to initial
            Assert.Equal(0, gs.Points);
            Assert.Equal(1, gs.ClickPowerLevel);

            // Verify all auto-clicker counts are zero
            var tierInfos = gs.GetAutoClickerTierInfos();
            foreach (var info in tierInfos)
            {
                Assert.Equal(0, info.Count);
            }
        }

        //Test that checks seperatly buying click power and max click power
        [Fact]
        public void BuyClickPowerAndMaxClickPower()
        {
            var gs = new GameState();

            //get base cost for clicker
            long baseCostClicker = (long)(gs.ClickPowerBaseCost * gs.ClickPowerCostMultiplier);

            // Test with enough points to buy 1 click power upgrade
            var prop = typeof(GameState).GetProperty("Points", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            prop!.SetValue(gs, baseCostClicker * 10); // enough for multiple upgrades

            long expectedPoints = (baseCostClicker * 10) - baseCostClicker;

            // Buy one click power upgrade
            Assert.True(gs.TryBuyClickPower());
            Assert.Equal(expectedPoints, gs.Points);
            Assert.True(gs.ClickPowerLevel == 2);

            // Now buy max click power upgrades
            int initialLevel = gs.ClickPowerLevel;
            Assert.True(gs.TryBuyMaxClickPower());
            Assert.True(gs.ClickPowerLevel > initialLevel);


            // Calculate expected points after max purchase
            long totalCost = 0;
            var initialLevelTemp = initialLevel;
            for (int i = 0; i < gs.ClickPowerLevel - initialLevel; i++)
            {
                double raw = gs.ClickPowerBaseCost * Math.Pow(gs.ClickPowerCostMultiplier, initialLevelTemp);
                totalCost += (long)Math.Ceiling(raw); //converting the value the same as GetClickPowerCost does 22.5 -> 23
                initialLevelTemp++;
            }
            expectedPoints -= totalCost;
            Assert.Equal(expectedPoints, gs.Points);
        }

        //Test that checks seperatly buying autoclick and max autoclick
        [Fact]
        public void BuyAutoClickAndMaxAutoClickersLevel1()
        {
            var gs = new GameState();

            

            //get base cost for auto level 1
            long level0AutoClicker = gs.autoClickerTiers[0].BaseCost;

            // Test with enough points to buy 1 auto upgrade
            var prop = typeof(GameState).GetProperty("Points", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            prop!.SetValue(gs, level0AutoClicker * 15); // enough for multiple upgrades

            long expectedPoints = (level0AutoClicker * 15) - level0AutoClicker;

            // Buy one auto level 1 -index 0 - upgrade and check points deducted and count increased
            Assert.True(gs.TryBuyAutoClickerTier(0));
            Assert.Equal(expectedPoints, gs.Points);
            Assert.True(gs.autoClickerTiers[0].Count == 1);

            //Get updated data set for auto level 1 from GetAutoClickerTierInfos
            var autoTierInfos = gs.GetAutoClickerTierInfos();

            // Calculate max purchasable for level 1 - index 0
            long maxPurchasable = autoTierInfos[0].NextMaxCount;

            // Now buy max auto clicker level 1 - index 0 - upgrades
            int initialLevel = gs.autoClickerTiers[0].Count;
            Assert.True(gs.TryBuyMaxAutoClicker(0));

            // Verify we bought the max possible
            Assert.True(gs.autoClickerTiers[0].Count == initialLevel + (int)maxPurchasable);

            // Calculate expected points after max purchase
            long totalCost = 0;
            var initialLevelTemp = initialLevel;
            for (int i = 0; i < gs.autoClickerTiers[0].Count - initialLevel; i++)
            {
                totalCost += (long)Math.Ceiling(gs.autoClickerTiers[0].BaseCost * Math.Pow(gs.autoClickerTiers[0].CostMultiplier, initialLevelTemp));
                initialLevelTemp++;
            }
            expectedPoints -= totalCost;

            // Verify points after max purchase
            Assert.Equal(expectedPoints, gs.Points);
        }
    }
}