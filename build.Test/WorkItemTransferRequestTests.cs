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
    public class WorkItemTransferRequestTests
    {
        private WorkItemTransferRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkItemTransferRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkItemTransferRequest
        /// </summary>
        [Test]
        public void WorkItemTransferRequestInstanceTest()
        {
            Assert.IsInstanceOf<WorkItemTransferRequest> (instance, "instance is a WorkItemTransferRequest");
        }

        
        /// <summary>
        /// Test the property 'TransferTargetType' 
        /// </summary>
        [Test]
        public void TransferTargetTypeTest()
        {
            // TODO: unit test for the property 'TransferTargetType' 
        }
        
        /// <summary>
        /// Test the property 'TransferTarget' 
        /// </summary>
        [Test]
        public void TransferTargetTest()
        {
            // TODO: unit test for the property 'TransferTarget' 
        }
        

    }

}