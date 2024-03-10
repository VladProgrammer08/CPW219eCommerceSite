using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CPW219eCommerceSite.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string? Phone { get; set; }

        public string? Username { get; set; }
    }

    [Keyless]
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [Compare(nameof(Email))]
        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; }

        [Required]
        [StringLength(75, MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        [Display (Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmePassword { get; set; }
    }

    [Keyless]
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
