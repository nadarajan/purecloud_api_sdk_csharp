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
    public class MediaPoliciesTests
    {
        private MediaPolicies instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MediaPolicies();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of MediaPolicies
        /// </summary>
        [Test]
        public void MediaPoliciesInstanceTest()
        {
            Assert.IsInstanceOf<MediaPolicies> (instance, "instance is a MediaPolicies");
        }

        
        /// <summary>
        /// Test the property 'CallPolicy' 
        /// </summary>
        [Test]
        public void CallPolicyTest()
        {
            // TODO: unit test for the property 'CallPolicy' 
        }
        
        /// <summary>
        /// Test the property 'ChatPolicy' 
        /// </summary>
        [Test]
        public void ChatPolicyTest()
        {
            // TODO: unit test for the property 'ChatPolicy' 
        }
        
        /// <summary>
        /// Test the property 'EmailPolicy' 
        /// </summary>
        [Test]
        public void EmailPolicyTest()
        {
            // TODO: unit test for the property 'EmailPolicy' 
        }
        

    }

}
