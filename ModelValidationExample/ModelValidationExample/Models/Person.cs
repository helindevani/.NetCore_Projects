<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ModelValidationExample.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.Models
{
    public class Person : IValidatableObject
    {
        [Required(ErrorMessage ="{0} can't be empty or null")]
        [Display(Name = "Person Name")]
        [StringLength(40, MinimumLength =3,ErrorMessage ="{0} should be between {2} and {1} charaters long")]
        [RegularExpression("^[A_Za-z .]*$",ErrorMessage ="{0} should contain only alphabets, space and dot (.)")]
        public string? PersonName { get; set; }

        [EmailAddress(ErrorMessage = "{0} should be a proper email address")]
        public string? Email { get; set; }

        [Phone(ErrorMessage ="{0} shoud contain 10 digits")]
        //[ValidateNever]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="{0} can't be blank")]
        public string? Password { get; set;}

        [Required(ErrorMessage = "{0} can't be blank")]
        [Compare("Password", ErrorMessage ="{0} and {1} do not match")]
        [Display(Name = "Re-enter Password")]
        public string? ConfirmPassword { get; set;}

        [Range(0,999.99,ErrorMessage ="{0} should be between {1} and {2}")]
        public double? Price { get; set; }

        //[MinimumYearValidator(2005, ErrorMessage ="Date of Birth Should not be newer than jan 01, {0}")]
        [MinimumYearValidator(2005)]
        //[BindNever]
        public DateTime? DateOfBirth { get; set; }

        public DateTime? FromDate { get; set; }

        [DateRangeValidator("FromDate", ErrorMessage ="'From date' should be equal to or older than 'To Date'")]
        public DateTime? ToDate { get; set; }

        public int? Age { get; set; }

        public List<string?> Tags { get; set; } = new List<string?>();

        public override string ToString()
        {
            return $"Person Name: {PersonName}, Email : {Email}, Phone : {Phone}, Password : {Password}, ConfirmPassword : {ConfirmPassword}, Price : {Price}";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(DateOfBirth.HasValue == false && Age.HasValue == false)
            {
                yield return new ValidationResult("Either of Date of Birth Or Age Must Be Supplied", new[] { nameof(Age) });
            }
        }
    }
}
=======
﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using ModelValidationExample.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationExample.Models
{
    public class Person : IValidatableObject
    {
        [Required(ErrorMessage ="{0} can't be empty or null")]
        [Display(Name = "Person Name")]
        [StringLength(40, MinimumLength =3,ErrorMessage ="{0} should be between {2} and {1} charaters long")]
        [RegularExpression("^[A_Za-z .]*$",ErrorMessage ="{0} should contain only alphabets, space and dot (.)")]
        public string? PersonName { get; set; }

        [EmailAddress(ErrorMessage = "{0} should be a proper email address")]
        public string? Email { get; set; }

        [Phone(ErrorMessage ="{0} shoud contain 10 digits")]
        //[ValidateNever]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="{0} can't be blank")]
        public string? Password { get; set;}

        [Required(ErrorMessage = "{0} can't be blank")]
        [Compare("Password", ErrorMessage ="{0} and {1} do not match")]
        [Display(Name = "Re-enter Password")]
        public string? ConfirmPassword { get; set;}

        [Range(0,999.99,ErrorMessage ="{0} should be between {1} and {2}")]
        public double? Price { get; set; }

        //[MinimumYearValidator(2005, ErrorMessage ="Date of Birth Should not be newer than jan 01, {0}")]
        [MinimumYearValidator(2005)]
        //[BindNever]
        public DateTime? DateOfBirth { get; set; }

        public DateTime? FromDate { get; set; }

        [DateRangeValidator("FromDate", ErrorMessage ="'From date' should be equal to or older than 'To Date'")]
        public DateTime? ToDate { get; set; }

        public int? Age { get; set; }

        public List<string?> Tags { get; set; } = new List<string?>();

        public override string ToString()
        {
            return $"Person Name: {PersonName}, Email : {Email}, Phone : {Phone}, Password : {Password}, ConfirmPassword : {ConfirmPassword}, Price : {Price}";
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(DateOfBirth.HasValue == false && Age.HasValue == false)
            {
                yield return new ValidationResult("Either of Date of Birth Or Age Must Be Supplied", new[] { nameof(Age) });
            }
        }
    }
}
>>>>>>> 84ef70a4525f3b65b6294732992407190e86ba78
