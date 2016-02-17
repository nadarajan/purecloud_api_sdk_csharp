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
    public class ShareTests
    {
        private Share instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Share();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Share
        /// </summary>
        [Test]
        public void ShareInstanceTest()
        {
            Assert.IsInstanceOf<Share> (instance, "instance is a Share");
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
        /// Test the property 'SharedEntityType' 
        /// </summary>
        [Test]
        public void SharedEntityTypeTest()
        {
            // TODO: unit test for the property 'SharedEntityType' 
        }
        
        /// <summary>
        /// Test the property 'SharedEntity' 
        /// </summary>
        [Test]
        public void SharedEntityTest()
        {
            // TODO: unit test for the property 'SharedEntity' 
        }
        
        /// <summary>
        /// Test the property 'MemberType' 
        /// </summary>
        [Test]
        public void MemberTypeTest()
        {
            // TODO: unit test for the property 'MemberType' 
        }
        
        /// <summary>
        /// Test the property 'Member' 
        /// </summary>
        [Test]
        public void MemberTest()
        {
            // TODO: unit test for the property 'Member' 
        }
        
        /// <summary>
        /// Test the property 'SharedBy' 
        /// </summary>
        [Test]
        public void SharedByTest()
        {
            // TODO: unit test for the property 'SharedBy' 
        }
        
        /// <summary>
        /// Test the property 'Workspace' 
        /// </summary>
        [Test]
        public void WorkspaceTest()
        {
            // TODO: unit test for the property 'Workspace' 
        }
        
        /// <summary>
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}