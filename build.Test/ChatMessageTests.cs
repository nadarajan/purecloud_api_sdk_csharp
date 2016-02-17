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
    public class ChatMessageTests
    {
        private ChatMessage instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ChatMessage();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ChatMessage
        /// </summary>
        [Test]
        public void ChatMessageInstanceTest()
        {
            Assert.IsInstanceOf<ChatMessage> (instance, "instance is a ChatMessage");
        }

        
        /// <summary>
        /// Test the property 'Body' 
        /// </summary>
        [Test]
        public void BodyTest()
        {
            // TODO: unit test for the property 'Body' 
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
        /// Test the property 'To' 
        /// </summary>
        [Test]
        public void ToTest()
        {
            // TODO: unit test for the property 'To' 
        }
        
        /// <summary>
        /// Test the property 'From' 
        /// </summary>
        [Test]
        public void FromTest()
        {
            // TODO: unit test for the property 'From' 
        }
        
        /// <summary>
        /// Test the property 'Utc' 
        /// </summary>
        [Test]
        public void UtcTest()
        {
            // TODO: unit test for the property 'Utc' 
        }
        
        /// <summary>
        /// Test the property 'Chat' 
        /// </summary>
        [Test]
        public void ChatTest()
        {
            // TODO: unit test for the property 'Chat' 
        }
        
        /// <summary>
        /// Test the property 'Message' 
        /// </summary>
        [Test]
        public void MessageTest()
        {
            // TODO: unit test for the property 'Message' 
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
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        

    }

}