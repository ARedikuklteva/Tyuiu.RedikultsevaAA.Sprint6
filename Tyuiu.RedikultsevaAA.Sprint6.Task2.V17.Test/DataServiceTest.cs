using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RedikultsevaAA.Sprint6.Task2.V17.Lib;

namespace Tyuiu.RedikultsevaAA.Sprint6.Task2.V17.Test
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
            wait[0] = 4.67;
            wait[1] = 0.43;
            wait[2] = -8.26;
            wait[3] = -9.87;
            wait[4] = -3.98;
            wait[5] = 1;
            wait[6] = 0.02;
            wait[7] = -1.87;
            wait[8] = 3.74;
            wait[9] = 16.43;
            wait[10] = 24.67;
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
