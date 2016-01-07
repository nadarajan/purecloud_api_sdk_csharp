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
    public class EvaluationScoringSet :  IEquatable<EvaluationScoringSet>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationScoringSet" /> class.
        /// </summary>
        public EvaluationScoringSet()
        {
            this.AnyFailedKillQuestions = false;
            
        }

        
        /// <summary>
        /// Gets or Sets TotalScore
        /// </summary>
        [DataMember(Name="totalScore", EmitDefaultValue=false)]
        public float? TotalScore { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TotalCriticalScore
        /// </summary>
        [DataMember(Name="totalCriticalScore", EmitDefaultValue=false)]
        public float? TotalCriticalScore { get; set; }
  
        
        /// <summary>
        /// Gets or Sets QuestionGroupScores
        /// </summary>
        [DataMember(Name="questionGroupScores", EmitDefaultValue=false)]
        public List<QuestionGroupScore> QuestionGroupScores { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AnyFailedKillQuestions
        /// </summary>
        [DataMember(Name="anyFailedKillQuestions", EmitDefaultValue=false)]
        public bool? AnyFailedKillQuestions { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }
  
        
        /// <summary>
        /// Gets or Sets AgentComments
        /// </summary>
        [DataMember(Name="agentComments", EmitDefaultValue=false)]
        public string AgentComments { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EvaluationScoringSet {\n");
            sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
            sb.Append("  TotalCriticalScore: ").Append(TotalCriticalScore).Append("\n");
            sb.Append("  QuestionGroupScores: ").Append(QuestionGroupScores).Append("\n");
            sb.Append("  AnyFailedKillQuestions: ").Append(AnyFailedKillQuestions).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  AgentComments: ").Append(AgentComments).Append("\n");
            
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
            return this.Equals(obj as EvaluationScoringSet);
        }

        /// <summary>
        /// Returns true if EvaluationScoringSet instances are equal
        /// </summary>
        /// <param name="obj">Instance of EvaluationScoringSet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvaluationScoringSet other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TotalScore == other.TotalScore ||
                    this.TotalScore != null &&
                    this.TotalScore.Equals(other.TotalScore)
                ) && 
                (
                    this.TotalCriticalScore == other.TotalCriticalScore ||
                    this.TotalCriticalScore != null &&
                    this.TotalCriticalScore.Equals(other.TotalCriticalScore)
                ) && 
                (
                    this.QuestionGroupScores == other.QuestionGroupScores ||
                    this.QuestionGroupScores != null &&
                    this.QuestionGroupScores.SequenceEqual(other.QuestionGroupScores)
                ) && 
                (
                    this.AnyFailedKillQuestions == other.AnyFailedKillQuestions ||
                    this.AnyFailedKillQuestions != null &&
                    this.AnyFailedKillQuestions.Equals(other.AnyFailedKillQuestions)
                ) && 
                (
                    this.Comments == other.Comments ||
                    this.Comments != null &&
                    this.Comments.Equals(other.Comments)
                ) && 
                (
                    this.AgentComments == other.AgentComments ||
                    this.AgentComments != null &&
                    this.AgentComments.Equals(other.AgentComments)
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
                
                if (this.TotalScore != null)
                    hash = hash * 57 + this.TotalScore.GetHashCode();
                
                if (this.TotalCriticalScore != null)
                    hash = hash * 57 + this.TotalCriticalScore.GetHashCode();
                
                if (this.QuestionGroupScores != null)
                    hash = hash * 57 + this.QuestionGroupScores.GetHashCode();
                
                if (this.AnyFailedKillQuestions != null)
                    hash = hash * 57 + this.AnyFailedKillQuestions.GetHashCode();
                
                if (this.Comments != null)
                    hash = hash * 57 + this.Comments.GetHashCode();
                
                if (this.AgentComments != null)
                    hash = hash * 57 + this.AgentComments.GetHashCode();
                
                return hash;
            }
        }

    }


}
