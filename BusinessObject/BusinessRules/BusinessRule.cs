namespace BusinessObject.BusinessRules
{
    public abstract class BusinessRule
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }

        protected BusinessRule(string propertyName)
        {
            PropertyName = propertyName;
            ErrorMessage = propertyName + " is not valid";
        }

        protected BusinessRule(string propertyName, string errorMessage)
        {
            this.PropertyName = propertyName;
            this.ErrorMessage = errorMessage;
        }

        public abstract bool Validate(BusinessObject obj);

        protected object GetPropertyValue(BusinessObject obj)
        {
            return obj.GetType().GetProperty(this.PropertyName).GetValue(obj, null);
        }
    }
}
