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
    public class FaxSendRequestTests
    {
        private FaxSendRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FaxSendRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FaxSendRequest
        /// </summary>
        [Test]
        public void FaxSendRequestInstanceTest()
        {
            Assert.IsInstanceOf<FaxSendRequest> (instance, "instance is a FaxSendRequest");
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
        /// Test the property 'Addresses' 
        /// </summary>
        [Test]
        public void AddressesTest()
        {
            // TODO: unit test for the property 'Addresses' 
        }
        
        /// <summary>
        /// Test the property 'OriginalFilename' 
        /// </summary>
        [Test]
        public void OriginalFilenameTest()
        {
            // TODO: unit test for the property 'OriginalFilename' 
        }
        
        /// <summary>
        /// Test the property 'ContentType' 
        /// </summary>
        [Test]
        public void ContentTypeTest()
        {
            // TODO: unit test for the property 'ContentType' 
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
        /// Test the property 'CoverSheet' 
        /// </summary>
        [Test]
        public void CoverSheetTest()
        {
            // TODO: unit test for the property 'CoverSheet' 
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