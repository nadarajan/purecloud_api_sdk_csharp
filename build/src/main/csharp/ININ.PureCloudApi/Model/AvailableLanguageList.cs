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
    /// AvailableLanguageList
    /// </summary>
    [DataContract]
    public partial class AvailableLanguageList :  IEquatable<AvailableLanguageList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvailableLanguageList" /> class.
        /// </summary>
        /// <param name="Languages">Languages.</param>
        public AvailableLanguageList(List<string> Languages = null)
        {
            this.Languages = Languages;
        }
        
        /// <summary>
        /// Gets or Sets Languages
        /// </summary>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<string> Languages { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvailableLanguageList {\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
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
            return this.Equals(obj as AvailableLanguageList);
        }

        /// <summary>
        /// Returns true if AvailableLanguageList instances are equal
        /// </summary>
        /// <param name="other">Instance of AvailableLanguageList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvailableLanguageList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Languages == other.Languages ||
                    this.Languages != null &&
                    this.Languages.SequenceEqual(other.Languages)
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
                if (this.Languages != null)
                    hash = hash * 59 + this.Languages.GetHashCode();
                return hash;
            }
        }
    }

}