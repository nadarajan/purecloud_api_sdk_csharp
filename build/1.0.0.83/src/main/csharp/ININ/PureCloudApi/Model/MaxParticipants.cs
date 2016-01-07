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
    public class MaxParticipants :  IEquatable<MaxParticipants>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MaxParticipants" /> class.
        /// </summary>
        public MaxParticipants()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets _MaxParticipants
        /// </summary>
        [DataMember(Name="maxParticipants", EmitDefaultValue=false)]
        public int? _MaxParticipants { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MaxParticipants {\n");
            sb.Append("  _MaxParticipants: ").Append(_MaxParticipants).Append("\n");
            
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
            return this.Equals(obj as MaxParticipants);
        }

        /// <summary>
        /// Returns true if MaxParticipants instances are equal
        /// </summary>
        /// <param name="obj">Instance of MaxParticipants to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MaxParticipants other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._MaxParticipants == other._MaxParticipants ||
                    this._MaxParticipants != null &&
                    this._MaxParticipants.Equals(other._MaxParticipants)
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
                
                if (this._MaxParticipants != null)
                    hash = hash * 57 + this._MaxParticipants.GetHashCode();
                
                return hash;
            }
        }

    }


}