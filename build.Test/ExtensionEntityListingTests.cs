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
    [TestFixture]
    public class ExtensionEntityListingTests
    {
        private ExtensionEntityListing instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExtensionEntityListing();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ExtensionEntityListing
        /// </summary>
        [Test]
        public void ExtensionEntityListingInstanceTest()
        {
            Assert.IsInstanceOf<ExtensionEntityListing> (instance, "instance is a ExtensionEntityListing");
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
        /// Test the property 'Entities' 
        /// </summary>
        [Test]
        public void EntitiesTest()
        {
            // TODO: unit test for the property 'Entities' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        
        /// <summary>
        /// Test the property 'FirstUri' 
        /// </summary>
        [Test]
        public void FirstUriTest()
        {
            // TODO: unit test for the property 'FirstUri' 
        }
        
        /// <summary>
        /// Test the property 'PreviousUri' 
        /// </summary>
        [Test]
        public void PreviousUriTest()
        {
            // TODO: unit test for the property 'PreviousUri' 
        }
        
        /// <summary>
        /// Test the property 'NextUri' 
        /// </summary>
        [Test]
        public void NextUriTest()
        {
            // TODO: unit test for the property 'NextUri' 
        }
        
        /// <summary>
        /// Test the property 'LastUri' 
        /// </summary>
        [Test]
        public void LastUriTest()
        {
            // TODO: unit test for the property 'LastUri' 
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