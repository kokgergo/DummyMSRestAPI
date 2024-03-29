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
    [Migration("20240112125647_InitialMigration")]
    partial class InitialMigration
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

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("createdByid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("createdDateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fieldsid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("lastModifiedDateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("webUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("createdByid");

                    b.HasIndex("fieldsid");

                    b.ToTable("timeDatas");
                });

            modelBuilder.Entity("DummyMSRestApi.Data.LineData<DummyMSRestApi.Data.TypeFields>", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("createdByid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("createdDateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fieldsid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("lastModifiedDateTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("webUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("createdByid");

                    b.HasIndex("fieldsid");

                    b.ToTable("lineDatas");
                });

            modelBuilder.Entity("DummyMSRestApi.Data.TimeFields", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ESS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntryStart")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntryStop")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntryType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TimeFields");
                });

            modelBuilder.Entity("DummyMSRestApi.Data.TypeFields", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PreferedOreder")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SAPCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TypeFields");
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
                });

            modelBuilder.Entity("DummyMSRestApi.Data.LineData<DummyMSRestApi.Data.TimeFields>", b =>
                {
                    b.HasOne("DummyMSRestApi.Data.UserType", "createdBy")
                        .WithMany("timeDatas")
                        .HasForeignKey("createdByid");

                    b.HasOne("DummyMSRestApi.Data.TimeFields", "fields")
                        .WithMany()
                        .HasForeignKey("fieldsid");

                    b.Navigation("createdBy");

                    b.Navigation("fields");
                });

            modelBuilder.Entity("DummyMSRestApi.Data.LineData<DummyMSRestApi.Data.TypeFields>", b =>
                {
                    b.HasOne("DummyMSRestApi.Data.UserType", "createdBy")
                        .WithMany("typeDatas")
                        .HasForeignKey("createdByid");

                    b.HasOne("DummyMSRestApi.Data.TypeFields", "fields")
                        .WithMany()
                        .HasForeignKey("fieldsid");

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
