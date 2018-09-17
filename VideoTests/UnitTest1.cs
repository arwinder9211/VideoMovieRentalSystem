using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoMovieRentalSystem;

namespace VideoTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckDBConn()
        {
            Assert.AreEqual("Closed", new Database().CheckConnection());
        }

        [TestMethod]
        public void CheckDataReturns()
        {
            Assert.IsNotNull(new Database().GetAllPendingRentals());
        }
    }
}
