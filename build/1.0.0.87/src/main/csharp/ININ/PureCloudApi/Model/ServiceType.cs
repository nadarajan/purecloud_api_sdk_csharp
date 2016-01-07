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
    public class ServiceType :  IEquatable<ServiceType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceType" /> class.
        /// </summary>
        public ServiceType()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Parameters
        /// </summary>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public Dictionary<string, string> Parameters { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Codecs
        /// </summary>
        [DataMember(Name="codecs", EmitDefaultValue=false)]
        public List<string> Codecs { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CallingPartyId
        /// </summary>
        [DataMember(Name="callingPartyId", EmitDefaultValue=false)]
        public string CallingPartyId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CallHistory
        /// </summary>
        [DataMember(Name="callHistory", EmitDefaultValue=false)]
        public string CallHistory { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Prefix
        /// </summary>
        [DataMember(Name="prefix", EmitDefaultValue=false)]
        public string Prefix { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  Codecs: ").Append(Codecs).Append("\n");
            sb.Append("  CallingPartyId: ").Append(CallingPartyId).Append("\n");
            sb.Append("  CallHistory: ").Append(CallHistory).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            
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
            return this.Equals(obj as ServiceType);
        }

        /// <summary>
        /// Returns true if ServiceType instances are equal
        /// </summary>
        /// <param name="obj">Instance of ServiceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceType other)
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
                    this.Parameters == other.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(other.Parameters)
                ) && 
                (
                    this.Codecs == other.Codecs ||
                    this.Codecs != null &&
                    this.Codecs.SequenceEqual(other.Codecs)
                ) && 
                (
                    this.CallingPartyId == other.CallingPartyId ||
                    this.CallingPartyId != null &&
                    this.CallingPartyId.Equals(other.CallingPartyId)
                ) && 
                (
                    this.CallHistory == other.CallHistory ||
                    this.CallHistory != null &&
                    this.CallHistory.Equals(other.CallHistory)
                ) && 
                (
                    this.Prefix == other.Prefix ||
                    this.Prefix != null &&
                    this.Prefix.Equals(other.Prefix)
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
                
                if (this.Parameters != null)
                    hash = hash * 57 + this.Parameters.GetHashCode();
                
                if (this.Codecs != null)
                    hash = hash * 57 + this.Codecs.GetHashCode();
                
                if (this.CallingPartyId != null)
                    hash = hash * 57 + this.CallingPartyId.GetHashCode();
                
                if (this.CallHistory != null)
                    hash = hash * 57 + this.CallHistory.GetHashCode();
                
                if (this.Prefix != null)
                    hash = hash * 57 + this.Prefix.GetHashCode();
                
                return hash;
            }
        }

    }


}