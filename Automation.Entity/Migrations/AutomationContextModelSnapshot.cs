﻿// <auto-generated />
using System;
using Automation.Entity.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Automation.Entity.Migrations
{
    [DbContext(typeof(AutomationContext))]
    partial class AutomationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Automation.Entity.Models.Actions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("CaseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTimeFinishing")
                        .HasColumnType("dateTime2");

                    b.Property<DateTime>("DateTimeStarting")
                        .HasColumnType("dateTime2");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<bool>("Result")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.ToTable("Actions", (string)null);
                });

            modelBuilder.Entity("Automation.Entity.Models.Cases", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Contents")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("dateTime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cases", (string)null);
                });

            modelBuilder.Entity("Automation.Entity.Models.Actions", b =>
                {
                    b.HasOne("Automation.Entity.Models.Cases", "Cases")
                        .WithMany("Actions")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cases");
                });

            modelBuilder.Entity("Automation.Entity.Models.Cases", b =>
                {
                    b.Navigation("Actions");
                });
#pragma warning restore 612, 618
        }
    }
}
