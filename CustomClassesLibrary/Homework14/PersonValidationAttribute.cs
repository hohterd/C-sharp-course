using System;
using System.ComponentModel.DataAnnotations;


namespace CustomClassesLibrary.Homework14
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class PersonValidationAttribute : RegularExpressionAttribute
    {
        public PersonValidationAttribute(string pattern) : base(pattern)
        {

        }

        public override bool IsValid(object value)
        {
            if (value != null)
            {
                var regexValidator = new RegularExpressionAttribute(Pattern);
                if (!regexValidator.IsValid(value))
                {
                    Console.WriteLine(ErrorMessage);
                    return false;
                }
            }
            return true;
        }


    }
}
