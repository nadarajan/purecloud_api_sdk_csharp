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
    public class ConversationQueryResponse :  IEquatable<ConversationQueryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationQueryResponse" /> class.
        /// </summary>
        public ConversationQueryResponse()
        {
            this.HasMorePrev = false;
            this.HasMoreNext = false;
            
        }

        
        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name="pageSize", EmitDefaultValue=false)]
        public int? PageSize { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name="pageNumber", EmitDefaultValue=false)]
        public int? PageNumber { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public long? Total { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Entities
        /// </summary>
        [DataMember(Name="entities", EmitDefaultValue=false)]
        public List<Conversation> Entities { get; set; }
  
        
        /// <summary>
        /// Gets or Sets HasMorePrev
        /// </summary>
        [DataMember(Name="hasMorePrev", EmitDefaultValue=false)]
        public bool? HasMorePrev { get; set; }
  
        
        /// <summary>
        /// Gets or Sets HasMoreNext
        /// </summary>
        [DataMember(Name="hasMoreNext", EmitDefaultValue=false)]
        public bool? HasMoreNext { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startQueryTime", EmitDefaultValue=false)]
        public DateTime? StartQueryTime { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endQueryTime", EmitDefaultValue=false)]
        public DateTime? EndQueryTime { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="newestResultTime", EmitDefaultValue=false)]
        public DateTime? NewestResultTime { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="oldestResultTime", EmitDefaultValue=false)]
        public DateTime? OldestResultTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TimeMs
        /// </summary>
        [DataMember(Name="timeMs", EmitDefaultValue=false)]
        public long? TimeMs { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Iterations
        /// </summary>
        [DataMember(Name="iterations", EmitDefaultValue=false)]
        public int? Iterations { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="anchor", EmitDefaultValue=false)]
        public DateTime? Anchor { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name="sort", EmitDefaultValue=false)]
        public string Sort { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Facets
        /// </summary>
        [DataMember(Name="facets", EmitDefaultValue=false)]
        public Facets Facets { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SelfUri
        /// </summary>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PreviousUri
        /// </summary>
        [DataMember(Name="previousUri", EmitDefaultValue=false)]
        public string PreviousUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FirstUri
        /// </summary>
        [DataMember(Name="firstUri", EmitDefaultValue=false)]
        public string FirstUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets NextUri
        /// </summary>
        [DataMember(Name="nextUri", EmitDefaultValue=false)]
        public string NextUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LastUri
        /// </summary>
        [DataMember(Name="lastUri", EmitDefaultValue=false)]
        public string LastUri { get; set; }
  
        
        /// <summary>
        /// Gets or Sets PageCount
        /// </summary>
        [DataMember(Name="pageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationQueryResponse {\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Entities: ").Append(Entities).Append("\n");
            sb.Append("  HasMorePrev: ").Append(HasMorePrev).Append("\n");
            sb.Append("  HasMoreNext: ").Append(HasMoreNext).Append("\n");
            sb.Append("  StartQueryTime: ").Append(StartQueryTime).Append("\n");
            sb.Append("  EndQueryTime: ").Append(EndQueryTime).Append("\n");
            sb.Append("  NewestResultTime: ").Append(NewestResultTime).Append("\n");
            sb.Append("  OldestResultTime: ").Append(OldestResultTime).Append("\n");
            sb.Append("  TimeMs: ").Append(TimeMs).Append("\n");
            sb.Append("  Iterations: ").Append(Iterations).Append("\n");
            sb.Append("  Anchor: ").Append(Anchor).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  Facets: ").Append(Facets).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("  PreviousUri: ").Append(PreviousUri).Append("\n");
            sb.Append("  FirstUri: ").Append(FirstUri).Append("\n");
            sb.Append("  NextUri: ").Append(NextUri).Append("\n");
            sb.Append("  LastUri: ").Append(LastUri).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            
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
            return this.Equals(obj as ConversationQueryResponse);
        }

        /// <summary>
        /// Returns true if ConversationQueryResponse instances are equal
        /// </summary>
        /// <param name="obj">Instance of ConversationQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationQueryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
                ) && 
                (
                    this.Entities == other.Entities ||
                    this.Entities != null &&
                    this.Entities.SequenceEqual(other.Entities)
                ) && 
                (
                    this.HasMorePrev == other.HasMorePrev ||
                    this.HasMorePrev != null &&
                    this.HasMorePrev.Equals(other.HasMorePrev)
                ) && 
                (
                    this.HasMoreNext == other.HasMoreNext ||
                    this.HasMoreNext != null &&
                    this.HasMoreNext.Equals(other.HasMoreNext)
                ) && 
                (
                    this.StartQueryTime == other.StartQueryTime ||
                    this.StartQueryTime != null &&
                    this.StartQueryTime.Equals(other.StartQueryTime)
                ) && 
                (
                    this.EndQueryTime == other.EndQueryTime ||
                    this.EndQueryTime != null &&
                    this.EndQueryTime.Equals(other.EndQueryTime)
                ) && 
                (
                    this.NewestResultTime == other.NewestResultTime ||
                    this.NewestResultTime != null &&
                    this.NewestResultTime.Equals(other.NewestResultTime)
                ) && 
                (
                    this.OldestResultTime == other.OldestResultTime ||
                    this.OldestResultTime != null &&
                    this.OldestResultTime.Equals(other.OldestResultTime)
                ) && 
                (
                    this.TimeMs == other.TimeMs ||
                    this.TimeMs != null &&
                    this.TimeMs.Equals(other.TimeMs)
                ) && 
                (
                    this.Iterations == other.Iterations ||
                    this.Iterations != null &&
                    this.Iterations.Equals(other.Iterations)
                ) && 
                (
                    this.Anchor == other.Anchor ||
                    this.Anchor != null &&
                    this.Anchor.Equals(other.Anchor)
                ) && 
                (
                    this.Sort == other.Sort ||
                    this.Sort != null &&
                    this.Sort.Equals(other.Sort)
                ) && 
                (
                    this.Facets == other.Facets ||
                    this.Facets != null &&
                    this.Facets.Equals(other.Facets)
                ) && 
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                ) && 
                (
                    this.PreviousUri == other.PreviousUri ||
                    this.PreviousUri != null &&
                    this.PreviousUri.Equals(other.PreviousUri)
                ) && 
                (
                    this.FirstUri == other.FirstUri ||
                    this.FirstUri != null &&
                    this.FirstUri.Equals(other.FirstUri)
                ) && 
                (
                    this.NextUri == other.NextUri ||
                    this.NextUri != null &&
                    this.NextUri.Equals(other.NextUri)
                ) && 
                (
                    this.LastUri == other.LastUri ||
                    this.LastUri != null &&
                    this.LastUri.Equals(other.LastUri)
                ) && 
                (
                    this.PageCount == other.PageCount ||
                    this.PageCount != null &&
                    this.PageCount.Equals(other.PageCount)
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
                
                if (this.PageSize != null)
                    hash = hash * 57 + this.PageSize.GetHashCode();
                
                if (this.PageNumber != null)
                    hash = hash * 57 + this.PageNumber.GetHashCode();
                
                if (this.Total != null)
                    hash = hash * 57 + this.Total.GetHashCode();
                
                if (this.Entities != null)
                    hash = hash * 57 + this.Entities.GetHashCode();
                
                if (this.HasMorePrev != null)
                    hash = hash * 57 + this.HasMorePrev.GetHashCode();
                
                if (this.HasMoreNext != null)
                    hash = hash * 57 + this.HasMoreNext.GetHashCode();
                
                if (this.StartQueryTime != null)
                    hash = hash * 57 + this.StartQueryTime.GetHashCode();
                
                if (this.EndQueryTime != null)
                    hash = hash * 57 + this.EndQueryTime.GetHashCode();
                
                if (this.NewestResultTime != null)
                    hash = hash * 57 + this.NewestResultTime.GetHashCode();
                
                if (this.OldestResultTime != null)
                    hash = hash * 57 + this.OldestResultTime.GetHashCode();
                
                if (this.TimeMs != null)
                    hash = hash * 57 + this.TimeMs.GetHashCode();
                
                if (this.Iterations != null)
                    hash = hash * 57 + this.Iterations.GetHashCode();
                
                if (this.Anchor != null)
                    hash = hash * 57 + this.Anchor.GetHashCode();
                
                if (this.Sort != null)
                    hash = hash * 57 + this.Sort.GetHashCode();
                
                if (this.Facets != null)
                    hash = hash * 57 + this.Facets.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                if (this.PreviousUri != null)
                    hash = hash * 57 + this.PreviousUri.GetHashCode();
                
                if (this.FirstUri != null)
                    hash = hash * 57 + this.FirstUri.GetHashCode();
                
                if (this.NextUri != null)
                    hash = hash * 57 + this.NextUri.GetHashCode();
                
                if (this.LastUri != null)
                    hash = hash * 57 + this.LastUri.GetHashCode();
                
                if (this.PageCount != null)
                    hash = hash * 57 + this.PageCount.GetHashCode();
                
                return hash;
            }
        }

    }


}
