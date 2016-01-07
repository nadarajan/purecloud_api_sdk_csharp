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
    public class Contact :  IEquatable<Contact>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        public Contact()
        {
            this.Callable = false;
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ContactListId
        /// </summary>
        [DataMember(Name="contactListId", EmitDefaultValue=false)]
        public string ContactListId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public JsonNode Data { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CallRecords
        /// </summary>
        [DataMember(Name="callRecords", EmitDefaultValue=false)]
        public Dictionary<string, CallRecord> CallRecords { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Callable
        /// </summary>
        [DataMember(Name="callable", EmitDefaultValue=false)]
        public bool? Callable { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PhoneNumberStatus
        /// </summary>
        [DataMember(Name="phoneNumberStatus", EmitDefaultValue=false)]
        public Dictionary<string, PhoneNumberStatus> PhoneNumberStatus { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactListId: ").Append(ContactListId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  CallRecords: ").Append(CallRecords).Append("\n");
            sb.Append("  Callable: ").Append(Callable).Append("\n");
            sb.Append("  PhoneNumberStatus: ").Append(PhoneNumberStatus).Append("\n");
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
            return this.Equals(obj as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="obj">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.ContactListId == other.ContactListId ||
                    this.ContactListId != null &&
                    this.ContactListId.Equals(other.ContactListId)
                ) && 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
                ) && 
                (
                    this.CallRecords == other.CallRecords ||
                    this.CallRecords != null &&
                    this.CallRecords.SequenceEqual(other.CallRecords)
                ) && 
                (
                    this.Callable == other.Callable ||
                    this.Callable != null &&
                    this.Callable.Equals(other.Callable)
                ) && 
                (
                    this.PhoneNumberStatus == other.PhoneNumberStatus ||
                    this.PhoneNumberStatus != null &&
                    this.PhoneNumberStatus.SequenceEqual(other.PhoneNumberStatus)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.ContactListId != null)
                    hash = hash * 57 + this.ContactListId.GetHashCode();
                
                if (this.Data != null)
                    hash = hash * 57 + this.Data.GetHashCode();
                
                if (this.CallRecords != null)
                    hash = hash * 57 + this.CallRecords.GetHashCode();
                
                if (this.Callable != null)
                    hash = hash * 57 + this.Callable.GetHashCode();
                
                if (this.PhoneNumberStatus != null)
                    hash = hash * 57 + this.PhoneNumberStatus.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}