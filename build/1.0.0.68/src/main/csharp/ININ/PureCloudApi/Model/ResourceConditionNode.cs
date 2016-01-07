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
    public class ResourceConditionNode :  IEquatable<ResourceConditionNode>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceConditionNode" /> class.
        /// </summary>
        public ResourceConditionNode()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets VariableName
        /// </summary>
        [DataMember(Name="variableName", EmitDefaultValue=false)]
        public string VariableName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Conjunction
        /// </summary>
        [DataMember(Name="conjunction", EmitDefaultValue=false)]
        public string Conjunction { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Operator
        /// </summary>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public string Operator { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Operands
        /// </summary>
        [DataMember(Name="operands", EmitDefaultValue=false)]
        public List<ResourceConditionValue> Operands { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Terms
        /// </summary>
        [DataMember(Name="terms", EmitDefaultValue=false)]
        public List<ResourceConditionNode> Terms { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceConditionNode {\n");
            sb.Append("  VariableName: ").Append(VariableName).Append("\n");
            sb.Append("  Conjunction: ").Append(Conjunction).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  Operands: ").Append(Operands).Append("\n");
            sb.Append("  Terms: ").Append(Terms).Append("\n");
            
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
            return this.Equals(obj as ResourceConditionNode);
        }

        /// <summary>
        /// Returns true if ResourceConditionNode instances are equal
        /// </summary>
        /// <param name="obj">Instance of ResourceConditionNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceConditionNode other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.VariableName == other.VariableName ||
                    this.VariableName != null &&
                    this.VariableName.Equals(other.VariableName)
                ) && 
                (
                    this.Conjunction == other.Conjunction ||
                    this.Conjunction != null &&
                    this.Conjunction.Equals(other.Conjunction)
                ) && 
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) && 
                (
                    this.Operands == other.Operands ||
                    this.Operands != null &&
                    this.Operands.SequenceEqual(other.Operands)
                ) && 
                (
                    this.Terms == other.Terms ||
                    this.Terms != null &&
                    this.Terms.SequenceEqual(other.Terms)
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
                
                if (this.VariableName != null)
                    hash = hash * 57 + this.VariableName.GetHashCode();
                
                if (this.Conjunction != null)
                    hash = hash * 57 + this.Conjunction.GetHashCode();
                
                if (this.Operator != null)
                    hash = hash * 57 + this.Operator.GetHashCode();
                
                if (this.Operands != null)
                    hash = hash * 57 + this.Operands.GetHashCode();
                
                if (this.Terms != null)
                    hash = hash * 57 + this.Terms.GetHashCode();
                
                return hash;
            }
        }

    }


}
