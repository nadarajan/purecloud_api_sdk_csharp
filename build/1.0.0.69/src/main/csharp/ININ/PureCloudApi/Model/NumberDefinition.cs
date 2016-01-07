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
    public class NumberDefinition :  IEquatable<NumberDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberDefinition" /> class.
        /// </summary>
        public NumberDefinition()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MinimumValue
        /// </summary>
        [DataMember(Name="minimumValue", EmitDefaultValue=false)]
        public double? MinimumValue { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MaximumValue
        /// </summary>
        [DataMember(Name="maximumValue", EmitDefaultValue=false)]
        public double? MaximumValue { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DecimalPlaces
        /// </summary>
        [DataMember(Name="decimalPlaces", EmitDefaultValue=false)]
        public int? DecimalPlaces { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumberDefinition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MinimumValue: ").Append(MinimumValue).Append("\n");
            sb.Append("  MaximumValue: ").Append(MaximumValue).Append("\n");
            sb.Append("  DecimalPlaces: ").Append(DecimalPlaces).Append("\n");
            
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
            return this.Equals(obj as NumberDefinition);
        }

        /// <summary>
        /// Returns true if NumberDefinition instances are equal
        /// </summary>
        /// <param name="obj">Instance of NumberDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberDefinition other)
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
                    this.MinimumValue == other.MinimumValue ||
                    this.MinimumValue != null &&
                    this.MinimumValue.Equals(other.MinimumValue)
                ) && 
                (
                    this.MaximumValue == other.MaximumValue ||
                    this.MaximumValue != null &&
                    this.MaximumValue.Equals(other.MaximumValue)
                ) && 
                (
                    this.DecimalPlaces == other.DecimalPlaces ||
                    this.DecimalPlaces != null &&
                    this.DecimalPlaces.Equals(other.DecimalPlaces)
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
                
                if (this.MinimumValue != null)
                    hash = hash * 57 + this.MinimumValue.GetHashCode();
                
                if (this.MaximumValue != null)
                    hash = hash * 57 + this.MaximumValue.GetHashCode();
                
                if (this.DecimalPlaces != null)
                    hash = hash * 57 + this.DecimalPlaces.GetHashCode();
                
                return hash;
            }
        }

    }


}
