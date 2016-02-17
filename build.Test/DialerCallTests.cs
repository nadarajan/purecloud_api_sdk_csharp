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
    public class DialerCallTests
    {
        private DialerCall instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DialerCall();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DialerCall
        /// </summary>
        [Test]
        public void DialerCallInstanceTest()
        {
            Assert.IsInstanceOf<DialerCall> (instance, "instance is a DialerCall");
        }

        
        /// <summary>
        /// Test the property 'CallId' 
        /// </summary>
        [Test]
        public void CallIdTest()
        {
            // TODO: unit test for the property 'CallId' 
        }
        
        /// <summary>
        /// Test the property 'ConversationId' 
        /// </summary>
        [Test]
        public void ConversationIdTest()
        {
            // TODO: unit test for the property 'ConversationId' 
        }
        

    }

}