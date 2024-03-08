<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.CustomValidators
{
    public class MinimumYearValidatorAttribute : ValidationAttribute
    {
        public int MinimumYear { get; set; } = 2000;
        public string DefaultErrorMessage { get; set; } = "Year Should be less than {0}";
        public MinimumYearValidatorAttribute() { }

        public MinimumYearValidatorAttribute(int minimumYear) 
        {
            MinimumYear = minimumYear;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value != null) 
            { 
                DateTime date = (DateTime)value;
                if(date.Year >= MinimumYear)
                {
                    return new ValidationResult(string.Format(ErrorMessage?? DefaultErrorMessage,MinimumYear));
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            return null;
        }
    }
}
=======
﻿using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.CustomValidators
{
    public class MinimumYearValidatorAttribute : ValidationAttribute
    {
        public int MinimumYear { get; set; } = 2000;
        public string DefaultErrorMessage { get; set; } = "Year Should be less than {0}";
        public MinimumYearValidatorAttribute() { }

        public MinimumYearValidatorAttribute(int minimumYear) 
        {
            MinimumYear = minimumYear;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value != null) 
            { 
                DateTime date = (DateTime)value;
                if(date.Year >= MinimumYear)
                {
                    return new ValidationResult(string.Format(ErrorMessage?? DefaultErrorMessage,MinimumYear));
                }
                else
                {
                    return ValidationResult.Success;
                }
            }
            return null;
        }
    }
}
>>>>>>> 84ef70a4525f3b65b6294732992407190e86ba78
