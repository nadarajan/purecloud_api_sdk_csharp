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
    ///  Class for testing UserRoutingSkill
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserRoutingSkillTests
    {
        private UserRoutingSkill instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UserRoutingSkill();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UserRoutingSkill
        /// </summary>
        [Test]
        public void UserRoutingSkillInstanceTest()
        {
            Assert.IsInstanceOf<UserRoutingSkill> (instance, "instance is a UserRoutingSkill");
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
        /// Test the property 'Proficiency' 
        /// </summary>
        [Test]
        public void ProficiencyTest()
        {
            // TODO: unit test for the property 'Proficiency' 
        }
        
        /// <summary>
        /// Test the property 'Active' 
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO: unit test for the property 'Active' 
        }
        
        /// <summary>
        /// Test the property 'SkillUri' 
        /// </summary>
        [Test]
        public void SkillUriTest()
        {
            // TODO: unit test for the property 'SkillUri' 
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