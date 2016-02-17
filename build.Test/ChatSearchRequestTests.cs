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
    public class ChatSearchRequestTests
    {
        private ChatSearchRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChatSearchRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ChatSearchRequest
        /// </summary>
        [Test]
        public void ChatSearchRequestInstanceTest()
        {
            Assert.IsInstanceOf<ChatSearchRequest> (instance, "instance is a ChatSearchRequest");
        }

        
        /// <summary>
        /// Test the property 'Query' 
        /// </summary>
        [Test]
        public void QueryTest()
        {
            // TODO: unit test for the property 'Query' 
        }
        
        /// <summary>
        /// Test the property 'Order' 
        /// </summary>
        [Test]
        public void OrderTest()
        {
            // TODO: unit test for the property 'Order' 
        }
        
        /// <summary>
        /// Test the property 'TargetJids' 
        /// </summary>
        [Test]
        public void TargetJidsTest()
        {
            // TODO: unit test for the property 'TargetJids' 
        }
        
        /// <summary>
        /// Test the property 'PageSize' 
        /// </summary>
        [Test]
        public void PageSizeTest()
        {
            // TODO: unit test for the property 'PageSize' 
        }
        
        /// <summary>
        /// Test the property 'PageNumber' 
        /// </summary>
        [Test]
        public void PageNumberTest()
        {
            // TODO: unit test for the property 'PageNumber' 
        }
        
        /// <summary>
        /// Test the property 'FromDate' 
        /// </summary>
        [Test]
        public void FromDateTest()
        {
            // TODO: unit test for the property 'FromDate' 
        }
        
        /// <summary>
        /// Test the property 'ToDate' 
        /// </summary>
        [Test]
        public void ToDateTest()
        {
            // TODO: unit test for the property 'ToDate' 
        }
        
        /// <summary>
        /// Test the property 'Expand' 
        /// </summary>
        [Test]
        public void ExpandTest()
        {
            // TODO: unit test for the property 'Expand' 
        }
        

    }

}