using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint6.Task4.V17.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint6.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = new double[res.Length];
            wait[0] = -0.62;
            wait[1] = -16.79;
            wait[2] = -17.77;
            wait[3] = -6.3;
            wait[4] = -5.04;
            wait[5] = -6;
            wait[6] = -7.85;
            wait[7] = -2.43;
            wait[8] = 5.91;
            wait[9] = 4.33;
            wait[10] = -11.82;
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
