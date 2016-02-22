﻿using NUnit.Framework;
using CiDotNet.Calc.Math;

namespace CiDotNet.Calc.Test.Math
{
    [TestFixture]
    public class Finance5RappenRoundTestFixture
    {
        [TestCase]
        public void CalculateRate5RappenRound()
        {
            int Duration = 12;
            int Ppy = 12;
            double PeriodicInterestRate = 7.5;
            double presentValue = 30000;
            double finalValue = 0;
            CiDotNet.Calc.Math.Finance.Mode mode = CiDotNet.Calc.Math.Finance.Mode.BeginMode;

            double ExpectedRate = 2586.556528260553d;
            double ActualRate = Finance.CalculateRate(Duration, Ppy, PeriodicInterestRate, presentValue, finalValue, mode);

            Assert.AreEqual(ExpectedRate, ActualRate);

            decimal ExpectedRate5RappenRound = 2586.55M;
            decimal ActualRate5RappenRound = RoundHelper.Round5Rappen((decimal)ActualRate);

            Assert.AreEqual(ExpectedRate5RappenRound, ActualRate5RappenRound);
        }
    }
}
