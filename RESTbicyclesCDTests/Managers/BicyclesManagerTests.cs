using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTbicyclesCD.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTbicyclesCD.Models;

namespace RESTbicyclesCD.Managers.Tests
{
    [TestClass()]
    public class BicyclesManagerTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            BicyclesManager manager = new BicyclesManager();
            List<Bicycle> all = manager.GetAll();
            Assert.AreEqual(20, all.Count);
        }
    }
}