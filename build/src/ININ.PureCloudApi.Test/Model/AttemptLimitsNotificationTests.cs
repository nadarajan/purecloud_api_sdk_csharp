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
    ///  Class for testing AttemptLimitsNotification
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AttemptLimitsNotificationTests
    {
        private AttemptLimitsNotification instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AttemptLimitsNotification();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AttemptLimitsNotification
        /// </summary>
        [Test]
        public void AttemptLimitsNotificationInstanceTest()
        {
            Assert.IsInstanceOf<AttemptLimitsNotification> (instance, "instance is a AttemptLimitsNotification");
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'DateCreated'
        /// </summary>
        [Test]
        public void DateCreatedTest()
        {
            // TODO: unit test for the property 'DateCreated'
        }
        /// <summary>
        /// Test the property 'DateModified'
        /// </summary>
        [Test]
        public void DateModifiedTest()
        {
            // TODO: unit test for the property 'DateModified'
        }
        /// <summary>
        /// Test the property 'Version'
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO: unit test for the property 'Version'
        }
        /// <summary>
        /// Test the property 'AdditionalProperties'
        /// </summary>
        [Test]
        public void AdditionalPropertiesTest()
        {
            // TODO: unit test for the property 'AdditionalProperties'
        }
        /// <summary>
        /// Test the property 'MaxAttemptsPerContact'
        /// </summary>
        [Test]
        public void MaxAttemptsPerContactTest()
        {
            // TODO: unit test for the property 'MaxAttemptsPerContact'
        }
        /// <summary>
        /// Test the property 'MaxAttemptsPerNumber'
        /// </summary>
        [Test]
        public void MaxAttemptsPerNumberTest()
        {
            // TODO: unit test for the property 'MaxAttemptsPerNumber'
        }
        /// <summary>
        /// Test the property 'TimeZoneId'
        /// </summary>
        [Test]
        public void TimeZoneIdTest()
        {
            // TODO: unit test for the property 'TimeZoneId'
        }
        /// <summary>
        /// Test the property 'ResetPeriod'
        /// </summary>
        [Test]
        public void ResetPeriodTest()
        {
            // TODO: unit test for the property 'ResetPeriod'
        }
        /// <summary>
        /// Test the property 'RecallEntries'
        /// </summary>
        [Test]
        public void RecallEntriesTest()
        {
            // TODO: unit test for the property 'RecallEntries'
        }

    }

}
