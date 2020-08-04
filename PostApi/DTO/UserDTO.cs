using System.ComponentModel.DataAnnotations;

namespace PostApi.DTO
{
    public class UserDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        public string Location { set; get; }
    }
}

