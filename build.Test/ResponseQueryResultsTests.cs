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
    public class ResponseQueryResultsTests
    {
        private ResponseQueryResults instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ResponseQueryResults();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ResponseQueryResults
        /// </summary>
        [Test]
        public void ResponseQueryResultsInstanceTest()
        {
            Assert.IsInstanceOf<ResponseQueryResults> (instance, "instance is a ResponseQueryResults");
        }

        
        /// <summary>
        /// Test the property 'Results' 
        /// </summary>
        [Test]
        public void ResultsTest()
        {
            // TODO: unit test for the property 'Results' 
        }
        

    }

}