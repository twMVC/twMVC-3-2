//------------------------------------------------------------------------------
// <auto-generated>
//      This code was generated from demoshop template.
//      http://demo.tc
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MvcApplication1.Models
{
    [System.ComponentModel.DataAnnotations.MetadataType(typeof(ProductsMetadata))] 
    public partial class Products:IValidatableObject
    {
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (UnitsInStock < UnitsOnOrder)
            {
                results.Add(new ValidationResult("庫存小於訂單數量", new string[] { "UnitsInStock" }));
            }
            if (UnitsOnOrder > 100)
            {
                results.Add(new ValidationResult("一買一百個可能是騙子", new string[] { "UnitsOnOrder" }));
            }
            return results;
        }
    }
}
