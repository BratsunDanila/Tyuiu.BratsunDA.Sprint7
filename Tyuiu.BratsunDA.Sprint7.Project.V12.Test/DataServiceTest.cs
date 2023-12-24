using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BratsunDA.Sprint7.Project.V12.Lib;

namespace Tyuiu.BratsunDA.Sprint7.Project.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetBase()
        {
            DataService ds = new DataService();
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\TEST.csv";
            string[,] res = ds.GetBase(pathSaveFile);
            string[,] wait = { { "bebra11", "bebra21" }, { "bebra12", "bebra22" }, { "ZACHEM YA", "ETO DELAYU" } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
