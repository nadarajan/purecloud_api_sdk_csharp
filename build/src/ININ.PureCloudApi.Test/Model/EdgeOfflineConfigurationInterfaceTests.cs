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
    ///  Class for testing EdgeOfflineConfigurationInterface
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class EdgeOfflineConfigurationInterfaceTests
    {
        private EdgeOfflineConfigurationInterface instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EdgeOfflineConfigurationInterface();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EdgeOfflineConfigurationInterface
        /// </summary>
        [Test]
        public void EdgeOfflineConfigurationInterfaceInstanceTest()
        {
            Assert.IsInstanceOf<EdgeOfflineConfigurationInterface> (instance, "instance is a EdgeOfflineConfigurationInterface");
        }

        /// <summary>
        /// Test the property 'Routes'
        /// </summary>
        [Test]
        public void RoutesTest()
        {
            // TODO: unit test for the property 'Routes'
        }
        /// <summary>
        /// Test the property 'Addresses'
        /// </summary>
        [Test]
        public void AddressesTest()
        {
            // TODO: unit test for the property 'Addresses'
        }
        /// <summary>
        /// Test the property 'Ipv4Capabilities'
        /// </summary>
        [Test]
        public void Ipv4CapabilitiesTest()
        {
            // TODO: unit test for the property 'Ipv4Capabilities'
        }
        /// <summary>
        /// Test the property 'Ipv6Capabilities'
        /// </summary>
        [Test]
        public void Ipv6CapabilitiesTest()
        {
            // TODO: unit test for the property 'Ipv6Capabilities'
        }

    }

}