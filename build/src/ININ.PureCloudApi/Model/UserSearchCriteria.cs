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
    /// UserSearchCriteria
    /// </summary>
    [DataContract]
    public partial class UserSearchCriteria :  IEquatable<UserSearchCriteria>
    {
        /// <summary>
        /// How to apply this search criteria against other criteria
        /// </summary>
        /// <value>How to apply this search criteria against other criteria</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperatorEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum And for "AND"
            /// </summary>
            [EnumMember(Value = "AND")]
            And,
            
            /// <summary>
            /// Enum Or for "OR"
            /// </summary>
            [EnumMember(Value = "OR")]
            Or,
            
            /// <summary>
            /// Enum Not for "NOT"
            /// </summary>
            [EnumMember(Value = "NOT")]
            Not
        }
        /// <summary>
        /// Search Type
        /// </summary>
        /// <value>Search Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Exact for "EXACT"
            /// </summary>
            [EnumMember(Value = "EXACT")]
            Exact,
            
            /// <summary>
            /// Enum StartsWith for "STARTS_WITH"
            /// </summary>
            [EnumMember(Value = "STARTS_WITH")]
            StartsWith,
            
            /// <summary>
            /// Enum Contains for "CONTAINS"
            /// </summary>
            [EnumMember(Value = "CONTAINS")]
            Contains,
            
            /// <summary>
            /// Enum Regex for "REGEX"
            /// </summary>
            [EnumMember(Value = "REGEX")]
            Regex,
            
            /// <summary>
            /// Enum Term for "TERM"
            /// </summary>
            [EnumMember(Value = "TERM")]
            Term,
            
            /// <summary>
            /// Enum Terms for "TERMS"
            /// </summary>
            [EnumMember(Value = "TERMS")]
            Terms,
            
            /// <summary>
            /// Enum RequiredFields for "REQUIRED_FIELDS"
            /// </summary>
            [EnumMember(Value = "REQUIRED_FIELDS")]
            RequiredFields
        }
        /// <summary>
        /// How to apply this search criteria against other criteria
        /// </summary>
        /// <value>How to apply this search criteria against other criteria</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public OperatorEnum? _Operator { get; set; }
        /// <summary>
        /// Search Type
        /// </summary>
        /// <value>Search Type</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearchCriteria" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserSearchCriteria() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSearchCriteria" /> class.
        /// </summary>
        /// <param name="EndValue">The end value of the range. This field is used for range search types..</param>
        /// <param name="Values">A list of values for the search to match against.</param>
        /// <param name="StartValue">The start value of the range. This field is used for range search types..</param>
        /// <param name="Fields">Field names to search against.</param>
        /// <param name="Value">A value for the search to match against.</param>
        /// <param name="_Operator">How to apply this search criteria against other criteria.</param>
        /// <param name="Group">Groups multiple conditions.</param>
        /// <param name="Type">Search Type (required).</param>
        public UserSearchCriteria(string EndValue = null, List<string> Values = null, string StartValue = null, List<string> Fields = null, string Value = null, OperatorEnum? _Operator = null, List<UserSearchCriteria> Group = null, TypeEnum? Type = null)
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for UserSearchCriteria and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.EndValue = EndValue;
            this.Values = Values;
            this.StartValue = StartValue;
            this.Fields = Fields;
            this.Value = Value;
            this._Operator = _Operator;
            this.Group = Group;
        }
        
        /// <summary>
        /// The end value of the range. This field is used for range search types.
        /// </summary>
        /// <value>The end value of the range. This field is used for range search types.</value>
        [DataMember(Name="endValue", EmitDefaultValue=false)]
        public string EndValue { get; set; }
        /// <summary>
        /// A list of values for the search to match against
        /// </summary>
        /// <value>A list of values for the search to match against</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<string> Values { get; set; }
        /// <summary>
        /// The start value of the range. This field is used for range search types.
        /// </summary>
        /// <value>The start value of the range. This field is used for range search types.</value>
        [DataMember(Name="startValue", EmitDefaultValue=false)]
        public string StartValue { get; set; }
        /// <summary>
        /// Field names to search against
        /// </summary>
        /// <value>Field names to search against</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<string> Fields { get; set; }
        /// <summary>
        /// A value for the search to match against
        /// </summary>
        /// <value>A value for the search to match against</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
        /// <summary>
        /// Groups multiple conditions
        /// </summary>
        /// <value>Groups multiple conditions</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public List<UserSearchCriteria> Group { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSearchCriteria {\n");
            sb.Append("  EndValue: ").Append(EndValue).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  StartValue: ").Append(StartValue).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(obj as UserSearchCriteria);
        }

        /// <summary>
        /// Returns true if UserSearchCriteria instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSearchCriteria to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSearchCriteria other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.EndValue == other.EndValue ||
                    this.EndValue != null &&
                    this.EndValue.Equals(other.EndValue)
                ) &&
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
                ) &&
                (
                    this.StartValue == other.StartValue ||
                    this.StartValue != null &&
                    this.StartValue.Equals(other.StartValue)
                ) &&
                (
                    this.Fields == other.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(other.Fields)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) &&
                (
                    this.Group == other.Group ||
                    this.Group != null &&
                    this.Group.SequenceEqual(other.Group)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
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
                if (this.EndValue != null)
                    hash = hash * 59 + this.EndValue.GetHashCode();
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
                if (this.StartValue != null)
                    hash = hash * 59 + this.StartValue.GetHashCode();
                if (this.Fields != null)
                    hash = hash * 59 + this.Fields.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                if (this.Group != null)
                    hash = hash * 59 + this.Group.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }
    }

}
