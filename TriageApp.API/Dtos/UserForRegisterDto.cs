using System.ComponentModel.DataAnnotations;

namespace TriageApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(20, MinimumLength= 6, ErrorMessage="Your password must be between 8 and 20 characters.")]
        public string Password { get; set; }
    }
}