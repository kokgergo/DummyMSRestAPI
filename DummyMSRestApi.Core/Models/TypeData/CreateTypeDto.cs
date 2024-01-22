using DummyMSRestApi.Data;
using System.ComponentModel.DataAnnotations.Schema;

namespace DummyMSRestApi.Core.Models.TypeData
{
    public class CreateTypeDto :BaseTypeDto
    {
        public string webUrl { get; set; }
        public string createdByid { get; set; }
    }
}
