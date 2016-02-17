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
    public class FavoriteTemplateRequestDataTests
    {
        private FavoriteTemplateRequestData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FavoriteTemplateRequestData();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FavoriteTemplateRequestData
        /// </summary>
        [Test]
        public void FavoriteTemplateRequestDataInstanceTest()
        {
            Assert.IsInstanceOf<FavoriteTemplateRequestData> (instance, "instance is a FavoriteTemplateRequestData");
        }

        
        /// <summary>
        /// Test the property 'TemplateId' 
        /// </summary>
        [Test]
        public void TemplateIdTest()
        {
            // TODO: unit test for the property 'TemplateId' 
        }
        

    }

}