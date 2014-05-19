using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObject.BusinessRules
{
    public class ValidateId : BusinessRule
    {
        public ValidateId(string propertyName)
            : base(propertyName)
        {
            ErrorMessage = PropertyName + " is an invalid identifier";
        }

        public ValidateId(string propertyName, string errorMessage)
            : base(propertyName, errorMessage)
        {
        }

        public override bool Validate(BusinessObject obj)
        {
            try
            {
                int id = int.Parse(GetPropertyValue(obj).ToString());
                return id >= 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
