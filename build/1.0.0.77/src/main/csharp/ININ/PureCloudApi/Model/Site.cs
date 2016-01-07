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
    public class Site :  IEquatable<Site>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Site" /> class.
        /// </summary>
        public Site()
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
        /// Gets or Sets DateCreated
        /// </summary>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DateModified
        /// </summary>
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
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
  
        
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
        /// Gets or Sets PrimarySites
        /// </summary>
        [DataMember(Name="primarySites", EmitDefaultValue=false)]
        public List<UriReference> PrimarySites { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SecondarySites
        /// </summary>
        [DataMember(Name="secondarySites", EmitDefaultValue=false)]
        public List<UriReference> SecondarySites { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PrimaryEdges
        /// </summary>
        [DataMember(Name="primaryEdges", EmitDefaultValue=false)]
        public List<Edge> PrimaryEdges { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SecondaryEdges
        /// </summary>
        [DataMember(Name="secondaryEdges", EmitDefaultValue=false)]
        public List<Edge> SecondaryEdges { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<OrganizationAddress> Addresses { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Edges
        /// </summary>
        [DataMember(Name="edges", EmitDefaultValue=false)]
        public List<Edge> Edges { get; set; }
  
        
        /// <summary>
        /// Recurrance rule, time zone, and start/end settings for automatic edge updates for this site
        /// </summary>
        /// <value>Recurrance rule, time zone, and start/end settings for automatic edge updates for this site</value>
        [DataMember(Name="edgeAutoUpdateConfig", EmitDefaultValue=false)]
        public EdgeAutoUpdateConfig EdgeAutoUpdateConfig { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public UriReference Location { get; set; }
  
        
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
            sb.Append("class Site {\n");
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
            sb.Append("  PrimarySites: ").Append(PrimarySites).Append("\n");
            sb.Append("  SecondarySites: ").Append(SecondarySites).Append("\n");
            sb.Append("  PrimaryEdges: ").Append(PrimaryEdges).Append("\n");
            sb.Append("  SecondaryEdges: ").Append(SecondaryEdges).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Edges: ").Append(Edges).Append("\n");
            sb.Append("  EdgeAutoUpdateConfig: ").Append(EdgeAutoUpdateConfig).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(obj as Site);
        }

        /// <summary>
        /// Returns true if Site instances are equal
        /// </summary>
        /// <param name="obj">Instance of Site to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Site other)
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
                    this.PrimarySites == other.PrimarySites ||
                    this.PrimarySites != null &&
                    this.PrimarySites.SequenceEqual(other.PrimarySites)
                ) && 
                (
                    this.SecondarySites == other.SecondarySites ||
                    this.SecondarySites != null &&
                    this.SecondarySites.SequenceEqual(other.SecondarySites)
                ) && 
                (
                    this.PrimaryEdges == other.PrimaryEdges ||
                    this.PrimaryEdges != null &&
                    this.PrimaryEdges.SequenceEqual(other.PrimaryEdges)
                ) && 
                (
                    this.SecondaryEdges == other.SecondaryEdges ||
                    this.SecondaryEdges != null &&
                    this.SecondaryEdges.SequenceEqual(other.SecondaryEdges)
                ) && 
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) && 
                (
                    this.Edges == other.Edges ||
                    this.Edges != null &&
                    this.Edges.SequenceEqual(other.Edges)
                ) && 
                (
                    this.EdgeAutoUpdateConfig == other.EdgeAutoUpdateConfig ||
                    this.EdgeAutoUpdateConfig != null &&
                    this.EdgeAutoUpdateConfig.Equals(other.EdgeAutoUpdateConfig)
                ) && 
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
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
                
                if (this.Description != null)
                    hash = hash * 57 + this.Description.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 57 + this.Version.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 57 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 57 + this.DateModified.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 57 + this.ModifiedBy.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 57 + this.CreatedBy.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 57 + this.State.GetHashCode();
                
                if (this.ModifiedByApp != null)
                    hash = hash * 57 + this.ModifiedByApp.GetHashCode();
                
                if (this.CreatedByApp != null)
                    hash = hash * 57 + this.CreatedByApp.GetHashCode();
                
                if (this.PrimarySites != null)
                    hash = hash * 57 + this.PrimarySites.GetHashCode();
                
                if (this.SecondarySites != null)
                    hash = hash * 57 + this.SecondarySites.GetHashCode();
                
                if (this.PrimaryEdges != null)
                    hash = hash * 57 + this.PrimaryEdges.GetHashCode();
                
                if (this.SecondaryEdges != null)
                    hash = hash * 57 + this.SecondaryEdges.GetHashCode();
                
                if (this.Addresses != null)
                    hash = hash * 57 + this.Addresses.GetHashCode();
                
                if (this.Edges != null)
                    hash = hash * 57 + this.Edges.GetHashCode();
                
                if (this.EdgeAutoUpdateConfig != null)
                    hash = hash * 57 + this.EdgeAutoUpdateConfig.GetHashCode();
                
                if (this.Location != null)
                    hash = hash * 57 + this.Location.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}