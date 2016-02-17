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
    public class TagQueryRequestTests
    {
        private TagQueryRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TagQueryRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TagQueryRequest
        /// </summary>
        [Test]
        public void TagQueryRequestInstanceTest()
        {
            Assert.IsInstanceOf<TagQueryRequest> (instance, "instance is a TagQueryRequest");
        }

        
        /// <summary>
        /// Test the property 'Query' 
        /// </summary>
        [Test]
        public void QueryTest()
        {
            // TODO: unit test for the property 'Query' 
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
        

    }

}