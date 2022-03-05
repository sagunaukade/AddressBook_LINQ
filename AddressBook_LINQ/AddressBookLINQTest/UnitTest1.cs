﻿using AddressBook_LINQ;
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

        [TestMethod]
        [TestCategory("Insert Values in Data Table")]
        public void GivenInsertValues_returnInteger()
        {
            int expected = 2;
            int actual = dataTableManger.CreateDataTable();
            Assert.AreEqual(actual, expected);
        }
    }
}
