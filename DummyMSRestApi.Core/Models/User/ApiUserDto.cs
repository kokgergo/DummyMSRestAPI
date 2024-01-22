using System.ComponentModel.DataAnnotations;

namespace DummyMSRestApi.Core.Models.User
{
    public class ApiUserDto : LoginDto
    {
        [Required]
        public string displayName { get; set; }
        
    }
}
