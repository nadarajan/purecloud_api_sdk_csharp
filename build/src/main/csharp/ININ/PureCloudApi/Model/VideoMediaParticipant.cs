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
    public partial class VideoMediaParticipant :  IEquatable<VideoMediaParticipant>
    { 

        /// <summary>
        /// The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting
        /// </summary>
        /// <value>The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum {
            
            [EnumMember(Value = "ALERTING")]
            Alerting,
            
            [EnumMember(Value = "DIALING")]
            Dialing,
            
            [EnumMember(Value = "CONTACTING")]
            Contacting,
            
            [EnumMember(Value = "OFFERING")]
            Offering,
            
            [EnumMember(Value = "CONNECTED")]
            Connected,
            
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected,
            
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            
            [EnumMember(Value = "CONVERTING")]
            Converting,
            
            [EnumMember(Value = "UPLOADING")]
            Uploading,
            
            [EnumMember(Value = "TRANSMITTING")]
            Transmitting,
            
            [EnumMember(Value = "NONE")]
            None
        }


        /// <summary>
        /// The participant's direction.  Values can be: 'inbound' or 'outbound'
        /// </summary>
        /// <value>The participant's direction.  Values can be: 'inbound' or 'outbound'</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DirectionEnum {
            
            [EnumMember(Value = "INBOUND")]
            Inbound,
            
            [EnumMember(Value = "OUTBOUND")]
            Outbound
        }


        /// <summary>
        /// The reason the participant was disconnected from the conversation.
        /// </summary>
        /// <value>The reason the participant was disconnected from the conversation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DisconnectTypeEnum {
            
            [EnumMember(Value = "ENDPOINT")]
            Endpoint,
            
            [EnumMember(Value = "CLIENT")]
            Client,
            
            [EnumMember(Value = "SYSTEM")]
            System,
            
            [EnumMember(Value = "TRANSFER")]
            Transfer,
            
            [EnumMember(Value = "TRANSFER_CONFERENCE")]
            TransferConference,
            
            [EnumMember(Value = "TRANSFER_CONSULT")]
            TransferConsult,
            
            [EnumMember(Value = "ERROR")]
            Error,
            
            [EnumMember(Value = "PEER")]
            Peer,
            
            [EnumMember(Value = "OTHER")]
            Other
        }

        
        /// <summary>
        /// The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting
        /// </summary>
        /// <value>The participant's state.  Values can be: 'alerting', 'connected', 'disconnected', 'dialing', 'contacting</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
    
        /// <summary>
        /// The participant's direction.  Values can be: 'inbound' or 'outbound'
        /// </summary>
        /// <value>The participant's direction.  Values can be: 'inbound' or 'outbound'</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
    
        /// <summary>
        /// The reason the participant was disconnected from the conversation.
        /// </summary>
        /// <value>The reason the participant was disconnected from the conversation.</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMediaParticipant" />class.
        /// </summary>
        /// <param name="Id">The unique participant ID..</param>
        /// <param name="Name">The display friendly name of the participant..</param>
        /// <param name="Address">The participant address..</param>
        /// <param name="StartTime">The time when this participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ConnectedTime">The time when this participant went connected on the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="EndTime">The time when this participant when disconnected on the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="StartHoldTime">The time when this participant&#39;s hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Purpose">The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr.</param>
        /// <param name="State">The participant&#39;s state.  Values can be: &#39;alerting&#39;, &#39;connected&#39;, &#39;disconnected&#39;, &#39;dialing&#39;, &#39;contacting.</param>
        /// <param name="Direction">The participant&#39;s direction.  Values can be: &#39;inbound&#39; or &#39;outbound&#39;.</param>
        /// <param name="DisconnectType">The reason the participant was disconnected from the conversation..</param>
        /// <param name="Held">Value is true when the participant is on hold. (default to false).</param>
        /// <param name="WrapupRequired">Value is true when the participant requires wrap-up. (default to false).</param>
        /// <param name="WrapupPrompt">The wrap-up prompt indicating the type of wrap-up to be performed..</param>
        /// <param name="User">The PureCloud user for this participant..</param>
        /// <param name="Queue">The PureCloud queue for this participant..</param>
        /// <param name="Attributes">A list of ad-hoc attributes for the participant..</param>
        /// <param name="ErrorInfo">If the conversation ends in error, contains additional error details..</param>
        /// <param name="Script">The Engage script that should be used by this participant..</param>
        /// <param name="WrapupTimeoutMs">The amount of time the participant has to complete wrap-up..</param>
        /// <param name="WrapupSkipped">Value is true when the participant has skipped wrap-up. (default to false).</param>
        /// <param name="AudioMuted">Value is true when audio is muted. (default to false).</param>
        /// <param name="VideoMuted">Value is true when video is muted. (default to false).</param>
        /// <param name="SharingScreen">Value is true when screen sharing is enabled. (default to false).</param>
        /// <param name="PeerCount">The number of peers of this participant..</param>
        /// <param name="Context">The context for this participant..</param>

        public VideoMediaParticipant(string Id = null, string Name = null, string Address = null, DateTime? StartTime = null, DateTime? ConnectedTime = null, DateTime? EndTime = null, DateTime? StartHoldTime = null, string Purpose = null, StateEnum? State = null, DirectionEnum? Direction = null, DisconnectTypeEnum? DisconnectType = null, bool? Held = null, bool? WrapupRequired = null, string WrapupPrompt = null, UriReference User = null, UriReference Queue = null, Dictionary<string, string> Attributes = null, ErrorBody ErrorInfo = null, UriReference Script = null, int? WrapupTimeoutMs = null, bool? WrapupSkipped = null, bool? AudioMuted = null, bool? VideoMuted = null, bool? SharingScreen = null, int? PeerCount = null, string Context = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.StartTime = StartTime;
            this.ConnectedTime = ConnectedTime;
            this.EndTime = EndTime;
            this.StartHoldTime = StartHoldTime;
            this.Purpose = Purpose;
            this.State = State;
            this.Direction = Direction;
            this.DisconnectType = DisconnectType;
            // use default value if no "Held" provided
            if (Held == null)
            {
                this.Held = false;
            }
            else
            {
                this.Held = Held;
            }
            // use default value if no "WrapupRequired" provided
            if (WrapupRequired == null)
            {
                this.WrapupRequired = false;
            }
            else
            {
                this.WrapupRequired = WrapupRequired;
            }
            this.WrapupPrompt = WrapupPrompt;
            this.User = User;
            this.Queue = Queue;
            this.Attributes = Attributes;
            this.ErrorInfo = ErrorInfo;
            this.Script = Script;
            this.WrapupTimeoutMs = WrapupTimeoutMs;
            // use default value if no "WrapupSkipped" provided
            if (WrapupSkipped == null)
            {
                this.WrapupSkipped = false;
            }
            else
            {
                this.WrapupSkipped = WrapupSkipped;
            }
            // use default value if no "AudioMuted" provided
            if (AudioMuted == null)
            {
                this.AudioMuted = false;
            }
            else
            {
                this.AudioMuted = AudioMuted;
            }
            // use default value if no "VideoMuted" provided
            if (VideoMuted == null)
            {
                this.VideoMuted = false;
            }
            else
            {
                this.VideoMuted = VideoMuted;
            }
            // use default value if no "SharingScreen" provided
            if (SharingScreen == null)
            {
                this.SharingScreen = false;
            }
            else
            {
                this.SharingScreen = SharingScreen;
            }
            this.PeerCount = PeerCount;
            this.Context = Context;
            
        }

    
        /// <summary>
        /// The unique participant ID.
        /// </summary>
        /// <value>The unique participant ID.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// The display friendly name of the participant.
        /// </summary>
        /// <value>The display friendly name of the participant.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// The participant address.
        /// </summary>
        /// <value>The participant address.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
    
        /// <summary>
        /// The time when this participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when this participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
    
        /// <summary>
        /// The time when this participant went connected on the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when this participant went connected on the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }
    
        /// <summary>
        /// The time when this participant when disconnected on the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when this participant when disconnected on the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }
    
        /// <summary>
        /// The time when this participant&#39;s hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when this participant&#39;s hold started. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }
    
        /// <summary>
        /// The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr
        /// </summary>
        /// <value>The participant&#39;s purpose.  Values can be: &#39;agent&#39;, &#39;user&#39;, &#39;customer&#39;, &#39;external&#39;, &#39;acd&#39;, &#39;ivr</value>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }
    
        /// <summary>
        /// Value is true when the participant is on hold.
        /// </summary>
        /// <value>Value is true when the participant is on hold.</value>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }
    
        /// <summary>
        /// Value is true when the participant requires wrap-up.
        /// </summary>
        /// <value>Value is true when the participant requires wrap-up.</value>
        [DataMember(Name="wrapupRequired", EmitDefaultValue=false)]
        public bool? WrapupRequired { get; set; }
    
        /// <summary>
        /// The wrap-up prompt indicating the type of wrap-up to be performed.
        /// </summary>
        /// <value>The wrap-up prompt indicating the type of wrap-up to be performed.</value>
        [DataMember(Name="wrapupPrompt", EmitDefaultValue=false)]
        public string WrapupPrompt { get; set; }
    
        /// <summary>
        /// The PureCloud user for this participant.
        /// </summary>
        /// <value>The PureCloud user for this participant.</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public UriReference User { get; set; }
    
        /// <summary>
        /// The PureCloud queue for this participant.
        /// </summary>
        /// <value>The PureCloud queue for this participant.</value>
        [DataMember(Name="queue", EmitDefaultValue=false)]
        public UriReference Queue { get; set; }
    
        /// <summary>
        /// A list of ad-hoc attributes for the participant.
        /// </summary>
        /// <value>A list of ad-hoc attributes for the participant.</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }
    
        /// <summary>
        /// If the conversation ends in error, contains additional error details.
        /// </summary>
        /// <value>If the conversation ends in error, contains additional error details.</value>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public ErrorBody ErrorInfo { get; set; }
    
        /// <summary>
        /// The Engage script that should be used by this participant.
        /// </summary>
        /// <value>The Engage script that should be used by this participant.</value>
        [DataMember(Name="script", EmitDefaultValue=false)]
        public UriReference Script { get; set; }
    
        /// <summary>
        /// The amount of time the participant has to complete wrap-up.
        /// </summary>
        /// <value>The amount of time the participant has to complete wrap-up.</value>
        [DataMember(Name="wrapupTimeoutMs", EmitDefaultValue=false)]
        public int? WrapupTimeoutMs { get; set; }
    
        /// <summary>
        /// Value is true when the participant has skipped wrap-up.
        /// </summary>
        /// <value>Value is true when the participant has skipped wrap-up.</value>
        [DataMember(Name="wrapupSkipped", EmitDefaultValue=false)]
        public bool? WrapupSkipped { get; set; }
    
        /// <summary>
        /// Value is true when audio is muted.
        /// </summary>
        /// <value>Value is true when audio is muted.</value>
        [DataMember(Name="audioMuted", EmitDefaultValue=false)]
        public bool? AudioMuted { get; set; }
    
        /// <summary>
        /// Value is true when video is muted.
        /// </summary>
        /// <value>Value is true when video is muted.</value>
        [DataMember(Name="videoMuted", EmitDefaultValue=false)]
        public bool? VideoMuted { get; set; }
    
        /// <summary>
        /// Value is true when screen sharing is enabled.
        /// </summary>
        /// <value>Value is true when screen sharing is enabled.</value>
        [DataMember(Name="sharingScreen", EmitDefaultValue=false)]
        public bool? SharingScreen { get; set; }
    
        /// <summary>
        /// The number of peers of this participant.
        /// </summary>
        /// <value>The number of peers of this participant.</value>
        [DataMember(Name="peerCount", EmitDefaultValue=false)]
        public int? PeerCount { get; set; }
    
        /// <summary>
        /// The context for this participant.
        /// </summary>
        /// <value>The context for this participant.</value>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoMediaParticipant {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  Held: ").Append(Held).Append("\n");
            sb.Append("  WrapupRequired: ").Append(WrapupRequired).Append("\n");
            sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Queue: ").Append(Queue).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  WrapupTimeoutMs: ").Append(WrapupTimeoutMs).Append("\n");
            sb.Append("  WrapupSkipped: ").Append(WrapupSkipped).Append("\n");
            sb.Append("  AudioMuted: ").Append(AudioMuted).Append("\n");
            sb.Append("  VideoMuted: ").Append(VideoMuted).Append("\n");
            sb.Append("  SharingScreen: ").Append(SharingScreen).Append("\n");
            sb.Append("  PeerCount: ").Append(PeerCount).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
            return this.Equals(obj as VideoMediaParticipant);
        }

        /// <summary>
        /// Returns true if VideoMediaParticipant instances are equal
        /// </summary>
        /// <param name="other">Instance of VideoMediaParticipant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VideoMediaParticipant other)
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
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.StartHoldTime == other.StartHoldTime ||
                    this.StartHoldTime != null &&
                    this.StartHoldTime.Equals(other.StartHoldTime)
                ) &&
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.Held == other.Held ||
                    this.Held != null &&
                    this.Held.Equals(other.Held)
                ) &&
                (
                    this.WrapupRequired == other.WrapupRequired ||
                    this.WrapupRequired != null &&
                    this.WrapupRequired.Equals(other.WrapupRequired)
                ) &&
                (
                    this.WrapupPrompt == other.WrapupPrompt ||
                    this.WrapupPrompt != null &&
                    this.WrapupPrompt.Equals(other.WrapupPrompt)
                ) &&
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) &&
                (
                    this.Queue == other.Queue ||
                    this.Queue != null &&
                    this.Queue.Equals(other.Queue)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
                ) &&
                (
                    this.Script == other.Script ||
                    this.Script != null &&
                    this.Script.Equals(other.Script)
                ) &&
                (
                    this.WrapupTimeoutMs == other.WrapupTimeoutMs ||
                    this.WrapupTimeoutMs != null &&
                    this.WrapupTimeoutMs.Equals(other.WrapupTimeoutMs)
                ) &&
                (
                    this.WrapupSkipped == other.WrapupSkipped ||
                    this.WrapupSkipped != null &&
                    this.WrapupSkipped.Equals(other.WrapupSkipped)
                ) &&
                (
                    this.AudioMuted == other.AudioMuted ||
                    this.AudioMuted != null &&
                    this.AudioMuted.Equals(other.AudioMuted)
                ) &&
                (
                    this.VideoMuted == other.VideoMuted ||
                    this.VideoMuted != null &&
                    this.VideoMuted.Equals(other.VideoMuted)
                ) &&
                (
                    this.SharingScreen == other.SharingScreen ||
                    this.SharingScreen != null &&
                    this.SharingScreen.Equals(other.SharingScreen)
                ) &&
                (
                    this.PeerCount == other.PeerCount ||
                    this.PeerCount != null &&
                    this.PeerCount.Equals(other.PeerCount)
                ) &&
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
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
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                if (this.StartHoldTime != null)
                    hash = hash * 59 + this.StartHoldTime.GetHashCode();
                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();
                if (this.Held != null)
                    hash = hash * 59 + this.Held.GetHashCode();
                if (this.WrapupRequired != null)
                    hash = hash * 59 + this.WrapupRequired.GetHashCode();
                if (this.WrapupPrompt != null)
                    hash = hash * 59 + this.WrapupPrompt.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Queue != null)
                    hash = hash * 59 + this.Queue.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();
                if (this.Script != null)
                    hash = hash * 59 + this.Script.GetHashCode();
                if (this.WrapupTimeoutMs != null)
                    hash = hash * 59 + this.WrapupTimeoutMs.GetHashCode();
                if (this.WrapupSkipped != null)
                    hash = hash * 59 + this.WrapupSkipped.GetHashCode();
                if (this.AudioMuted != null)
                    hash = hash * 59 + this.AudioMuted.GetHashCode();
                if (this.VideoMuted != null)
                    hash = hash * 59 + this.VideoMuted.GetHashCode();
                if (this.SharingScreen != null)
                    hash = hash * 59 + this.SharingScreen.GetHashCode();
                if (this.PeerCount != null)
                    hash = hash * 59 + this.PeerCount.GetHashCode();
                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
                return hash;
            }
        }

    }
}
