using System.ComponentModel.DataAnnotations;

namespace TriageApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage="Username is required.")]
        [StringLength(12, MinimumLength= 3, ErrorMessage="Your username must be between 3 and 12 characters.")]
        public string Username { get; set; }
        [Required(ErrorMessage="Password is required.")]
        [StringLength(20, MinimumLength= 6, ErrorMessage="Your password must be between 6 and 20 characters.")]
        public string Password { get; set; }
    }
}