using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace DummyMSRestApi.Data.Configurations
{
    public class LineDataTimeFieldsConfigurations : IEntityTypeConfiguration<LineData<TimeFields>>
    {
        public void Configure(EntityTypeBuilder<LineData<TimeFields>> builder)
        {
            builder.HasData(
                    new LineData<TimeFields>
                    {
                        id = "1",
                        lastModifiedDateTime = DateTime.Now.ToString(),
                        createdDateTime = DateTime.Now.ToString(),
                        createdByid = "4658ae4d-ce28-424e-b376-07a7cc7ac870",
                        webUrl = string.Empty,
                    },
                    new LineData<TimeFields>
                    {
                        id = "2",
                        lastModifiedDateTime = DateTime.Now.ToString(),
                        createdDateTime = DateTime.Now.ToString(),
                        createdByid = "4658ae4d-ce28-424e-b376-07a7cc7ac870",
                        webUrl = string.Empty,
                    },
                    new LineData<TimeFields>
                    {
                        id = "3",
                        lastModifiedDateTime = DateTime.Now.ToString(),
                        createdDateTime = DateTime.Now.ToString(),
                        createdByid = "4658ae4d-ce28-424e-b376-07a7cc7ac870",
                        webUrl = string.Empty,
                    }
                       );
                builder.OwnsOne(e => e.fields).HasData(
                    new
                    {
                        LineDataid = "1",
                        id = "1",
                        EntryStart = DateTime.Now.AddHours(-5).ToString(),
                        EntryStop = DateTime.Now.ToString(),
                        EntryType = "Dummy1",
                        ESS = "false",

                    },
                    new
                    {
                        LineDataid = "2",
                        id = "2",
                        EntryStart = DateTime.Now.AddHours(-6).ToString(),
                        EntryStop = DateTime.Now.AddHours(-5).ToString(),
                        EntryType = "Dummy1",
                        ESS = "false",

                    },
                    new
                    {
                        LineDataid = "3",
                        id = "3",
                        EntryStart = DateTime.Now.AddHours(-8).ToString(),
                        EntryStop = DateTime.Now.AddHours(-6).ToString(),
                        EntryType = "Dummy2",
                        ESS = "false",

                    }
                    );
            
        }
    }
}
