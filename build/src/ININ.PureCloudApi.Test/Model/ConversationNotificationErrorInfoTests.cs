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
    ///  Class for testing ConversationNotificationErrorInfo
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ConversationNotificationErrorInfoTests
    {
        private ConversationNotificationErrorInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConversationNotificationErrorInfo();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ConversationNotificationErrorInfo
        /// </summary>
        [Test]
        public void ConversationNotificationErrorInfoInstanceTest()
        {
            Assert.IsInstanceOf<ConversationNotificationErrorInfo> (instance, "instance is a ConversationNotificationErrorInfo");
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO: unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO: unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Test]
        public void MessageTest()
        {
            // TODO: unit test for the property 'Message'
        }
        /// <summary>
        /// Test the property 'MessageWithParams'
        /// </summary>
        [Test]
        public void MessageWithParamsTest()
        {
            // TODO: unit test for the property 'MessageWithParams'
        }
        /// <summary>
        /// Test the property 'MessageParams'
        /// </summary>
        [Test]
        public void MessageParamsTest()
        {
            // TODO: unit test for the property 'MessageParams'
        }
        /// <summary>
        /// Test the property 'ContextId'
        /// </summary>
        [Test]
        public void ContextIdTest()
        {
            // TODO: unit test for the property 'ContextId'
        }
        /// <summary>
        /// Test the property 'Uri'
        /// </summary>
        [Test]
        public void UriTest()
        {
            // TODO: unit test for the property 'Uri'
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