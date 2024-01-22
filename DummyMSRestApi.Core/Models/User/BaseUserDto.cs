using System.ComponentModel.DataAnnotations;

namespace DummyMSRestApi.Core.Models.User
{
    public class BaseUserDto
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string displayName { get; set; }
    }
}
