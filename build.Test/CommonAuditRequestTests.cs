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
    ///  Class for testing CommonAuditRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CommonAuditRequestTests
    {
        private CommonAuditRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CommonAuditRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CommonAuditRequest
        /// </summary>
        [Test]
        public void CommonAuditRequestInstanceTest()
        {
            Assert.IsInstanceOf<CommonAuditRequest> (instance, "instance is a CommonAuditRequest");
        }

        /// <summary>
        /// Test the property 'PageNumber'
        /// </summary>
        [Test]
        public void PageNumberTest()
        {
            // TODO: unit test for the property 'PageNumber'
        }
        /// <summary>
        /// Test the property 'PageSize'
        /// </summary>
        [Test]
        public void PageSizeTest()
        {
            // TODO: unit test for the property 'PageSize'
        }
        /// <summary>
        /// Test the property 'SortBy'
        /// </summary>
        [Test]
        public void SortByTest()
        {
            // TODO: unit test for the property 'SortBy'
        }
        /// <summary>
        /// Test the property 'QueryPhrase'
        /// </summary>
        [Test]
        public void QueryPhraseTest()
        {
            // TODO: unit test for the property 'QueryPhrase'
        }
        /// <summary>
        /// Test the property 'QueryFields'
        /// </summary>
        [Test]
        public void QueryFieldsTest()
        {
            // TODO: unit test for the property 'QueryFields'
        }
        /// <summary>
        /// Test the property 'Facets'
        /// </summary>
        [Test]
        public void FacetsTest()
        {
            // TODO: unit test for the property 'Facets'
        }
        /// <summary>
        /// Test the property 'Filters'
        /// </summary>
        [Test]
        public void FiltersTest()
        {
            // TODO: unit test for the property 'Filters'
        }

    }

}
