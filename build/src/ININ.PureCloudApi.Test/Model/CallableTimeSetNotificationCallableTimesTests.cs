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
    ///  Class for testing CallableTimeSetNotificationCallableTimes
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CallableTimeSetNotificationCallableTimesTests
    {
        private CallableTimeSetNotificationCallableTimes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallableTimeSetNotificationCallableTimes();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CallableTimeSetNotificationCallableTimes
        /// </summary>
        [Test]
        public void CallableTimeSetNotificationCallableTimesInstanceTest()
        {
            Assert.IsInstanceOf<CallableTimeSetNotificationCallableTimes> (instance, "instance is a CallableTimeSetNotificationCallableTimes");
        }

        /// <summary>
        /// Test the property 'TimeSlots'
        /// </summary>
        [Test]
        public void TimeSlotsTest()
        {
            // TODO: unit test for the property 'TimeSlots'
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
        /// Test the property 'AdditionalProperties'
        /// </summary>
        [Test]
        public void AdditionalPropertiesTest()
        {
            // TODO: unit test for the property 'AdditionalProperties'
        }

    }

}
