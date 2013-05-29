using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCValidate.Models
{
    public class TestModelsRequired
    {
        //BMK 各種 Required
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "就說必填了←Key")]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "Required", ErrorMessageResourceType = typeof(L10N.Resource1))]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }

    public class TestModelsStringLength
    {
        //BMK 各種 StringLength
        [StringLength(2)]
        [Display(Name = "User name(2)")]
        public string UserName { get; set; }

        [StringLength(3, MinimumLength = 2)]
        [Display(Name = "Email address(2~3)")]
        public string Email { get; set; }

        [StringLength(3, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [Display(Name = "Password(2~3)")]
        public string Password { get; set; }

        [StringLength(3, ErrorMessageResourceName = "StringLength", ErrorMessageResourceType = typeof(L10N.Resource1), MinimumLength = 2)]
        [Display(Name = "Confirm password(2~3)")]
        public string ConfirmPassword { get; set; }
    }

    public class TestModelsRegex
    {
        //BMK 各種 Regex
        [RegularExpression(@"\w{1,3}")]
        [Display(Name = "User name(\\w{1,3})")]
        public string UserName { get; set; }

        [RegularExpression(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "請輸入正確的Email")]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [RegularExpression(@"\w{1,3}", ErrorMessageResourceName = "Regex", ErrorMessageResourceType = typeof(L10N.Resource1))]
        [Display(Name = "Password(2~3)")]
        public string Password { get; set; }

        [Display(Name = "Confirm password(2~3)")]
        public string ConfirmPassword { get; set; }
    }

    public class TestModelsCompare
    {

        //BMK 各種 Compare
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "密碼不一致")]
        public string ConfirmPassword { get; set; }

    }

    public class TestModelsRemove
    {
        [Remote("CheckUserName", "Validate", ErrorMessage = "遠端驗證失敗")]
        [Display(Name = "User name(不能輸入 demoshop)")]
        public string UserName { get; set; }
    }

    
    public class TestModelsAllowHtml
    {
        [Display(Name = "AllowHtml")]
        public string AllowHtml { get; set; }
        [Display(Name = "Disallow")]
        public string Disallow { get; set; }
    }
}