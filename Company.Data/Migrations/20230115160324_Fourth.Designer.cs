﻿// <auto-generated />
using System;
using Company.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Company.Data.Migrations
{
    [DbContext(typeof(CompanyContext))]
    [Migration("20230115160324_Fourth")]
    partial class Fourth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Company.Data.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            DepartmentName = "Engineer"
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 2,
                            DepartmentName = "RnD"
                        },
                        new
                        {
                            Id = 3,
                            CompanyId = 2,
                            DepartmentName = "Doctor"
                        },
                        new
                        {
                            Id = 4,
                            CompanyId = 1,
                            DepartmentName = "Cleaner"
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeePositionEmployeeId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeePositionPositionId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Salary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Union")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmployeePositionEmployeeId", "EmployeePositionPositionId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            FirstName = "Mario",
                            LastName = "Youssef",
                            Salary = "30000",
                            Union = true
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 3,
                            FirstName = "Johnny",
                            LastName = "Aho",
                            Salary = "40000",
                            Union = true
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 4,
                            FirstName = "Jacob",
                            LastName = "Ercan",
                            Salary = "50000",
                            Union = true
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 4,
                            FirstName = "Robin",
                            LastName = "Amoun",
                            Salary = "50000",
                            Union = false
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.EmployeePosition", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("PositionId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "PositionId");

                    b.ToTable("EmployeePositions");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            PositionId = 1
                        },
                        new
                        {
                            EmployeeId = 1,
                            PositionId = 2
                        },
                        new
                        {
                            EmployeeId = 2,
                            PositionId = 2
                        },
                        new
                        {
                            EmployeeId = 3,
                            PositionId = 4
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CompanyIdentityNumber")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Organizations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyIdentityNumber = 123456,
                            CompanyName = "Tesla"
                        },
                        new
                        {
                            Id = 2,
                            CompanyIdentityNumber = 654321,
                            CompanyName = "Apple"
                        });
                });

            modelBuilder.Entity("Company.Data.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PositionName = "Doctor"
                        },
                        new
                        {
                            Id = 2,
                            PositionName = "Engineer"
                        },
                        new
                        {
                            Id = 3,
                            PositionName = "CEO"
                        },
                        new
                        {
                            Id = 4,
                            PositionName = "RnD"
                        });
                });

            modelBuilder.Entity("DepartmentOrganization", b =>
                {
                    b.Property<int>("DepartmentsId")
                        .HasColumnType("int");

                    b.Property<int>("OrganizationsId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsId", "OrganizationsId");

                    b.HasIndex("OrganizationsId");

                    b.ToTable("DepartmentOrganization");
                });

            modelBuilder.Entity("EmployeePositionPosition", b =>
                {
                    b.Property<int>("PositionsId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeePositionsEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeePositionsPositionId")
                        .HasColumnType("int");

                    b.HasKey("PositionsId", "EmployeePositionsEmployeeId", "EmployeePositionsPositionId");

                    b.HasIndex("EmployeePositionsEmployeeId", "EmployeePositionsPositionId");

                    b.ToTable("EmployeePositionPosition");
                });

            modelBuilder.Entity("Company.Data.Entities.Department", b =>
                {
                    b.HasOne("Company.Data.Entities.Department", null)
                        .WithMany("Departments")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("Company.Data.Entities.Employee", b =>
                {
                    b.HasOne("Company.Data.Entities.EmployeePosition", null)
                        .WithMany("Employees")
                        .HasForeignKey("EmployeePositionEmployeeId", "EmployeePositionPositionId");
                });

            modelBuilder.Entity("DepartmentOrganization", b =>
                {
                    b.HasOne("Company.Data.Entities.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company.Data.Entities.Organization", null)
                        .WithMany()
                        .HasForeignKey("OrganizationsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeePositionPosition", b =>
                {
                    b.HasOne("Company.Data.Entities.Position", null)
                        .WithMany()
                        .HasForeignKey("PositionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Company.Data.Entities.EmployeePosition", null)
                        .WithMany()
                        .HasForeignKey("EmployeePositionsEmployeeId", "EmployeePositionsPositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Company.Data.Entities.Department", b =>
                {
                    b.Navigation("Departments");
                });

            modelBuilder.Entity("Company.Data.Entities.EmployeePosition", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
