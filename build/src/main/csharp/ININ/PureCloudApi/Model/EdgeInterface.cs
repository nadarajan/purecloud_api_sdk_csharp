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
    public class EdgeInterface :  IEquatable<EdgeInterface>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeInterface" /> class.
        /// </summary>
        public EdgeInterface()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MacAddress
        /// </summary>
        [DataMember(Name="macAddress", EmitDefaultValue=false)]
        public string MacAddress { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IfName
        /// </summary>
        [DataMember(Name="ifName", EmitDefaultValue=false)]
        public string IfName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Endpoints
        /// </summary>
        [DataMember(Name="endpoints", EmitDefaultValue=false)]
        public List<UriReference> Endpoints { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LineTypes
        /// </summary>
        [DataMember(Name="lineTypes", EmitDefaultValue=false)]
        public List<string> LineTypes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AddressFamilyId
        /// </summary>
        [DataMember(Name="addressFamilyId", EmitDefaultValue=false)]
        public string AddressFamilyId { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EdgeInterface {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  MacAddress: ").Append(MacAddress).Append("\n");
            sb.Append("  IfName: ").Append(IfName).Append("\n");
            sb.Append("  Endpoints: ").Append(Endpoints).Append("\n");
            sb.Append("  LineTypes: ").Append(LineTypes).Append("\n");
            sb.Append("  AddressFamilyId: ").Append(AddressFamilyId).Append("\n");
            
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
            return this.Equals(obj as EdgeInterface);
        }

        /// <summary>
        /// Returns true if EdgeInterface instances are equal
        /// </summary>
        /// <param name="obj">Instance of EdgeInterface to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeInterface other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.MacAddress == other.MacAddress ||
                    this.MacAddress != null &&
                    this.MacAddress.Equals(other.MacAddress)
                ) && 
                (
                    this.IfName == other.IfName ||
                    this.IfName != null &&
                    this.IfName.Equals(other.IfName)
                ) && 
                (
                    this.Endpoints == other.Endpoints ||
                    this.Endpoints != null &&
                    this.Endpoints.SequenceEqual(other.Endpoints)
                ) && 
                (
                    this.LineTypes == other.LineTypes ||
                    this.LineTypes != null &&
                    this.LineTypes.SequenceEqual(other.LineTypes)
                ) && 
                (
                    this.AddressFamilyId == other.AddressFamilyId ||
                    this.AddressFamilyId != null &&
                    this.AddressFamilyId.Equals(other.AddressFamilyId)
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
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.IpAddress != null)
                    hash = hash * 57 + this.IpAddress.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.MacAddress != null)
                    hash = hash * 57 + this.MacAddress.GetHashCode();
                
                if (this.IfName != null)
                    hash = hash * 57 + this.IfName.GetHashCode();
                
                if (this.Endpoints != null)
                    hash = hash * 57 + this.Endpoints.GetHashCode();
                
                if (this.LineTypes != null)
                    hash = hash * 57 + this.LineTypes.GetHashCode();
                
                if (this.AddressFamilyId != null)
                    hash = hash * 57 + this.AddressFamilyId.GetHashCode();
                
                return hash;
            }
        }

    }


}
