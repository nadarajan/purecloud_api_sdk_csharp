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
    public class QualityAudit :  IEquatable<QualityAudit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityAudit" /> class.
        /// </summary>
        public QualityAudit()
        {
            
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
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public string Timestamp { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public string Level { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name="entity", EmitDefaultValue=false)]
        public Entity Entity { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Changes
        /// </summary>
        [DataMember(Name="changes", EmitDefaultValue=false)]
        public List<Change> Changes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EntityType
        /// </summary>
        [DataMember(Name="entityType", EmitDefaultValue=false)]
        public string EntityType { get; set; }
  
        
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
            sb.Append("class QualityAudit {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Changes: ").Append(Changes).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
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
            return this.Equals(obj as QualityAudit);
        }

        /// <summary>
        /// Returns true if QualityAudit instances are equal
        /// </summary>
        /// <param name="obj">Instance of QualityAudit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QualityAudit other)
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
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                ) && 
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) && 
                (
                    this.Entity == other.Entity ||
                    this.Entity != null &&
                    this.Entity.Equals(other.Entity)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.Changes == other.Changes ||
                    this.Changes != null &&
                    this.Changes.SequenceEqual(other.Changes)
                ) && 
                (
                    this.EntityType == other.EntityType ||
                    this.EntityType != null &&
                    this.EntityType.Equals(other.EntityType)
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
                
                if (this.User != null)
                    hash = hash * 57 + this.User.GetHashCode();
                
                if (this.Timestamp != null)
                    hash = hash * 57 + this.Timestamp.GetHashCode();
                
                if (this.Level != null)
                    hash = hash * 57 + this.Level.GetHashCode();
                
                if (this.Entity != null)
                    hash = hash * 57 + this.Entity.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 57 + this.Action.GetHashCode();
                
                if (this.Changes != null)
                    hash = hash * 57 + this.Changes.GetHashCode();
                
                if (this.EntityType != null)
                    hash = hash * 57 + this.EntityType.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}