using System.ComponentModel.DataAnnotations.Schema;

namespace DummyMSRestApi.Data
{
    public class LineData<T>
    {
        public string id { get; set; }
        public string createdDateTime { get; set; }
        public string lastModifiedDateTime { get; set; }
        public string webUrl { get; set; }
        public T fields { get; set; }
        [ForeignKey(nameof(createdByid))]
        public string createdByid { get; set; }
        public virtual UserType createdBy { get; set; }
    }
}
