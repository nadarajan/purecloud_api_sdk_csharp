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
    public class ChatSearchRequest :  IEquatable<ChatSearchRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSearchRequest" /> class.
        /// </summary>
        public ChatSearchRequest()
        {
            
        }

        
        /// <summary>
        /// Search terms can be AND'd together. Example: foo AND bar
        /// </summary>
        /// <value>Search terms can be AND'd together. Example: foo AND bar</value>
        [DataMember(Name="query", EmitDefaultValue=false)]
        public string Query { get; set; }
  
        
        /// <summary>
        /// Sort order of results by score or most recent. Default is by score
        /// </summary>
        /// <value>Sort order of results by score or most recent. Default is by score</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public string Order { get; set; }
  
        
        /// <summary>
        /// A list of XMPP JIDs to consider. Default is all permissible JIDs. A permissible JID is defined as any JID of a person with whom you have chatted, or any group in which you are currently a member.
        /// </summary>
        /// <value>A list of XMPP JIDs to consider. Default is all permissible JIDs. A permissible JID is defined as any JID of a person with whom you have chatted, or any group in which you are currently a member.</value>
        [DataMember(Name="targetJids", EmitDefaultValue=false)]
        public List<string> TargetJids { get; set; }
  
        
        /// <summary>
        /// The maximum number of hits to receive in the response. Default: 10, Maximum: 50]
        /// </summary>
        /// <value>The maximum number of hits to receive in the response. Default: 10, Maximum: 50]</value>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
  
        
        /// <summary>
        /// The number of hits to skip before returning results. Default: 0
        /// </summary>
        /// <value>The number of hits to skip before returning results. Default: 0</value>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
  
        
        /// <summary>
        /// Consider hits after this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Consider hits after this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="fromDate", EmitDefaultValue=false)]
        public DateTime? FromDate { get; set; }
  
        
        /// <summary>
        /// Consider hits before this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Consider hits before this date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="toDate", EmitDefaultValue=false)]
        public DateTime? ToDate { get; set; }
  
        
        /// <summary>
        /// Expand the 'to' or 'from' user details.
        /// </summary>
        /// <value>Expand the 'to' or 'from' user details.</value>
        [DataMember(Name="expand", EmitDefaultValue=false)]
        public string Expand { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatSearchRequest {\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  TargetJids: ").Append(TargetJids).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  ToDate: ").Append(ToDate).Append("\n");
            sb.Append("  Expand: ").Append(Expand).Append("\n");
            
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
            return this.Equals(obj as ChatSearchRequest);
        }

        /// <summary>
        /// Returns true if ChatSearchRequest instances are equal
        /// </summary>
        /// <param name="obj">Instance of ChatSearchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChatSearchRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Query == other.Query ||
                    this.Query != null &&
                    this.Query.Equals(other.Query)
                ) && 
                (
                    this.Order == other.Order ||
                    this.Order != null &&
                    this.Order.Equals(other.Order)
                ) && 
                (
                    this.TargetJids == other.TargetJids ||
                    this.TargetJids != null &&
                    this.TargetJids.SequenceEqual(other.TargetJids)
                ) && 
                (
                    this.PageSize == other.PageSize ||
                    this.PageSize != null &&
                    this.PageSize.Equals(other.PageSize)
                ) && 
                (
                    this.PageNumber == other.PageNumber ||
                    this.PageNumber != null &&
                    this.PageNumber.Equals(other.PageNumber)
                ) && 
                (
                    this.FromDate == other.FromDate ||
                    this.FromDate != null &&
                    this.FromDate.Equals(other.FromDate)
                ) && 
                (
                    this.ToDate == other.ToDate ||
                    this.ToDate != null &&
                    this.ToDate.Equals(other.ToDate)
                ) && 
                (
                    this.Expand == other.Expand ||
                    this.Expand != null &&
                    this.Expand.Equals(other.Expand)
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
                
                if (this.Query != null)
                    hash = hash * 57 + this.Query.GetHashCode();
                
                if (this.Order != null)
                    hash = hash * 57 + this.Order.GetHashCode();
                
                if (this.TargetJids != null)
                    hash = hash * 57 + this.TargetJids.GetHashCode();
                
                if (this.PageSize != null)
                    hash = hash * 57 + this.PageSize.GetHashCode();
                
                if (this.PageNumber != null)
                    hash = hash * 57 + this.PageNumber.GetHashCode();
                
                if (this.FromDate != null)
                    hash = hash * 57 + this.FromDate.GetHashCode();
                
                if (this.ToDate != null)
                    hash = hash * 57 + this.ToDate.GetHashCode();
                
                if (this.Expand != null)
                    hash = hash * 57 + this.Expand.GetHashCode();
                
                return hash;
            }
        }

    }


}
