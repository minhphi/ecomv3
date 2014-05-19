using System.Collections.Generic;
using System.Runtime.Serialization;
using BusinessObject.BusinessRules;

namespace BusinessObject
{
    [DataContract()]
    public class BusinessObject
    {
        protected List<BusinessRule> BusinessRules = new List<BusinessRule>();
        protected List<string> ValidateErrors = new List<string>();

        public void AddRule(BusinessRule rule)
        {
            this.BusinessRules.Add(rule);
        }

        public bool Validate()
        {
            bool isValidate = true;
            ValidateErrors.Clear();

            foreach (var rule in BusinessRules)
            {
                if (rule.Validate(this) == false)
                {
                    isValidate = false;
                    this.ValidateErrors.Add(rule.ErrorMessage);
                }
            }
            return isValidate;
        }
    }
}
