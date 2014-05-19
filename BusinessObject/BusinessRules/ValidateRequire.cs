using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject.BusinessRules
{
    public class ValidateRequire : BusinessRule
    {
        public ValidateRequire(string propertyName)
            : base(propertyName)
        {
            ErrorMessage = propertyName + " is required.";
        }

        public ValidateRequire(string propertyName, string errorMessage)
            : base(propertyName, errorMessage)
        {
        }

        public override bool Validate(BusinessObject obj)
        {
            return !string.IsNullOrEmpty(GetPropertyValue(obj).ToString());
        }
    }
}
