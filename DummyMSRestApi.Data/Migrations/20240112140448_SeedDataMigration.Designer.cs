﻿// <auto-generated />
using DummyMSRestApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DummyMSRestApi.Migrations
{
    [DbContext(typeof(DummyMSRestDbContext))]
    [Migration("20240112140448_SeedDataMigration")]
    partial class SeedDataMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DummyMSRestApi.Data.LineData<DummyMSRestApi.Data.TimeFields>", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("createdByid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("createdDateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastModifiedDateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("webUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("createdByid");

                    b.ToTable("timeDatas");

                    b.HasData(
                        new
                        {
                            id = "1",
                            UserId = "1",
                            createdDateTime = "2024. 01. 12. 15:04:48",
                            lastModifiedDateTime = "2024. 01. 12. 15:04:48",
                            webUrl = ""
                        },
                        new
                        {
                            id = "2",
                            UserId = "1",
                            createdDateTime = "2024. 01. 12. 15:04:48",
                            lastModifiedDateTime = "2024. 01. 12. 15:04:48",
                            webUrl = ""
                        },
                        new
                        {
                            id = "3",
                            UserId = "1",
                            createdDateTime = "2024. 01. 12. 15:04:48",
                            lastModifiedDateTime = "2024. 01. 12. 15:04:48",
                            webUrl = ""
                        });
                });

            modelBuilder.Entity("DummyMSRestApi.Data.LineData<DummyMSRestApi.Data.TypeFields>", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("createdByid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("createdDateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastModifiedDateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("webUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("createdByid");

                    b.ToTable("lineDatas");

                    b.HasData(
                        new
                        {
                            id = "1",
                            UserId = "1",
                            createdDateTime = "2024. 01. 12. 15:04:48",
                            lastModifiedDateTime = "2024. 01. 12. 15:04:48",
                            webUrl = ""
                        },
                        new
                        {
                            id = "2",
                            UserId = "1",
                            createdDateTime = "2024. 01. 12. 15:04:48",
                            lastModifiedDateTime = "2024. 01. 12. 15:04:48",
                            webUrl = ""
                        });
                });

            modelBuilder.Entity("DummyMSRestApi.Data.UserType", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("displayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("UserType");

                    b.HasData(
                        new
                        {
                            id = "1",
                            displayName = "Dummy1",
                            email = "dummy@bosch.com"
                        });
                });

            modelBuilder.Entity("DummyMSRestApi.Data.LineData<DummyMSRestApi.Data.TimeFields>", b =>
                {
                    b.HasOne("DummyMSRestApi.Data.UserType", "createdBy")
                        .WithMany("timeDatas")
                        .HasForeignKey("createdByid");

                    b.OwnsOne("DummyMSRestApi.Data.TimeFields", "fields", b1 =>
                        {
                            b1.Property<string>("LineDataid")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("ESS")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("EntryStart")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("EntryStop")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("EntryType")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("id")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("LineDataid");

                            b1.ToTable("timeDatas");

                            b1.WithOwner()
                                .HasForeignKey("LineDataid");

                            b1.HasData(
                                new
                                {
                                    LineDataid = "1",
                                    ESS = "false",
                                    EntryStart = "2024. 01. 12. 10:04:48",
                                    EntryStop = "2024. 01. 12. 15:04:48",
                                    EntryType = "Dummy1",
                                    id = "1"
                                },
                                new
                                {
                                    LineDataid = "2",
                                    ESS = "false",
                                    EntryStart = "2024. 01. 12. 9:04:48",
                                    EntryStop = "2024. 01. 12. 10:04:48",
                                    EntryType = "Dummy1",
                                    id = "2"
                                },
                                new
                                {
                                    LineDataid = "3",
                                    ESS = "false",
                                    EntryStart = "2024. 01. 12. 7:04:48",
                                    EntryStop = "2024. 01. 12. 9:04:48",
                                    EntryType = "Dummy2",
                                    id = "3"
                                });
                        });

                    b.Navigation("createdBy");

                    b.Navigation("fields");
                });

            modelBuilder.Entity("DummyMSRestApi.Data.LineData<DummyMSRestApi.Data.TypeFields>", b =>
                {
                    b.HasOne("DummyMSRestApi.Data.UserType", "createdBy")
                        .WithMany("typeDatas")
                        .HasForeignKey("createdByid");

                    b.OwnsOne("DummyMSRestApi.Data.TypeFields", "fields", b1 =>
                        {
                            b1.Property<string>("LineDataid")
                                .HasColumnType("nvarchar(450)");

                            b1.Property<string>("PreferedOreder")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("SAPCode")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Title")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("id")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("LineDataid");

                            b1.ToTable("lineDatas");

                            b1.WithOwner()
                                .HasForeignKey("LineDataid");

                            b1.HasData(
                                new
                                {
                                    LineDataid = "1",
                                    PreferedOreder = "1",
                                    SAPCode = "0100",
                                    Title = "Dummy1",
                                    id = "1"
                                },
                                new
                                {
                                    LineDataid = "2",
                                    PreferedOreder = "2",
                                    SAPCode = "0200",
                                    Title = "Dummy2",
                                    id = "2"
                                });
                        });

                    b.Navigation("createdBy");

                    b.Navigation("fields");
                });

            modelBuilder.Entity("DummyMSRestApi.Data.UserType", b =>
                {
                    b.Navigation("timeDatas");

                    b.Navigation("typeDatas");
                });
#pragma warning restore 612, 618
        }
    }
}
