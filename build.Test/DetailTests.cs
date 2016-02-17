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
    public class DetailTests
    {
        private Detail instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Detail();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Detail
        /// </summary>
        [Test]
        public void DetailInstanceTest()
        {
            Assert.IsInstanceOf<Detail> (instance, "instance is a Detail");
        }

        
        /// <summary>
        /// Test the property 'ErrorCode' 
        /// </summary>
        [Test]
        public void ErrorCodeTest()
        {
            // TODO: unit test for the property 'ErrorCode' 
        }
        
        /// <summary>
        /// Test the property 'FieldName' 
        /// </summary>
        [Test]
        public void FieldNameTest()
        {
            // TODO: unit test for the property 'FieldName' 
        }
        
        /// <summary>
        /// Test the property 'EntityId' 
        /// </summary>
        [Test]
        public void EntityIdTest()
        {
            // TODO: unit test for the property 'EntityId' 
        }
        
        /// <summary>
        /// Test the property 'EntityName' 
        /// </summary>
        [Test]
        public void EntityNameTest()
        {
            // TODO: unit test for the property 'EntityName' 
        }
        

    }

}