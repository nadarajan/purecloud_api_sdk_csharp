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
    ///  Class for testing HeartBeatRuleNotificationNotificationUser
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class HeartBeatRuleNotificationNotificationUserTests
    {
        private HeartBeatRuleNotificationNotificationUser instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new HeartBeatRuleNotificationNotificationUser();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of HeartBeatRuleNotificationNotificationUser
        /// </summary>
        [Test]
        public void HeartBeatRuleNotificationNotificationUserInstanceTest()
        {
            Assert.IsInstanceOf<HeartBeatRuleNotificationNotificationUser> (instance, "instance is a HeartBeatRuleNotificationNotificationUser");
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
        /// Test the property 'DisplayName'
        /// </summary>
        [Test]
        public void DisplayNameTest()
        {
            // TODO: unit test for the property 'DisplayName'
        }

    }

}