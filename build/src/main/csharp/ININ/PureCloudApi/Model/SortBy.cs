using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class SortBy :  IEquatable<SortBy>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SortBy" /> class.
        /// </summary>
        public SortBy()
        {
            this.Ascending = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Ascending
        /// </summary>
        [DataMember(Name="ascending", EmitDefaultValue=false)]
        public bool? Ascending { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SortBy {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Ascending: ").Append(Ascending).Append("\n");
            
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
            return this.Equals(obj as SortBy);
        }

        /// <summary>
        /// Returns true if SortBy instances are equal
        /// </summary>
        /// <param name="other">Instance of SortBy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SortBy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Ascending == other.Ascending ||
                    this.Ascending != null &&
                    this.Ascending.Equals(other.Ascending)
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
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Ascending != null)
                    hash = hash * 59 + this.Ascending.GetHashCode();
                
                return hash;
            }
        }

    }
}