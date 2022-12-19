using System.ComponentModel.DataAnnotations;

namespace SmartLynx.ApiModel.Models
{
    public class UserModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
