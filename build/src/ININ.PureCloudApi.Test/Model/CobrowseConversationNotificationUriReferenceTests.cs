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
    ///  Class for testing CobrowseConversationNotificationUriReference
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CobrowseConversationNotificationUriReferenceTests
    {
        private CobrowseConversationNotificationUriReference instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CobrowseConversationNotificationUriReference();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CobrowseConversationNotificationUriReference
        /// </summary>
        [Test]
        public void CobrowseConversationNotificationUriReferenceInstanceTest()
        {
            Assert.IsInstanceOf<CobrowseConversationNotificationUriReference> (instance, "instance is a CobrowseConversationNotificationUriReference");
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

    }

}
