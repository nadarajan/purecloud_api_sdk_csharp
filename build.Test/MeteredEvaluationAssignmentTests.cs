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
    public class MeteredEvaluationAssignmentTests
    {
        private MeteredEvaluationAssignment instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MeteredEvaluationAssignment();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of MeteredEvaluationAssignment
        /// </summary>
        [Test]
        public void MeteredEvaluationAssignmentInstanceTest()
        {
            Assert.IsInstanceOf<MeteredEvaluationAssignment> (instance, "instance is a MeteredEvaluationAssignment");
        }

        
        /// <summary>
        /// Test the property 'EvaluationContextId' 
        /// </summary>
        [Test]
        public void EvaluationContextIdTest()
        {
            // TODO: unit test for the property 'EvaluationContextId' 
        }
        
        /// <summary>
        /// Test the property 'Evaluators' 
        /// </summary>
        [Test]
        public void EvaluatorsTest()
        {
            // TODO: unit test for the property 'Evaluators' 
        }
        
        /// <summary>
        /// Test the property 'MaxNumberEvaluations' 
        /// </summary>
        [Test]
        public void MaxNumberEvaluationsTest()
        {
            // TODO: unit test for the property 'MaxNumberEvaluations' 
        }
        
        /// <summary>
        /// Test the property 'EvaluationForm' 
        /// </summary>
        [Test]
        public void EvaluationFormTest()
        {
            // TODO: unit test for the property 'EvaluationForm' 
        }
        
        /// <summary>
        /// Test the property 'AssignToActiveUser' 
        /// </summary>
        [Test]
        public void AssignToActiveUserTest()
        {
            // TODO: unit test for the property 'AssignToActiveUser' 
        }
        
        /// <summary>
        /// Test the property 'TimeInterval' 
        /// </summary>
        [Test]
        public void TimeIntervalTest()
        {
            // TODO: unit test for the property 'TimeInterval' 
        }
        

    }

}