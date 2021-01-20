using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.CustomValidators
{
    public class DecimalMinValueValidator : ValidationAttribute
    {
        public double MinValue { get; set; } //No support for decimal type
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            double dValue = Decimal.ToDouble((decimal)value);
            if (dValue >= MinValue)
                return null;
            else
                return new ValidationResult("Value should be greater than or equal to " + MinValue.ToString());
        }
    }
}
