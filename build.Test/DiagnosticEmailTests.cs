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
    public class DiagnosticEmailTests
    {
        private DiagnosticEmail instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DiagnosticEmail();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DiagnosticEmail
        /// </summary>
        [Test]
        public void DiagnosticEmailInstanceTest()
        {
            Assert.IsInstanceOf<DiagnosticEmail> (instance, "instance is a DiagnosticEmail");
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
        /// Test the property 'Subject' 
        /// </summary>
        [Test]
        public void SubjectTest()
        {
            // TODO: unit test for the property 'Subject' 
        }
        
        /// <summary>
        /// Test the property 'Topic' 
        /// </summary>
        [Test]
        public void TopicTest()
        {
            // TODO: unit test for the property 'Topic' 
        }
        
        /// <summary>
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'Priority' 
        /// </summary>
        [Test]
        public void PriorityTest()
        {
            // TODO: unit test for the property 'Priority' 
        }
        
        /// <summary>
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'Data' 
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO: unit test for the property 'Data' 
        }
        

    }

}