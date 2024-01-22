using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DummyMSRestApi.Data.Configurations
{
    public class LineDataTypeFieldsConfigurations : IEntityTypeConfiguration<LineData<TypeFields>>
    {
        public void Configure(EntityTypeBuilder<LineData<TypeFields>> builder)
        {
            builder.HasData(
               new LineData<TypeFields>
               {
                   id = "1",
                   lastModifiedDateTime = DateTime.Now.ToString(),
                   createdDateTime = DateTime.Now.ToString(),
                   createdByid = "4658ae4d-ce28-424e-b376-07a7cc7ac870",
                   webUrl = string.Empty,

               },
               new LineData<TypeFields>
               {
                   id = "2",
                   lastModifiedDateTime = DateTime.Now.ToString(),
                   createdDateTime = DateTime.Now.ToString(),
                   createdByid = "4658ae4d-ce28-424e-b376-07a7cc7ac870",
                   webUrl = string.Empty,

               });
            builder.OwnsOne(e => e.fields).HasData(
                new
                {
                    LineDataid = "1",
                    id = "1",
                    SAPCode = "0100",
                    PreferedOreder = "1",
                    Title = "Dummy1"
                },
                new
                {
                    LineDataid = "2",
                    id = "2",
                    SAPCode = "0200",
                    PreferedOreder = "2",
                    Title = "Dummy2"
                }
                );
        }
    }
}
