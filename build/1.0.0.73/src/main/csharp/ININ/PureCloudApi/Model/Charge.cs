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
    public class Charge :  IEquatable<Charge>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Charge" /> class.
        /// </summary>
        public Charge()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets LicenseCount
        /// </summary>
        [DataMember(Name="licenseCount", EmitDefaultValue=false)]
        public int? LicenseCount { get; set; }
  
        
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
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }
  
        
        /// <summary>
        /// Gets or Sets UnitOfMeasure
        /// </summary>
        [DataMember(Name="unitOfMeasure", EmitDefaultValue=false)]
        public string UnitOfMeasure { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BillingPeriod
        /// </summary>
        [DataMember(Name="billingPeriod", EmitDefaultValue=false)]
        public string BillingPeriod { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Quantity
        /// </summary>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public int? Quantity { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Charge {\n");
            sb.Append("  LicenseCount: ").Append(LicenseCount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  UnitOfMeasure: ").Append(UnitOfMeasure).Append("\n");
            sb.Append("  BillingPeriod: ").Append(BillingPeriod).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            
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
            return this.Equals(obj as Charge);
        }

        /// <summary>
        /// Returns true if Charge instances are equal
        /// </summary>
        /// <param name="obj">Instance of Charge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Charge other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LicenseCount == other.LicenseCount ||
                    this.LicenseCount != null &&
                    this.LicenseCount.Equals(other.LicenseCount)
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
                    this.Price == other.Price ||
                    this.Price != null &&
                    this.Price.Equals(other.Price)
                ) && 
                (
                    this.UnitOfMeasure == other.UnitOfMeasure ||
                    this.UnitOfMeasure != null &&
                    this.UnitOfMeasure.Equals(other.UnitOfMeasure)
                ) && 
                (
                    this.BillingPeriod == other.BillingPeriod ||
                    this.BillingPeriod != null &&
                    this.BillingPeriod.Equals(other.BillingPeriod)
                ) && 
                (
                    this.Quantity == other.Quantity ||
                    this.Quantity != null &&
                    this.Quantity.Equals(other.Quantity)
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
                
                if (this.LicenseCount != null)
                    hash = hash * 57 + this.LicenseCount.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 57 + this.Description.GetHashCode();
                
                if (this.Price != null)
                    hash = hash * 57 + this.Price.GetHashCode();
                
                if (this.UnitOfMeasure != null)
                    hash = hash * 57 + this.UnitOfMeasure.GetHashCode();
                
                if (this.BillingPeriod != null)
                    hash = hash * 57 + this.BillingPeriod.GetHashCode();
                
                if (this.Quantity != null)
                    hash = hash * 57 + this.Quantity.GetHashCode();
                
                return hash;
            }
        }

    }


}
