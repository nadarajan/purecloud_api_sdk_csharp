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
    public class Ring :  IEquatable<Ring>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ring" /> class.
        /// </summary>
        public Ring()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets ExpansionCriteria
        /// </summary>
        [DataMember(Name="expansionCriteria", EmitDefaultValue=false)]
        public List<ExpansionCriterium> ExpansionCriteria { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Actions
        /// </summary>
        [DataMember(Name="actions", EmitDefaultValue=false)]
        public Actions Actions { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ring {\n");
            sb.Append("  ExpansionCriteria: ").Append(ExpansionCriteria).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            
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
            return this.Equals(obj as Ring);
        }

        /// <summary>
        /// Returns true if Ring instances are equal
        /// </summary>
        /// <param name="obj">Instance of Ring to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ring other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExpansionCriteria == other.ExpansionCriteria ||
                    this.ExpansionCriteria != null &&
                    this.ExpansionCriteria.SequenceEqual(other.ExpansionCriteria)
                ) && 
                (
                    this.Actions == other.Actions ||
                    this.Actions != null &&
                    this.Actions.Equals(other.Actions)
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
                
                if (this.ExpansionCriteria != null)
                    hash = hash * 57 + this.ExpansionCriteria.GetHashCode();
                
                if (this.Actions != null)
                    hash = hash * 57 + this.Actions.GetHashCode();
                
                return hash;
            }
        }

    }


}