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
    public class ControlOptionsTests
    {
        private ControlOptions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ControlOptions();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ControlOptions
        /// </summary>
        [Test]
        public void ControlOptionsInstanceTest()
        {
            Assert.IsInstanceOf<ControlOptions> (instance, "instance is a ControlOptions");
        }

        
        /// <summary>
        /// Test the property 'Value' 
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO: unit test for the property 'Value' 
        }
        
        /// <summary>
        /// Test the property 'Label' 
        /// </summary>
        [Test]
        public void LabelTest()
        {
            // TODO: unit test for the property 'Label' 
        }
        

    }

}