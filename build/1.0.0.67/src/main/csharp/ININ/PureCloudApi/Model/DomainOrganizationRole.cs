using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class DomainOrganizationRole :  IEquatable<DomainOrganizationRole>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainOrganizationRole" /> class.
        /// </summary>
        public DomainOrganizationRole()
        {
            this.RoleNeedsUpdate = false;
            this.Default = false;
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DefaultRoleId
        /// </summary>
        [DataMember(Name="defaultRoleId", EmitDefaultValue=false)]
        public string DefaultRoleId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name="permissions", EmitDefaultValue=false)]
        public List<string> Permissions { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Licenses
        /// </summary>
        [DataMember(Name="licenses", EmitDefaultValue=false)]
        public List<string> Licenses { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PermissionPolicies
        /// </summary>
        [DataMember(Name="permissionPolicies", EmitDefaultValue=false)]
        public List<DomainPermissionPolicy> PermissionPolicies { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }
  
        
        /// <summary>
        /// Gets or Sets UserCount
        /// </summary>
        [DataMember(Name="userCount", EmitDefaultValue=false)]
        public int? UserCount { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RoleNeedsUpdate
        /// </summary>
        [DataMember(Name="roleNeedsUpdate", EmitDefaultValue=false)]
        public bool? RoleNeedsUpdate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? Default { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainOrganizationRole {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DefaultRoleId: ").Append(DefaultRoleId).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  Licenses: ").Append(Licenses).Append("\n");
            sb.Append("  PermissionPolicies: ").Append(PermissionPolicies).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
            sb.Append("  RoleNeedsUpdate: ").Append(RoleNeedsUpdate).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as DomainOrganizationRole);
        }

        /// <summary>
        /// Returns true if DomainOrganizationRole instances are equal
        /// </summary>
        /// <param name="obj">Instance of DomainOrganizationRole to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainOrganizationRole other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.DefaultRoleId == other.DefaultRoleId ||
                    this.DefaultRoleId != null &&
                    this.DefaultRoleId.Equals(other.DefaultRoleId)
                ) && 
                (
                    this.Permissions == other.Permissions ||
                    this.Permissions != null &&
                    this.Permissions.SequenceEqual(other.Permissions)
                ) && 
                (
                    this.Licenses == other.Licenses ||
                    this.Licenses != null &&
                    this.Licenses.SequenceEqual(other.Licenses)
                ) && 
                (
                    this.PermissionPolicies == other.PermissionPolicies ||
                    this.PermissionPolicies != null &&
                    this.PermissionPolicies.SequenceEqual(other.PermissionPolicies)
                ) && 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.UserCount == other.UserCount ||
                    this.UserCount != null &&
                    this.UserCount.Equals(other.UserCount)
                ) && 
                (
                    this.RoleNeedsUpdate == other.RoleNeedsUpdate ||
                    this.RoleNeedsUpdate != null &&
                    this.RoleNeedsUpdate.Equals(other.RoleNeedsUpdate)
                ) && 
                (
                    this.Default == other.Default ||
                    this.Default != null &&
                    this.Default.Equals(other.Default)
                ) && 
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 57 + this.Description.GetHashCode();
                
                if (this.DefaultRoleId != null)
                    hash = hash * 57 + this.DefaultRoleId.GetHashCode();
                
                if (this.Permissions != null)
                    hash = hash * 57 + this.Permissions.GetHashCode();
                
                if (this.Licenses != null)
                    hash = hash * 57 + this.Licenses.GetHashCode();
                
                if (this.PermissionPolicies != null)
                    hash = hash * 57 + this.PermissionPolicies.GetHashCode();
                
                if (this.Code != null)
                    hash = hash * 57 + this.Code.GetHashCode();
                
                if (this.UserCount != null)
                    hash = hash * 57 + this.UserCount.GetHashCode();
                
                if (this.RoleNeedsUpdate != null)
                    hash = hash * 57 + this.RoleNeedsUpdate.GetHashCode();
                
                if (this.Default != null)
                    hash = hash * 57 + this.Default.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}