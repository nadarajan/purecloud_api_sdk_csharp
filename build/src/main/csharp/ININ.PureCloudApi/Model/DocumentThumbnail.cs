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
    /// DocumentThumbnail
    /// </summary>
    [DataContract]
    public partial class DocumentThumbnail :  IEquatable<DocumentThumbnail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentThumbnail" /> class.
        /// </summary>
        /// <param name="Resolution">Resolution.</param>
        /// <param name="ImageUri">ImageUri.</param>
        public DocumentThumbnail(string Resolution = null, string ImageUri = null)
        {
            this.Resolution = Resolution;
            this.ImageUri = ImageUri;
        }
        
        /// <summary>
        /// Gets or Sets Resolution
        /// </summary>
        [DataMember(Name="resolution", EmitDefaultValue=false)]
        public string Resolution { get; set; }
        /// <summary>
        /// Gets or Sets ImageUri
        /// </summary>
        [DataMember(Name="imageUri", EmitDefaultValue=false)]
        public string ImageUri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentThumbnail {\n");
            sb.Append("  Resolution: ").Append(Resolution).Append("\n");
            sb.Append("  ImageUri: ").Append(ImageUri).Append("\n");
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
            return this.Equals(obj as DocumentThumbnail);
        }

        /// <summary>
        /// Returns true if DocumentThumbnail instances are equal
        /// </summary>
        /// <param name="other">Instance of DocumentThumbnail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentThumbnail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Resolution == other.Resolution ||
                    this.Resolution != null &&
                    this.Resolution.Equals(other.Resolution)
                ) && 
                (
                    this.ImageUri == other.ImageUri ||
                    this.ImageUri != null &&
                    this.ImageUri.Equals(other.ImageUri)
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
                if (this.Resolution != null)
                    hash = hash * 59 + this.Resolution.GetHashCode();
                if (this.ImageUri != null)
                    hash = hash * 59 + this.ImageUri.GetHashCode();
                return hash;
            }
        }
    }

}