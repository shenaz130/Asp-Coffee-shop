using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using William;

namespace UnitTestProjectDemo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Branch branch = new Branch();
            int bid = 001; 
            string bname = "Colombo";
            bool expeceted = true;
            //Act
            var result = branch.AddBranch(bid,bname);
            //Assert
            Assert.AreEqual(expeceted,result);
            
        }
    }
}
