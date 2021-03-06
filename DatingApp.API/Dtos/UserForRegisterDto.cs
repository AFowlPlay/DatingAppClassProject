using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        
        public string Username {get; set;}

        [Required]
        [StringLength(25, MinimumLength = 8, ErrorMessage = "You must have a password greater than or equal to 8 characters")]
        public string Password { get; set; }    
    }
}