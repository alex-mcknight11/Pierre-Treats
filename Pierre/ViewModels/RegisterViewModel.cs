using System.ComponentModel.DataAnnotations;

namespace Pierre.ViewModels
{
  public class RegisterViewModel
  {
    
    
    [Required]
    [EmailAddress]
    [Display(Name = "Enter Email")]
    public string Email {get;set;}

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "Enter Password")]
    public string Password {get; set;}

    [DataType(DataType.Password)]
    [Display(Name = "Confirm Your Password")]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword{get;set;}
  }
}