using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCValidate.Attribute
{
    public class NoIsAttribute : ValidationAttribute, IClientValidatable
    {
        private string Input { get; set; }

        //因為此驗證不可能不輸入要禁止的值，所以利用建構式來強迫輸入
        public NoIsAttribute(string input)
        {
            this.Input = input;
        }
        
        public override bool IsValid(object value)
        {
            //要不要輸入與此驗證無關
            if (value == null)
            {
                return true;
            }

            //如果輸入的值是字串才做判斷
            if (value is string)
            {
                //輸入值與欄位值相同就報錯
                if (Input.Contains(value.ToString()))
                {
                    return false;
                }
            }
            return true;
        }

        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule rule = new ModelClientValidationRule
            {
                ValidationType = "nois",
                ErrorMessage = FormatErrorMessage(metadata.GetDisplayName())
            };
            //此參數一定要是小寫！
            rule.ValidationParameters["input"] = Input;
            yield return rule;
        }
    }
}