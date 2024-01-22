using DummyMSRestApi.Data;
using DummyMSRestApi.Core.Models.User;
using System.ComponentModel.DataAnnotations.Schema;

namespace DummyMSRestApi.Core.Models.TimeData
{
    public class TimeFieldDto : BaseTimeDto
    {
        public string id { get; set; }
        public string createdDateTime { get; set; }
        public string lastModifiedDateTime { get; set; }
        public string webUrl { get; set; }
        public UsersDto createdBy { get; set; }
    }
}
