using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// VendorConnectionRequest
    /// </summary>
    [DataContract]
    public partial class VendorConnectionRequest :  IEquatable<VendorConnectionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorConnectionRequest" /> class.
        /// </summary>
        /// <param name="Publisher">Publisher.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Name">Name.</param>
        public VendorConnectionRequest(string Publisher = null, string Type = null, string Name = null)
        {
            this.Publisher = Publisher;
            this.Type = Type;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets Publisher
        /// </summary>
        [DataMember(Name="publisher", EmitDefaultValue=false)]
        public string Publisher { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VendorConnectionRequest {\n");
            sb.Append("  Publisher: ").Append(Publisher).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as VendorConnectionRequest);
        }

        /// <summary>
        /// Returns true if VendorConnectionRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of VendorConnectionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorConnectionRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Publisher == other.Publisher ||
                    this.Publisher != null &&
                    this.Publisher.Equals(other.Publisher)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.Publisher != null)
                    hash = hash * 59 + this.Publisher.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }
    }

}