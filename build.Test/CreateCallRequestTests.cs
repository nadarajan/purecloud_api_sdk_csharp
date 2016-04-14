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
    /// <summary>
    ///  Class for testing CreateCallRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CreateCallRequestTests
    {
        private CreateCallRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CreateCallRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CreateCallRequest
        /// </summary>
        [Test]
        public void CreateCallRequestInstanceTest()
        {
            Assert.IsInstanceOf<CreateCallRequest> (instance, "instance is a CreateCallRequest");
        }

        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO: unit test for the property 'PhoneNumber'
        }
        /// <summary>
        /// Test the property 'CallFromQueueId'
        /// </summary>
        [Test]
        public void CallFromQueueIdTest()
        {
            // TODO: unit test for the property 'CallFromQueueId'
        }
        /// <summary>
        /// Test the property 'CallQueueId'
        /// </summary>
        [Test]
        public void CallQueueIdTest()
        {
            // TODO: unit test for the property 'CallQueueId'
        }
        /// <summary>
        /// Test the property 'CallUserId'
        /// </summary>
        [Test]
        public void CallUserIdTest()
        {
            // TODO: unit test for the property 'CallUserId'
        }
        /// <summary>
        /// Test the property 'Priority'
        /// </summary>
        [Test]
        public void PriorityTest()
        {
            // TODO: unit test for the property 'Priority'
        }
        /// <summary>
        /// Test the property 'LanguageId'
        /// </summary>
        [Test]
        public void LanguageIdTest()
        {
            // TODO: unit test for the property 'LanguageId'
        }
        /// <summary>
        /// Test the property 'RoutingSkillsIds'
        /// </summary>
        [Test]
        public void RoutingSkillsIdsTest()
        {
            // TODO: unit test for the property 'RoutingSkillsIds'
        }
        /// <summary>
        /// Test the property 'ConversationIds'
        /// </summary>
        [Test]
        public void ConversationIdsTest()
        {
            // TODO: unit test for the property 'ConversationIds'
        }
        /// <summary>
        /// Test the property 'Participants'
        /// </summary>
        [Test]
        public void ParticipantsTest()
        {
            // TODO: unit test for the property 'Participants'
        }

    }

}
