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
    ///  Class for testing ResponseSetNotificationResponses
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ResponseSetNotificationResponsesTests
    {
        private ResponseSetNotificationResponses instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ResponseSetNotificationResponses();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ResponseSetNotificationResponses
        /// </summary>
        [Test]
        public void ResponseSetNotificationResponsesInstanceTest()
        {
            Assert.IsInstanceOf<ResponseSetNotificationResponses> (instance, "instance is a ResponseSetNotificationResponses");
        }

        /// <summary>
        /// Test the property 'Data'
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO: unit test for the property 'Data'
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
        /// Test the property 'ReactionType'
        /// </summary>
        [Test]
        public void ReactionTypeTest()
        {
            // TODO: unit test for the property 'ReactionType'
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
