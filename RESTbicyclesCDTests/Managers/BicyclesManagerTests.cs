using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RESTbicyclesCD.Models;

namespace RESTbicyclesCD.Managers.Tests
{
    [TestClass]
    public class BicyclesManagerTests
    {
        [TestMethod]
        public void GetAllTest()
        {
            BicyclesManager manager = new BicyclesManager();
            List<Bicycle> all = manager.GetAll();
            Assert.AreEqual(2, all.Count);

            Assert.IsNull(manager.GetById(-1));

            Bicycle ny = new Bicycle {Brand = "Nishiki"};
            Bicycle ny2= manager.Add(ny);
            Assert.AreEqual(ny.Brand, ny2.Brand);
            Assert.AreEqual(3, ny2.Id);
        }
    }
}