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
    /// EdgeGroup
    /// </summary>
    [DataContract]
    public partial class EdgeGroup :  IEquatable<EdgeGroup>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted
        }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeGroup" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EdgeGroup() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EdgeGroup" /> class.
        /// </summary>
        /// <param name="Name">The name of the entity. (required).</param>
        /// <param name="Description">Description.</param>
        /// <param name="Version">Version.</param>
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ModifiedBy">ModifiedBy.</param>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="State">State.</param>
        /// <param name="ModifiedByApp">ModifiedByApp.</param>
        /// <param name="CreatedByApp">CreatedByApp.</param>
        /// <param name="Managed">Is this edge group being managed remotely. (default to false).</param>
        /// <param name="EdgeTrunkBaseAssignment">A trunk base settings assignment of trunkType \&quot;EDGE\&quot; to use for edge-to-edge communication. (required).</param>
        /// <param name="PhoneTrunkBaseAssignments">Trunk base settings assignments of trunkType \&quot;PHONE\&quot; to inherit to edge logical interfaces for phone communication..</param>
        /// <param name="PhoneTrunkBases">Trunk base settings of trunkType \&quot;PHONE\&quot; to inherit to edge logical interface for phone communication..</param>
        public EdgeGroup(string Name = null, string Description = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, StateEnum? State = null, string ModifiedByApp = null, string CreatedByApp = null, bool? Managed = null, TrunkBaseAssignment EdgeTrunkBaseAssignment = null, List<TrunkBaseAssignment> PhoneTrunkBaseAssignments = null, List<UriReference> PhoneTrunkBases = null)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for EdgeGroup and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "EdgeTrunkBaseAssignment" is required (not null)
            if (EdgeTrunkBaseAssignment == null)
            {
                throw new InvalidDataException("EdgeTrunkBaseAssignment is a required property for EdgeGroup and cannot be null");
            }
            else
            {
                this.EdgeTrunkBaseAssignment = EdgeTrunkBaseAssignment;
            }
            this.Description = Description;
            this.Version = Version;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.CreatedBy = CreatedBy;
            this.State = State;
            this.ModifiedByApp = ModifiedByApp;
            this.CreatedByApp = CreatedByApp;
            // use default value if no "Managed" provided
            if (Managed == null)
            {
                this.Managed = false;
            }
            else
            {
                this.Managed = Managed;
            }
            this.PhoneTrunkBaseAssignments = PhoneTrunkBaseAssignments;
            this.PhoneTrunkBases = PhoneTrunkBases;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// The name of the entity.
        /// </summary>
        /// <value>The name of the entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        /// <summary>
        /// Gets or Sets ModifiedBy
        /// </summary>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets ModifiedByApp
        /// </summary>
        [DataMember(Name="modifiedByApp", EmitDefaultValue=false)]
        public string ModifiedByApp { get; set; }
        /// <summary>
        /// Gets or Sets CreatedByApp
        /// </summary>
        [DataMember(Name="createdByApp", EmitDefaultValue=false)]
        public string CreatedByApp { get; set; }
        /// <summary>
        /// Is this edge group being managed remotely.
        /// </summary>
        /// <value>Is this edge group being managed remotely.</value>
        [DataMember(Name="managed", EmitDefaultValue=false)]
        public bool? Managed { get; set; }
        /// <summary>
        /// A trunk base settings assignment of trunkType \&quot;EDGE\&quot; to use for edge-to-edge communication.
        /// </summary>
        /// <value>A trunk base settings assignment of trunkType \&quot;EDGE\&quot; to use for edge-to-edge communication.</value>
        [DataMember(Name="edgeTrunkBaseAssignment", EmitDefaultValue=false)]
        public TrunkBaseAssignment EdgeTrunkBaseAssignment { get; set; }
        /// <summary>
        /// Trunk base settings assignments of trunkType \&quot;PHONE\&quot; to inherit to edge logical interfaces for phone communication.
        /// </summary>
        /// <value>Trunk base settings assignments of trunkType \&quot;PHONE\&quot; to inherit to edge logical interfaces for phone communication.</value>
        [DataMember(Name="phoneTrunkBaseAssignments", EmitDefaultValue=false)]
        public List<TrunkBaseAssignment> PhoneTrunkBaseAssignments { get; set; }
        /// <summary>
        /// Trunk base settings of trunkType \&quot;PHONE\&quot; to inherit to edge logical interface for phone communication.
        /// </summary>
        /// <value>Trunk base settings of trunkType \&quot;PHONE\&quot; to inherit to edge logical interface for phone communication.</value>
        [DataMember(Name="phoneTrunkBases", EmitDefaultValue=false)]
        public List<UriReference> PhoneTrunkBases { get; set; }
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
            sb.Append("class EdgeGroup {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ModifiedByApp: ").Append(ModifiedByApp).Append("\n");
            sb.Append("  CreatedByApp: ").Append(CreatedByApp).Append("\n");
            sb.Append("  Managed: ").Append(Managed).Append("\n");
            sb.Append("  EdgeTrunkBaseAssignment: ").Append(EdgeTrunkBaseAssignment).Append("\n");
            sb.Append("  PhoneTrunkBaseAssignments: ").Append(PhoneTrunkBaseAssignments).Append("\n");
            sb.Append("  PhoneTrunkBases: ").Append(PhoneTrunkBases).Append("\n");
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
            return this.Equals(obj as EdgeGroup);
        }

        /// <summary>
        /// Returns true if EdgeGroup instances are equal
        /// </summary>
        /// <param name="other">Instance of EdgeGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EdgeGroup other)
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
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ModifiedByApp == other.ModifiedByApp ||
                    this.ModifiedByApp != null &&
                    this.ModifiedByApp.Equals(other.ModifiedByApp)
                ) &&
                (
                    this.CreatedByApp == other.CreatedByApp ||
                    this.CreatedByApp != null &&
                    this.CreatedByApp.Equals(other.CreatedByApp)
                ) &&
                (
                    this.Managed == other.Managed ||
                    this.Managed != null &&
                    this.Managed.Equals(other.Managed)
                ) &&
                (
                    this.EdgeTrunkBaseAssignment == other.EdgeTrunkBaseAssignment ||
                    this.EdgeTrunkBaseAssignment != null &&
                    this.EdgeTrunkBaseAssignment.Equals(other.EdgeTrunkBaseAssignment)
                ) &&
                (
                    this.PhoneTrunkBaseAssignments == other.PhoneTrunkBaseAssignments ||
                    this.PhoneTrunkBaseAssignments != null &&
                    this.PhoneTrunkBaseAssignments.SequenceEqual(other.PhoneTrunkBaseAssignments)
                ) &&
                (
                    this.PhoneTrunkBases == other.PhoneTrunkBases ||
                    this.PhoneTrunkBases != null &&
                    this.PhoneTrunkBases.SequenceEqual(other.PhoneTrunkBases)
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
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.ModifiedByApp != null)
                    hash = hash * 59 + this.ModifiedByApp.GetHashCode();
                if (this.CreatedByApp != null)
                    hash = hash * 59 + this.CreatedByApp.GetHashCode();
                if (this.Managed != null)
                    hash = hash * 59 + this.Managed.GetHashCode();
                if (this.EdgeTrunkBaseAssignment != null)
                    hash = hash * 59 + this.EdgeTrunkBaseAssignment.GetHashCode();
                if (this.PhoneTrunkBaseAssignments != null)
                    hash = hash * 59 + this.PhoneTrunkBaseAssignments.GetHashCode();
                if (this.PhoneTrunkBases != null)
                    hash = hash * 59 + this.PhoneTrunkBases.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
