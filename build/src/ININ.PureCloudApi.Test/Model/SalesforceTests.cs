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
    ///  Class for testing Salesforce
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SalesforceTests
    {
        private Salesforce instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Salesforce();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Salesforce
        /// </summary>
        [Test]
        public void SalesforceInstanceTest()
        {
            Assert.IsInstanceOf<Salesforce> (instance, "instance is a Salesforce");
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
        /// Test the property 'Certificate'
        /// </summary>
        [Test]
        public void CertificateTest()
        {
            // TODO: unit test for the property 'Certificate'
        }
        /// <summary>
        /// Test the property 'SsoTargetURI'
        /// </summary>
        [Test]
        public void SsoTargetURITest()
        {
            // TODO: unit test for the property 'SsoTargetURI'
        }
        /// <summary>
        /// Test the property 'IssuerURI'
        /// </summary>
        [Test]
        public void IssuerURITest()
        {
            // TODO: unit test for the property 'IssuerURI'
        }
        /// <summary>
        /// Test the property 'Disabled'
        /// </summary>
        [Test]
        public void DisabledTest()
        {
            // TODO: unit test for the property 'Disabled'
        }
        /// <summary>
        /// Test the property 'SelfUri'
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri'
        }

    }

}
