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
    public class XlsxSchema :  IEquatable<XlsxSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XlsxSchema" /> class.
        /// </summary>
        public XlsxSchema()
        {
            
        }

        
        /// <summary>
        /// A list of all the schemas for a XLSX file. Each schema represents a different sheet's schema.
        /// </summary>
        /// <value>A list of all the schemas for a XLSX file. Each schema represents a different sheet's schema.</value>
        [DataMember(Name="SheetSchemas", EmitDefaultValue=false)]
        public List<SheetSchema> SheetSchemas { get; set; }
  
        
        /// <summary>
        /// Human readable name for schema.
        /// </summary>
        /// <value>Human readable name for schema.</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Carrier ID associated with this CSV schema.
        /// </summary>
        /// <value>Carrier ID associated with this CSV schema.</value>
        [DataMember(Name="CarrierId", EmitDefaultValue=false)]
        public string CarrierId { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XlsxSchema {\n");
            sb.Append("  SheetSchemas: ").Append(SheetSchemas).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CarrierId: ").Append(CarrierId).Append("\n");
            
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
            return this.Equals(obj as XlsxSchema);
        }

        /// <summary>
        /// Returns true if XlsxSchema instances are equal
        /// </summary>
        /// <param name="obj">Instance of XlsxSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XlsxSchema other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SheetSchemas == other.SheetSchemas ||
                    this.SheetSchemas != null &&
                    this.SheetSchemas.SequenceEqual(other.SheetSchemas)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.CarrierId == other.CarrierId ||
                    this.CarrierId != null &&
                    this.CarrierId.Equals(other.CarrierId)
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
                
                if (this.SheetSchemas != null)
                    hash = hash * 57 + this.SheetSchemas.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.CarrierId != null)
                    hash = hash * 57 + this.CarrierId.GetHashCode();
                
                return hash;
            }
        }

    }


}