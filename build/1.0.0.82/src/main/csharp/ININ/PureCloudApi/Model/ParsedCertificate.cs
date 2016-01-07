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
    /// Represents the parsed certificate information.
    /// </summary>
    [DataContract]
    public class ParsedCertificate :  IEquatable<ParsedCertificate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParsedCertificate" /> class.
        /// </summary>
        public ParsedCertificate()
        {
            
        }

        
        /// <summary>
        /// The details of the certificates that were parsed correctly.
        /// </summary>
        /// <value>The details of the certificates that were parsed correctly.</value>
        [DataMember(Name="certificateDetails", EmitDefaultValue=false)]
        public List<CertificateDetails> CertificateDetails { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParsedCertificate {\n");
            sb.Append("  CertificateDetails: ").Append(CertificateDetails).Append("\n");
            
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
            return this.Equals(obj as ParsedCertificate);
        }

        /// <summary>
        /// Returns true if ParsedCertificate instances are equal
        /// </summary>
        /// <param name="obj">Instance of ParsedCertificate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParsedCertificate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CertificateDetails == other.CertificateDetails ||
                    this.CertificateDetails != null &&
                    this.CertificateDetails.SequenceEqual(other.CertificateDetails)
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
                
                if (this.CertificateDetails != null)
                    hash = hash * 57 + this.CertificateDetails.GetHashCode();
                
                return hash;
            }
        }

    }


}