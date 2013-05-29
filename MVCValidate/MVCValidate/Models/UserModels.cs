using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCValidate.Models
{
    public class UserModels:IValidatableObject
    {
            public string UserName { get; set; }
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }

            [Display(Name = "報名人數")]
            public int RegisterCount { get; set; }

            [Display(Name = "名額限制")]
            public int Quota { get; set; }

 
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            if (RegisterCount > Quota)
            {
                results.Add(new ValidationResult("報名人數已經超過名額限制", new string[] { "RegisterCount" }));
            }
            if (RegisterCount > 3)
            {
                results.Add(new ValidationResult("單次最多報名三位學員", new string[] { "RegisterCount" }));
            }
            return results;
        }
    }
}