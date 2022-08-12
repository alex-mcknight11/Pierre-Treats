using System.ComponentModel.DataAnnotations;

namespace Pierre.ViewModels
{
  public class RegisterViewModel
  {
    
    
    [Required]
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email {get;set;}

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string Password {get; set;}

    [DataType(DataType.Password)]
    [Display(Name = "ConfirmPassword")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword{get;set;}
  }
}