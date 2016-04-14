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
    ///  Class for testing BatchItem
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BatchItemTests
    {
        private BatchItem instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BatchItem();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BatchItem
        /// </summary>
        [Test]
        public void BatchItemInstanceTest()
        {
            Assert.IsInstanceOf<BatchItem> (instance, "instance is a BatchItem");
        }

        /// <summary>
        /// Test the property 'Method'
        /// </summary>
        [Test]
        public void MethodTest()
        {
            // TODO: unit test for the property 'Method'
        }
        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Test]
        public void UrlTest()
        {
            // TODO: unit test for the property 'Url'
        }
        /// <summary>
        /// Test the property 'Body'
        /// </summary>
        [Test]
        public void BodyTest()
        {
            // TODO: unit test for the property 'Body'
        }

    }

}
