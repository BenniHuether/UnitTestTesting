using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstProject;

namespace MyFirstProject_UnitTest
{
    [TestClass]
    public class Firma_UnitTesting
    {
        [TestMethod]
        public void OveridedToString_getExpectedOutput_withoutOrtsteil()
        {
            // Initialize 
            Ortschaft testOrtschaft1 = new Ortschaft(57537, "Wissen(Sieg)", null);
            Firma testFirma1 = new Firma("Benni GmbH", "Teststraße", 1, testOrtschaft1);
            string Expected = string.Format("Benni GmbH, \r\nTeststraße 1, \r\n57537 Wissen(Sieg)");

            // Act
            string Result = testFirma1.ToString();

            // Assert
            Assert.AreEqual(Expected, Result);

        }
    }
}
