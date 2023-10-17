using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models;

public class User
{
    [Required]
    [MinLength(4)]
    public string? FirstName { get; set; }
    [Required]
    [MinLength(4)]
    public string? LastName { get; set; }
    [Required]
    [PostiveValue]
    public int Age { get; set; }
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    [MinLength(8)]
    [DataType(DataType.Password)]
    public string? Password { get; set; }
}

public class PostiveValueAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if ((int)value < 0)
        {
            // we return an error message in ValidationResult we want to render
            return new ValidationResult("La edad debe ser mayor a 0");
        } else {
            // Otherwise, we were successful and can report our success
            return ValidationResult.Success;
        }
    }
}
