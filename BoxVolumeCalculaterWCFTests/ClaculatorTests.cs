using Microsoft.VisualStudio.TestTools.UnitTesting;
using BoxVolumeCalculaterWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxVolumeCalculaterWCF.Tests
{
    [TestClass()]
    public class ClaculatorTests
    {
        [TestMethod()]
        public void ClaculatorTestVolume()
        {
            //Arrange
            var vol = new Service1();

            //Act
            vol.GetVolume(2, 2, 2);

            //Assert
            Assert.AreEqual(8, vol.GetVolume(2,2,2));
        }

        [TestMethod()]
        public void ClaculatorTestLength()
        {
            //Arrange
            var vol = new Service1();

            //Act
            vol.GetSide(8, 2, 2);

            //Assert
            Assert.AreEqual(2, vol.GetSide(8,2,2));
        }
    }
}