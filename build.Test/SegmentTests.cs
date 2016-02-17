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
    public class SegmentTests
    {
        private Segment instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Segment();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Segment
        /// </summary>
        [Test]
        public void SegmentInstanceTest()
        {
            Assert.IsInstanceOf<Segment> (instance, "instance is a Segment");
        }

        
        /// <summary>
        /// Test the property 'StartTime' 
        /// </summary>
        [Test]
        public void StartTimeTest()
        {
            // TODO: unit test for the property 'StartTime' 
        }
        
        /// <summary>
        /// Test the property 'EndTime' 
        /// </summary>
        [Test]
        public void EndTimeTest()
        {
            // TODO: unit test for the property 'EndTime' 
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
        /// Test the property 'HowEnded' 
        /// </summary>
        [Test]
        public void HowEndedTest()
        {
            // TODO: unit test for the property 'HowEnded' 
        }
        
        /// <summary>
        /// Test the property 'DisconnectType' 
        /// </summary>
        [Test]
        public void DisconnectTypeTest()
        {
            // TODO: unit test for the property 'DisconnectType' 
        }
        

    }

}