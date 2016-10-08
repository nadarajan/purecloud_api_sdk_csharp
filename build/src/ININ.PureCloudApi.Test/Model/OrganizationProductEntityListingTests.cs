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
    ///  Class for testing OrganizationProductEntityListing
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class OrganizationProductEntityListingTests
    {
        private OrganizationProductEntityListing instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OrganizationProductEntityListing();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OrganizationProductEntityListing
        /// </summary>
        [Test]
        public void OrganizationProductEntityListingInstanceTest()
        {
            Assert.IsInstanceOf<OrganizationProductEntityListing> (instance, "instance is a OrganizationProductEntityListing");
        }

        /// <summary>
        /// Test the property 'Entities'
        /// </summary>
        [Test]
        public void EntitiesTest()
        {
            // TODO: unit test for the property 'Entities'
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
        /// Test the property 'PageNumber'
        /// </summary>
        [Test]
        public void PageNumberTest()
        {
            // TODO: unit test for the property 'PageNumber'
        }
        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Test]
        public void TotalTest()
        {
            // TODO: unit test for the property 'Total'
        }
        /// <summary>
        /// Test the property 'PageCount'
        /// </summary>
        [Test]
        public void PageCountTest()
        {
            // TODO: unit test for the property 'PageCount'
        }

    }

}
