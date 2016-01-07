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
    public class SessionRequest :  IEquatable<SessionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequest" /> class.
        /// </summary>
        public SessionRequest()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets MinutesToLive
        /// </summary>
        [DataMember(Name="minutesToLive", EmitDefaultValue=false)]
        public long? MinutesToLive { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionRequest {\n");
            sb.Append("  MinutesToLive: ").Append(MinutesToLive).Append("\n");
            
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
            return this.Equals(obj as SessionRequest);
        }

        /// <summary>
        /// Returns true if SessionRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of SessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SessionRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MinutesToLive == other.MinutesToLive ||
                    this.MinutesToLive != null &&
                    this.MinutesToLive.Equals(other.MinutesToLive)
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
                
                if (this.MinutesToLive != null)
                    hash = hash * 57 + this.MinutesToLive.GetHashCode();
                
                return hash;
            }
        }

    }


}