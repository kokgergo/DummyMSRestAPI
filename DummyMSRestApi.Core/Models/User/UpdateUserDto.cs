using System.ComponentModel.DataAnnotations;

namespace DummyMSRestApi.Core.Models.User
{
    public class UpdateUserDto : BaseUserDto
    {
        [Required]
        public string Id { get; set; }
    }
}
