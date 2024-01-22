using DummyMSRestApi.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DummyMSRestApi.Core.Models.TypeData
{
    public class UpdateTypeDto: BaseTypeDto
    {
        [Required]
        public string id { get; set; }
        public string webUrl { get; set; }
        public string createdByid { get; set; }
    }
}
