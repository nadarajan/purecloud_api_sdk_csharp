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
    public class DomainPermission :  IEquatable<DomainPermission>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPermission" /> class.
        /// </summary>
        public DomainPermission()
        {
            this.AllowsConditions = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Licenses
        /// </summary>
        [DataMember(Name="licenses", EmitDefaultValue=false)]
        public List<string> Licenses { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AllowsConditions
        /// </summary>
        [DataMember(Name="allowsConditions", EmitDefaultValue=false)]
        public bool? AllowsConditions { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPermission {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Licenses: ").Append(Licenses).Append("\n");
            sb.Append("  AllowsConditions: ").Append(AllowsConditions).Append("\n");
            
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
            return this.Equals(obj as DomainPermission);
        }

        /// <summary>
        /// Returns true if DomainPermission instances are equal
        /// </summary>
        /// <param name="obj">Instance of DomainPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPermission other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) && 
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.Label == other.Label ||
                    this.Label != null &&
                    this.Label.Equals(other.Label)
                ) && 
                (
                    this.Licenses == other.Licenses ||
                    this.Licenses != null &&
                    this.Licenses.SequenceEqual(other.Licenses)
                ) && 
                (
                    this.AllowsConditions == other.AllowsConditions ||
                    this.AllowsConditions != null &&
                    this.AllowsConditions.Equals(other.AllowsConditions)
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
                
                if (this.Domain != null)
                    hash = hash * 57 + this.Domain.GetHashCode();
                
                if (this.EntityType != null)
                    hash = hash * 57 + this.EntityType.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 57 + this.Action.GetHashCode();
                
                if (this.Label != null)
                    hash = hash * 57 + this.Label.GetHashCode();
                
                if (this.Licenses != null)
                    hash = hash * 57 + this.Licenses.GetHashCode();
                
                if (this.AllowsConditions != null)
                    hash = hash * 57 + this.AllowsConditions.GetHashCode();
                
                return hash;
            }
        }

    }


}