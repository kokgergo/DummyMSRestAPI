using DummyMSRestApi.Data;
using DummyMSRestApi.Core.Models.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace DummyMSRestApi.Core.Models.TypeData
{
    public class TypeFieldDto : BaseTypeDto
    {
        public string id { get; set; }
        public string createdDateTime { get; set; }
        public string lastModifiedDateTime { get; set; }
        public string webUrl { get; set; }
        public UsersDto createdBy { get; set; }
    }
}
