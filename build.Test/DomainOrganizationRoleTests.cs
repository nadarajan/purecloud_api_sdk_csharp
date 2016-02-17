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
    public class DomainOrganizationRoleTests
    {
        private DomainOrganizationRole instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainOrganizationRole();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainOrganizationRole
        /// </summary>
        [Test]
        public void DomainOrganizationRoleInstanceTest()
        {
            Assert.IsInstanceOf<DomainOrganizationRole> (instance, "instance is a DomainOrganizationRole");
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
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'DefaultRoleId' 
        /// </summary>
        [Test]
        public void DefaultRoleIdTest()
        {
            // TODO: unit test for the property 'DefaultRoleId' 
        }
        
        /// <summary>
        /// Test the property 'Permissions' 
        /// </summary>
        [Test]
        public void PermissionsTest()
        {
            // TODO: unit test for the property 'Permissions' 
        }
        
        /// <summary>
        /// Test the property 'Licenses' 
        /// </summary>
        [Test]
        public void LicensesTest()
        {
            // TODO: unit test for the property 'Licenses' 
        }
        
        /// <summary>
        /// Test the property 'PermissionPolicies' 
        /// </summary>
        [Test]
        public void PermissionPoliciesTest()
        {
            // TODO: unit test for the property 'PermissionPolicies' 
        }
        
        /// <summary>
        /// Test the property 'Code' 
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO: unit test for the property 'Code' 
        }
        
        /// <summary>
        /// Test the property 'UserCount' 
        /// </summary>
        [Test]
        public void UserCountTest()
        {
            // TODO: unit test for the property 'UserCount' 
        }
        
        /// <summary>
        /// Test the property 'RoleNeedsUpdate' 
        /// </summary>
        [Test]
        public void RoleNeedsUpdateTest()
        {
            // TODO: unit test for the property 'RoleNeedsUpdate' 
        }
        
        /// <summary>
        /// Test the property 'Default' 
        /// </summary>
        [Test]
        public void DefaultTest()
        {
            // TODO: unit test for the property 'Default' 
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