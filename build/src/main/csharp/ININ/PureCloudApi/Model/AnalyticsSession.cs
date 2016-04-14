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
    public partial class AnalyticsSession :  IEquatable<AnalyticsSession>
    { 

        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum MediaTypeEnum {
            
            [EnumMember(Value = "voice")]
            Voice,
            
            [EnumMember(Value = "chat")]
            Chat,
            
            [EnumMember(Value = "email")]
            Email
        }


        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DirectionEnum {
            
            [EnumMember(Value = "inbound")]
            Inbound,
            
            [EnumMember(Value = "outbound")]
            Outbound
        }

        
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
    
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsSession" />class.
        /// </summary>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="SessionId">SessionId.</param>
        /// <param name="AddressOther">AddressOther.</param>
        /// <param name="AddressSelf">AddressSelf.</param>
        /// <param name="Ani">Ani.</param>
        /// <param name="Direction">Direction.</param>
        /// <param name="Dnis">Dnis.</param>
        /// <param name="OutboundCampaignId">OutboundCampaignId.</param>
        /// <param name="OutboundContactListId">OutboundContactListId.</param>
        /// <param name="DispositionAnalyzer">DispositionAnalyzer.</param>
        /// <param name="DispositionName">DispositionName.</param>
        /// <param name="EdgeId">EdgeId.</param>
        /// <param name="RemoteNameDisplayable">RemoteNameDisplayable.</param>
        /// <param name="RoomId">RoomId.</param>
        /// <param name="MonitoredSessionId">MonitoredSessionId.</param>
        /// <param name="MonitoredParticipantId">MonitoredParticipantId.</param>
        /// <param name="Segments">Segments.</param>

        public AnalyticsSession(MediaTypeEnum? MediaType = null, string SessionId = null, string AddressOther = null, string AddressSelf = null, string Ani = null, DirectionEnum? Direction = null, string Dnis = null, string OutboundCampaignId = null, string OutboundContactListId = null, string DispositionAnalyzer = null, string DispositionName = null, string EdgeId = null, string RemoteNameDisplayable = null, string RoomId = null, string MonitoredSessionId = null, string MonitoredParticipantId = null, List<AnalyticsConversationSegment> Segments = null)
        {
            this.MediaType = MediaType;
            this.SessionId = SessionId;
            this.AddressOther = AddressOther;
            this.AddressSelf = AddressSelf;
            this.Ani = Ani;
            this.Direction = Direction;
            this.Dnis = Dnis;
            this.OutboundCampaignId = OutboundCampaignId;
            this.OutboundContactListId = OutboundContactListId;
            this.DispositionAnalyzer = DispositionAnalyzer;
            this.DispositionName = DispositionName;
            this.EdgeId = EdgeId;
            this.RemoteNameDisplayable = RemoteNameDisplayable;
            this.RoomId = RoomId;
            this.MonitoredSessionId = MonitoredSessionId;
            this.MonitoredParticipantId = MonitoredParticipantId;
            this.Segments = Segments;
            
        }

    
        /// <summary>
        /// Gets or Sets SessionId
        /// </summary>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }
    
        /// <summary>
        /// Gets or Sets AddressOther
        /// </summary>
        [DataMember(Name="addressOther", EmitDefaultValue=false)]
        public string AddressOther { get; set; }
    
        /// <summary>
        /// Gets or Sets AddressSelf
        /// </summary>
        [DataMember(Name="addressSelf", EmitDefaultValue=false)]
        public string AddressSelf { get; set; }
    
        /// <summary>
        /// Gets or Sets Ani
        /// </summary>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }
    
        /// <summary>
        /// Gets or Sets Dnis
        /// </summary>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }
    
        /// <summary>
        /// Gets or Sets OutboundCampaignId
        /// </summary>
        [DataMember(Name="outboundCampaignId", EmitDefaultValue=false)]
        public string OutboundCampaignId { get; set; }
    
        /// <summary>
        /// Gets or Sets OutboundContactListId
        /// </summary>
        [DataMember(Name="outboundContactListId", EmitDefaultValue=false)]
        public string OutboundContactListId { get; set; }
    
        /// <summary>
        /// Gets or Sets DispositionAnalyzer
        /// </summary>
        [DataMember(Name="dispositionAnalyzer", EmitDefaultValue=false)]
        public string DispositionAnalyzer { get; set; }
    
        /// <summary>
        /// Gets or Sets DispositionName
        /// </summary>
        [DataMember(Name="dispositionName", EmitDefaultValue=false)]
        public string DispositionName { get; set; }
    
        /// <summary>
        /// Gets or Sets EdgeId
        /// </summary>
        [DataMember(Name="edgeId", EmitDefaultValue=false)]
        public string EdgeId { get; set; }
    
        /// <summary>
        /// Gets or Sets RemoteNameDisplayable
        /// </summary>
        [DataMember(Name="remoteNameDisplayable", EmitDefaultValue=false)]
        public string RemoteNameDisplayable { get; set; }
    
        /// <summary>
        /// Gets or Sets RoomId
        /// </summary>
        [DataMember(Name="roomId", EmitDefaultValue=false)]
        public string RoomId { get; set; }
    
        /// <summary>
        /// Gets or Sets MonitoredSessionId
        /// </summary>
        [DataMember(Name="monitoredSessionId", EmitDefaultValue=false)]
        public string MonitoredSessionId { get; set; }
    
        /// <summary>
        /// Gets or Sets MonitoredParticipantId
        /// </summary>
        [DataMember(Name="monitoredParticipantId", EmitDefaultValue=false)]
        public string MonitoredParticipantId { get; set; }
    
        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public List<AnalyticsConversationSegment> Segments { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsSession {\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  AddressOther: ").Append(AddressOther).Append("\n");
            sb.Append("  AddressSelf: ").Append(AddressSelf).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  OutboundCampaignId: ").Append(OutboundCampaignId).Append("\n");
            sb.Append("  OutboundContactListId: ").Append(OutboundContactListId).Append("\n");
            sb.Append("  DispositionAnalyzer: ").Append(DispositionAnalyzer).Append("\n");
            sb.Append("  DispositionName: ").Append(DispositionName).Append("\n");
            sb.Append("  EdgeId: ").Append(EdgeId).Append("\n");
            sb.Append("  RemoteNameDisplayable: ").Append(RemoteNameDisplayable).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  MonitoredSessionId: ").Append(MonitoredSessionId).Append("\n");
            sb.Append("  MonitoredParticipantId: ").Append(MonitoredParticipantId).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
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
            return this.Equals(obj as AnalyticsSession);
        }

        /// <summary>
        /// Returns true if AnalyticsSession instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsSession to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsSession other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
                ) &&
                (
                    this.AddressOther == other.AddressOther ||
                    this.AddressOther != null &&
                    this.AddressOther.Equals(other.AddressOther)
                ) &&
                (
                    this.AddressSelf == other.AddressSelf ||
                    this.AddressSelf != null &&
                    this.AddressSelf.Equals(other.AddressSelf)
                ) &&
                (
                    this.Ani == other.Ani ||
                    this.Ani != null &&
                    this.Ani.Equals(other.Ani)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.Dnis == other.Dnis ||
                    this.Dnis != null &&
                    this.Dnis.Equals(other.Dnis)
                ) &&
                (
                    this.OutboundCampaignId == other.OutboundCampaignId ||
                    this.OutboundCampaignId != null &&
                    this.OutboundCampaignId.Equals(other.OutboundCampaignId)
                ) &&
                (
                    this.OutboundContactListId == other.OutboundContactListId ||
                    this.OutboundContactListId != null &&
                    this.OutboundContactListId.Equals(other.OutboundContactListId)
                ) &&
                (
                    this.DispositionAnalyzer == other.DispositionAnalyzer ||
                    this.DispositionAnalyzer != null &&
                    this.DispositionAnalyzer.Equals(other.DispositionAnalyzer)
                ) &&
                (
                    this.DispositionName == other.DispositionName ||
                    this.DispositionName != null &&
                    this.DispositionName.Equals(other.DispositionName)
                ) &&
                (
                    this.EdgeId == other.EdgeId ||
                    this.EdgeId != null &&
                    this.EdgeId.Equals(other.EdgeId)
                ) &&
                (
                    this.RemoteNameDisplayable == other.RemoteNameDisplayable ||
                    this.RemoteNameDisplayable != null &&
                    this.RemoteNameDisplayable.Equals(other.RemoteNameDisplayable)
                ) &&
                (
                    this.RoomId == other.RoomId ||
                    this.RoomId != null &&
                    this.RoomId.Equals(other.RoomId)
                ) &&
                (
                    this.MonitoredSessionId == other.MonitoredSessionId ||
                    this.MonitoredSessionId != null &&
                    this.MonitoredSessionId.Equals(other.MonitoredSessionId)
                ) &&
                (
                    this.MonitoredParticipantId == other.MonitoredParticipantId ||
                    this.MonitoredParticipantId != null &&
                    this.MonitoredParticipantId.Equals(other.MonitoredParticipantId)
                ) &&
                (
                    this.Segments == other.Segments ||
                    this.Segments != null &&
                    this.Segments.SequenceEqual(other.Segments)
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
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();
                if (this.AddressOther != null)
                    hash = hash * 59 + this.AddressOther.GetHashCode();
                if (this.AddressSelf != null)
                    hash = hash * 59 + this.AddressSelf.GetHashCode();
                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();
                if (this.OutboundCampaignId != null)
                    hash = hash * 59 + this.OutboundCampaignId.GetHashCode();
                if (this.OutboundContactListId != null)
                    hash = hash * 59 + this.OutboundContactListId.GetHashCode();
                if (this.DispositionAnalyzer != null)
                    hash = hash * 59 + this.DispositionAnalyzer.GetHashCode();
                if (this.DispositionName != null)
                    hash = hash * 59 + this.DispositionName.GetHashCode();
                if (this.EdgeId != null)
                    hash = hash * 59 + this.EdgeId.GetHashCode();
                if (this.RemoteNameDisplayable != null)
                    hash = hash * 59 + this.RemoteNameDisplayable.GetHashCode();
                if (this.RoomId != null)
                    hash = hash * 59 + this.RoomId.GetHashCode();
                if (this.MonitoredSessionId != null)
                    hash = hash * 59 + this.MonitoredSessionId.GetHashCode();
                if (this.MonitoredParticipantId != null)
                    hash = hash * 59 + this.MonitoredParticipantId.GetHashCode();
                if (this.Segments != null)
                    hash = hash * 59 + this.Segments.GetHashCode();
                return hash;
            }
        }

    }
}
