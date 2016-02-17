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
    public class FlowInputDataTests
    {
        private FlowInputData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FlowInputData();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FlowInputData
        /// </summary>
        [Test]
        public void FlowInputDataInstanceTest()
        {
            Assert.IsInstanceOf<FlowInputData> (instance, "instance is a FlowInputData");
        }

        
        /// <summary>
        /// Test the property 'LinkedDocumentIds' 
        /// </summary>
        [Test]
        public void LinkedDocumentIdsTest()
        {
            // TODO: unit test for the property 'LinkedDocumentIds' 
        }
        

    }

}