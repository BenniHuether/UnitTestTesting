using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFirstProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Tests
{
    [TestClass()]
    public class Sort_ClassTests
    {
        [TestMethod()]
        public void Sort_ClassTest()
        {

        }

        [TestMethod()]
        public void Simple_SortTest1()
        {
            // Initialize
            string input = "cba";
            string expected =  "abc";

            // Act
            char[] result = Sort_Class.Simple_Sort(input.ToCharArray());

            // Assert
            CollectionAssert.AreEqual(expected.ToCharArray(), result);

        }

        [TestMethod]
        public void Simple_SortTest2()
        {
            // Initialize
            string input = "dgehf";
            string expected = "defgh";

            // Act
            char[] result = Sort_Class.Simple_Sort(input.ToCharArray());

            // Assert
            CollectionAssert.AreEqual(expected.ToCharArray(), result);
        }

        [TestMethod]
        public void Simple_SortTest3()
        {
            // Initialize
            string input = "zxyw";
            string expected = "wxyz";

            // Act
            char[] result = Sort_Class.Simple_Sort(input.ToCharArray());

            // Assert
            CollectionAssert.AreEqual(expected.ToCharArray(), result);
        }
    }
}