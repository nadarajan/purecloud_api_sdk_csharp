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
    ///  Class for testing SuggestSearchRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SuggestSearchRequestTests
    {
        private SuggestSearchRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SuggestSearchRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SuggestSearchRequest
        /// </summary>
        [Test]
        public void SuggestSearchRequestInstanceTest()
        {
            Assert.IsInstanceOf<SuggestSearchRequest> (instance, "instance is a SuggestSearchRequest");
        }

        /// <summary>
        /// Test the property 'Expand'
        /// </summary>
        [Test]
        public void ExpandTest()
        {
            // TODO: unit test for the property 'Expand'
        }
        /// <summary>
        /// Test the property 'Types'
        /// </summary>
        [Test]
        public void TypesTest()
        {
            // TODO: unit test for the property 'Types'
        }
        /// <summary>
        /// Test the property 'Query'
        /// </summary>
        [Test]
        public void QueryTest()
        {
            // TODO: unit test for the property 'Query'
        }

    }

}
