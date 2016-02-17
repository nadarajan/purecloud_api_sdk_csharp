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
    public class CallbackTests
    {
        private Callback instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Callback();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Callback
        /// </summary>
        [Test]
        public void CallbackInstanceTest()
        {
            Assert.IsInstanceOf<Callback> (instance, "instance is a Callback");
        }

        
        /// <summary>
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
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
        /// Test the property 'Segments' 
        /// </summary>
        [Test]
        public void SegmentsTest()
        {
            // TODO: unit test for the property 'Segments' 
        }
        
        /// <summary>
        /// Test the property 'Direction' 
        /// </summary>
        [Test]
        public void DirectionTest()
        {
            // TODO: unit test for the property 'Direction' 
        }
        
        /// <summary>
        /// Test the property 'Held' 
        /// </summary>
        [Test]
        public void HeldTest()
        {
            // TODO: unit test for the property 'Held' 
        }
        
        /// <summary>
        /// Test the property 'DisconnectType' 
        /// </summary>
        [Test]
        public void DisconnectTypeTest()
        {
            // TODO: unit test for the property 'DisconnectType' 
        }
        
        /// <summary>
        /// Test the property 'StartHoldTime' 
        /// </summary>
        [Test]
        public void StartHoldTimeTest()
        {
            // TODO: unit test for the property 'StartHoldTime' 
        }
        
        /// <summary>
        /// Test the property 'DialerPreview' 
        /// </summary>
        [Test]
        public void DialerPreviewTest()
        {
            // TODO: unit test for the property 'DialerPreview' 
        }
        
        /// <summary>
        /// Test the property 'CallbackNumbers' 
        /// </summary>
        [Test]
        public void CallbackNumbersTest()
        {
            // TODO: unit test for the property 'CallbackNumbers' 
        }
        
        /// <summary>
        /// Test the property 'CallbackUserName' 
        /// </summary>
        [Test]
        public void CallbackUserNameTest()
        {
            // TODO: unit test for the property 'CallbackUserName' 
        }
        
        /// <summary>
        /// Test the property 'ScriptId' 
        /// </summary>
        [Test]
        public void ScriptIdTest()
        {
            // TODO: unit test for the property 'ScriptId' 
        }
        
        /// <summary>
        /// Test the property 'SkipEnabled' 
        /// </summary>
        [Test]
        public void SkipEnabledTest()
        {
            // TODO: unit test for the property 'SkipEnabled' 
        }
        
        /// <summary>
        /// Test the property 'TimeoutSeconds' 
        /// </summary>
        [Test]
        public void TimeoutSecondsTest()
        {
            // TODO: unit test for the property 'TimeoutSeconds' 
        }
        

    }

}