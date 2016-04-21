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
    /// 
    /// </summary>
    [DataContract]
    public partial class PromptAsset :  IEquatable<PromptAsset>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="PromptAsset" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="PromptId">PromptId.</param>
        /// <param name="Language">Language.</param>
        /// <param name="MediaUri">MediaUri.</param>
        /// <param name="TtsString">TtsString.</param>
        /// <param name="UploadStatus">UploadStatus.</param>
        /// <param name="UploadUri">UploadUri.</param>
        /// <param name="DurationSeconds">DurationSeconds.</param>

        public PromptAsset(string Name = null, string PromptId = null, string Language = null, string MediaUri = null, string TtsString = null, string UploadStatus = null, string UploadUri = null, double? DurationSeconds = null)
        {
            this.Name = Name;
            this.PromptId = PromptId;
            this.Language = Language;
            this.MediaUri = MediaUri;
            this.TtsString = TtsString;
            this.UploadStatus = UploadStatus;
            this.UploadUri = UploadUri;
            this.DurationSeconds = DurationSeconds;
            
        }

    
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets PromptId
        /// </summary>
        [DataMember(Name="promptId", EmitDefaultValue=false)]
        public string PromptId { get; set; }
    
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
    
        /// <summary>
        /// Gets or Sets MediaUri
        /// </summary>
        [DataMember(Name="mediaUri", EmitDefaultValue=false)]
        public string MediaUri { get; set; }
    
        /// <summary>
        /// Gets or Sets TtsString
        /// </summary>
        [DataMember(Name="ttsString", EmitDefaultValue=false)]
        public string TtsString { get; set; }
    
        /// <summary>
        /// Gets or Sets UploadStatus
        /// </summary>
        [DataMember(Name="uploadStatus", EmitDefaultValue=false)]
        public string UploadStatus { get; set; }
    
        /// <summary>
        /// Gets or Sets UploadUri
        /// </summary>
        [DataMember(Name="uploadUri", EmitDefaultValue=false)]
        public string UploadUri { get; set; }
    
        /// <summary>
        /// Gets or Sets DurationSeconds
        /// </summary>
        [DataMember(Name="durationSeconds", EmitDefaultValue=false)]
        public double? DurationSeconds { get; set; }
    
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PromptAsset {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PromptId: ").Append(PromptId).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  MediaUri: ").Append(MediaUri).Append("\n");
            sb.Append("  TtsString: ").Append(TtsString).Append("\n");
            sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
            sb.Append("  UploadUri: ").Append(UploadUri).Append("\n");
            sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as PromptAsset);
        }

        /// <summary>
        /// Returns true if PromptAsset instances are equal
        /// </summary>
        /// <param name="other">Instance of PromptAsset to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromptAsset other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.PromptId == other.PromptId ||
                    this.PromptId != null &&
                    this.PromptId.Equals(other.PromptId)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.MediaUri == other.MediaUri ||
                    this.MediaUri != null &&
                    this.MediaUri.Equals(other.MediaUri)
                ) &&
                (
                    this.TtsString == other.TtsString ||
                    this.TtsString != null &&
                    this.TtsString.Equals(other.TtsString)
                ) &&
                (
                    this.UploadStatus == other.UploadStatus ||
                    this.UploadStatus != null &&
                    this.UploadStatus.Equals(other.UploadStatus)
                ) &&
                (
                    this.UploadUri == other.UploadUri ||
                    this.UploadUri != null &&
                    this.UploadUri.Equals(other.UploadUri)
                ) &&
                (
                    this.DurationSeconds == other.DurationSeconds ||
                    this.DurationSeconds != null &&
                    this.DurationSeconds.Equals(other.DurationSeconds)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PromptId != null)
                    hash = hash * 59 + this.PromptId.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.MediaUri != null)
                    hash = hash * 59 + this.MediaUri.GetHashCode();
                if (this.TtsString != null)
                    hash = hash * 59 + this.TtsString.GetHashCode();
                if (this.UploadStatus != null)
                    hash = hash * 59 + this.UploadStatus.GetHashCode();
                if (this.UploadUri != null)
                    hash = hash * 59 + this.UploadUri.GetHashCode();
                if (this.DurationSeconds != null)
                    hash = hash * 59 + this.DurationSeconds.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
