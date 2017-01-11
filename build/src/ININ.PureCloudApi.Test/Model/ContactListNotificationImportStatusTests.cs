using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;
using ININ.PureCloudApi.Client;
using System.Reflection;

namespace ININ.PureCloudApi.Test
{
    /// <summary>
    ///  Class for testing ContactListNotificationImportStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ContactListNotificationImportStatusTests
    {
        private ContactListNotificationImportStatus instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ContactListNotificationImportStatus();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ContactListNotificationImportStatus
        /// </summary>
        [Test]
        public void ContactListNotificationImportStatusInstanceTest()
        {
            Assert.IsInstanceOf<ContactListNotificationImportStatus> (instance, "instance is a ContactListNotificationImportStatus");
        }

        /// <summary>
        /// Test the property 'ImportState'
        /// </summary>
        [Test]
        public void ImportStateTest()
        {
            // TODO: unit test for the property 'ImportState'
        }
        /// <summary>
        /// Test the property 'TotalRecords'
        /// </summary>
        [Test]
        public void TotalRecordsTest()
        {
            // TODO: unit test for the property 'TotalRecords'
        }
        /// <summary>
        /// Test the property 'CompletedRecords'
        /// </summary>
        [Test]
        public void CompletedRecordsTest()
        {
            // TODO: unit test for the property 'CompletedRecords'
        }
        /// <summary>
        /// Test the property 'PercentageComplete'
        /// </summary>
        [Test]
        public void PercentageCompleteTest()
        {
            // TODO: unit test for the property 'PercentageComplete'
        }
        /// <summary>
        /// Test the property 'FailureReason'
        /// </summary>
        [Test]
        public void FailureReasonTest()
        {
            // TODO: unit test for the property 'FailureReason'
        }
        /// <summary>
        /// Test the property 'AdditionalProperties'
        /// </summary>
        [Test]
        public void AdditionalPropertiesTest()
        {
            // TODO: unit test for the property 'AdditionalProperties'
        }

    }

}