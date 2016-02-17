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
    public class OccurrenceTests
    {
        private Occurrence instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Occurrence();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Occurrence
        /// </summary>
        [Test]
        public void OccurrenceInstanceTest()
        {
            Assert.IsInstanceOf<Occurrence> (instance, "instance is a Occurrence");
        }

        
        /// <summary>
        /// Test the property 'Limit' 
        /// </summary>
        [Test]
        public void LimitTest()
        {
            // TODO: unit test for the property 'Limit' 
        }
        
        /// <summary>
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        

    }

}