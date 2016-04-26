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
    public partial class UserStationResource :  IEquatable<UserStationResource>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="UserStationResource" />class.
        /// </summary>
        /// <param name="UserId">UserId.</param>
        /// <param name="StationId">StationId.</param>
        /// <param name="StationName">StationName.</param>
        /// <param name="LocationId">LocationId.</param>
        /// <param name="Provider">Provider.</param>
        /// <param name="AddressGroup">AddressGroup.</param>
        /// <param name="UserUri">UserUri.</param>
        /// <param name="StationUri">StationUri.</param>
        /// <param name="DefaultStation">DefaultStation (default to false).</param>

        public UserStationResource(string UserId = null, string StationId = null, string StationName = null, string LocationId = null, string Provider = null, string AddressGroup = null, string UserUri = null, string StationUri = null, bool? DefaultStation = null)
        {
            this.UserId = UserId;
            this.StationId = StationId;
            this.StationName = StationName;
            this.LocationId = LocationId;
            this.Provider = Provider;
            this.AddressGroup = AddressGroup;
            this.UserUri = UserUri;
            this.StationUri = StationUri;
            // use default value if no "DefaultStation" provided
            if (DefaultStation == null)
            {
                this.DefaultStation = false;
            }
            else
            {
                this.DefaultStation = DefaultStation;
            }
            
        }

    
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
    
        /// <summary>
        /// Gets or Sets StationId
        /// </summary>
        [DataMember(Name="stationId", EmitDefaultValue=false)]
        public string StationId { get; set; }
    
        /// <summary>
        /// Gets or Sets StationName
        /// </summary>
        [DataMember(Name="stationName", EmitDefaultValue=false)]
        public string StationName { get; set; }
    
        /// <summary>
        /// Gets or Sets LocationId
        /// </summary>
        [DataMember(Name="locationId", EmitDefaultValue=false)]
        public string LocationId { get; set; }
    
        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }
    
        /// <summary>
        /// Gets or Sets AddressGroup
        /// </summary>
        [DataMember(Name="addressGroup", EmitDefaultValue=false)]
        public string AddressGroup { get; set; }
    
        /// <summary>
        /// Gets or Sets UserUri
        /// </summary>
        [DataMember(Name="userUri", EmitDefaultValue=false)]
        public string UserUri { get; set; }
    
        /// <summary>
        /// Gets or Sets StationUri
        /// </summary>
        [DataMember(Name="stationUri", EmitDefaultValue=false)]
        public string StationUri { get; set; }
    
        /// <summary>
        /// Gets or Sets DefaultStation
        /// </summary>
        [DataMember(Name="defaultStation", EmitDefaultValue=false)]
        public bool? DefaultStation { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserStationResource {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  StationId: ").Append(StationId).Append("\n");
            sb.Append("  StationName: ").Append(StationName).Append("\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  AddressGroup: ").Append(AddressGroup).Append("\n");
            sb.Append("  UserUri: ").Append(UserUri).Append("\n");
            sb.Append("  StationUri: ").Append(StationUri).Append("\n");
            sb.Append("  DefaultStation: ").Append(DefaultStation).Append("\n");
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
            return this.Equals(obj as UserStationResource);
        }

        /// <summary>
        /// Returns true if UserStationResource instances are equal
        /// </summary>
        /// <param name="other">Instance of UserStationResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserStationResource other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.StationId == other.StationId ||
                    this.StationId != null &&
                    this.StationId.Equals(other.StationId)
                ) &&
                (
                    this.StationName == other.StationName ||
                    this.StationName != null &&
                    this.StationName.Equals(other.StationName)
                ) &&
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) &&
                (
                    this.Provider == other.Provider ||
                    this.Provider != null &&
                    this.Provider.Equals(other.Provider)
                ) &&
                (
                    this.AddressGroup == other.AddressGroup ||
                    this.AddressGroup != null &&
                    this.AddressGroup.Equals(other.AddressGroup)
                ) &&
                (
                    this.UserUri == other.UserUri ||
                    this.UserUri != null &&
                    this.UserUri.Equals(other.UserUri)
                ) &&
                (
                    this.StationUri == other.StationUri ||
                    this.StationUri != null &&
                    this.StationUri.Equals(other.StationUri)
                ) &&
                (
                    this.DefaultStation == other.DefaultStation ||
                    this.DefaultStation != null &&
                    this.DefaultStation.Equals(other.DefaultStation)
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
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.StationId != null)
                    hash = hash * 59 + this.StationId.GetHashCode();
                if (this.StationName != null)
                    hash = hash * 59 + this.StationName.GetHashCode();
                if (this.LocationId != null)
                    hash = hash * 59 + this.LocationId.GetHashCode();
                if (this.Provider != null)
                    hash = hash * 59 + this.Provider.GetHashCode();
                if (this.AddressGroup != null)
                    hash = hash * 59 + this.AddressGroup.GetHashCode();
                if (this.UserUri != null)
                    hash = hash * 59 + this.UserUri.GetHashCode();
                if (this.StationUri != null)
                    hash = hash * 59 + this.StationUri.GetHashCode();
                if (this.DefaultStation != null)
                    hash = hash * 59 + this.DefaultStation.GetHashCode();
                return hash;
            }
        }

    }
}