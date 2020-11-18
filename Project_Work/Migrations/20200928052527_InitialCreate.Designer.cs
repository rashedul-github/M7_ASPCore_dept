﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_Work.Models;

namespace Project_Work.Migrations
{
    [DbContext(typeof(DepartmentDbContext))]
    [Migration("20200928052527_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project_Work.Models.ContactualStaff", b =>
                {
                    b.Property<int>("ContactualStaffId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactualStaffName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<int>("DepartmentId");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<decimal>("WeeklySalary")
                        .HasColumnType("money");

                    b.HasKey("ContactualStaffId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("ContactualStaffs");
                });

            modelBuilder.Entity("Project_Work.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Project_Work.Models.PermanentStaff", b =>
                {
                    b.Property<int>("PermanentStaffId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("date");

                    b.Property<decimal>("MonthlySalary")
                        .HasColumnType("money");

                    b.Property<string>("PermanentStaffName")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.HasKey("PermanentStaffId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("PermanentStaffs");
                });

            modelBuilder.Entity("Project_Work.Models.ContactualStaff", b =>
                {
                    b.HasOne("Project_Work.Models.Department", "department")
                        .WithMany("contactualStaff")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Project_Work.Models.PermanentStaff", b =>
                {
                    b.HasOne("Project_Work.Models.Department", "department")
                        .WithMany("permanentStaff")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}