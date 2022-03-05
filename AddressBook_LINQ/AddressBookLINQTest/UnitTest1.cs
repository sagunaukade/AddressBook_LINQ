using AddressBook_LINQ;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AddressBookLINQTest
{
    [TestClass]
    public class UnitTest1
    {
        DataTableManager dataTableManger;

        [TestInitialize]
        public void SetUp()
        {
            dataTableManger = new DataTableManager();
        }
        //UC-1
        [TestMethod]
        [TestCategory("Insert Values in Data Table")]
        public void GivenInsertValues_returnInteger()
        {
            int expected = 2;
            int actual = dataTableManger.AddValues();
            Assert.AreEqual(actual, expected);
        }
        //UC-2
        [TestMethod]
        [TestCategory("Modify Values in Data Table")]
        public void GivenModifyValues_returnInteger()
        {
            int expected = 1;
            int actual = dataTableManger.EditDataTable("Amruta", "Lastname");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 3
        [TestMethod]
        [TestCategory("Modify Values in Data Table-Negative Test Case")]
        public void GivenWrong_ModifyValues_returnInteger()
        {
            int expected = 0;
            int actual = dataTableManger.EditDataTable("harma", "Lastname");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 4 Delete values in DataTable based on Name
        [TestMethod]
        [TestCategory("Delete Row in Data Table")]
        public void GivenDeleteQuery_returnInteger()
        {
            int expected = 1;
            int actual = dataTableManger.DeleteRowInDataTable("Amruta");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [TestCategory("Delete Row in Data Table-Negative Test Case")]
        public void GivenWrongDeleteQuery_returnInteger()
        {
            int expected = 0;
            int actual = dataTableManger.DeleteRowInDataTable("Sharma");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 5 Retrieve values from DataTable based on City or State
        [TestMethod]
        [TestCategory("Retrieve Row in Data Table based on City ")]
        public void GivenRetrieveQuery_BasedOnCityandState_returnString()
        {
            string expected = "Amruta";
            string actual = dataTableManger.RetrieveBasedOnCityorState("Kolhapur", "MH");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        [TestCategory("Retrieve Row in Data Table based on state ")]
        public void GivenRetrieveQuery_BasedOnCityorState_returnString()
        {
            string expected = "Amruta Sharma";
            string actual = dataTableManger.RetrieveBasedOnCityorState("Bnglr", "Karnatka");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 6 Retrieve count values from DataTable based on City or State
        [TestMethod]
        [TestCategory("Retrieve Row in Data Table based on City ")]
        public void GivenRetrieveCountQuery_BasedOnCityandState_returnString()
        {
            string expected = "1 2";
            string actual = dataTableManger.RetrieveCountBasedOnCityorState();
            Assert.AreEqual(actual, expected);
        }
        //Usecase 7 Sort based on City
        [TestMethod]
        [TestCategory("Sort based on City")]
        public void GivenSortQuery_BasedOnCityandState_returnString()
        {
            string expected = "Saguna Amruta ";
            string actual = dataTableManger.SortBasedOnNameInDataTable("Pune");
            Assert.AreEqual(actual, expected);
        }
        //Usecase 8 sort based on Contact Type
        [TestMethod]
        [TestCategory("Sort based on Type")]
        public void GivenCountQuery_BasedOnCityandState_returnString()
        {
            string expected = "1 1 1 ";
            string actual = dataTableManger.RetrieveCountBasedOnType();
            Assert.AreEqual(actual, expected);
        }
    }  
}

