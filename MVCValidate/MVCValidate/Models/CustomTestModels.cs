using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCValidate.Models
{
    public class CustomTestModels
    {
        [Display(Name = "Name (不能輸入 mvc)")]
        public string Name { get; set; }

        [Display(Name="Email 驗證")]
        public string Email { get; set; }
    }
}