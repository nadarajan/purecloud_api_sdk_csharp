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
    public class ClientSpreadsheetTransformTests
    {
        private ClientSpreadsheetTransform instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ClientSpreadsheetTransform();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ClientSpreadsheetTransform
        /// </summary>
        [Test]
        public void ClientSpreadsheetTransformInstanceTest()
        {
            Assert.IsInstanceOf<ClientSpreadsheetTransform> (instance, "instance is a ClientSpreadsheetTransform");
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
        /// Test the property 'EndpointId' 
        /// </summary>
        [Test]
        public void EndpointIdTest()
        {
            // TODO: unit test for the property 'EndpointId' 
        }
        
        /// <summary>
        /// Test the property 'FilenameReplaces' 
        /// </summary>
        [Test]
        public void FilenameReplacesTest()
        {
            // TODO: unit test for the property 'FilenameReplaces' 
        }
        
        /// <summary>
        /// Test the property 'Tags' 
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO: unit test for the property 'Tags' 
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
        /// Test the property 'SheetNameReplaces' 
        /// </summary>
        [Test]
        public void SheetNameReplacesTest()
        {
            // TODO: unit test for the property 'SheetNameReplaces' 
        }
        
        /// <summary>
        /// Test the property 'Sheets' 
        /// </summary>
        [Test]
        public void SheetsTest()
        {
            // TODO: unit test for the property 'Sheets' 
        }
        

    }

}