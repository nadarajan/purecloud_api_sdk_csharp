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
    public class FacetTermTests
    {
        private FacetTerm instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FacetTerm();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FacetTerm
        /// </summary>
        [Test]
        public void FacetTermInstanceTest()
        {
            Assert.IsInstanceOf<FacetTerm> (instance, "instance is a FacetTerm");
        }

        
        /// <summary>
        /// Test the property 'Term' 
        /// </summary>
        [Test]
        public void TermTest()
        {
            // TODO: unit test for the property 'Term' 
        }
        
        /// <summary>
        /// Test the property 'Key' 
        /// </summary>
        [Test]
        public void KeyTest()
        {
            // TODO: unit test for the property 'Key' 
        }
        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'Count' 
        /// </summary>
        [Test]
        public void CountTest()
        {
            // TODO: unit test for the property 'Count' 
        }
        
        /// <summary>
        /// Test the property 'Time' 
        /// </summary>
        [Test]
        public void TimeTest()
        {
            // TODO: unit test for the property 'Time' 
        }
        

    }

}