using DummyMSRestApi.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace DummyMSRestApi.Core.Models.TimeData
{
    public class CreateTimeDto : BaseTimeDto
    {
        public string webUrl { get; set; }
        public string createdByid { get; set; }
    }
}
