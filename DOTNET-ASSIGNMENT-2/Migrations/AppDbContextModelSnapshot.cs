﻿// <auto-generated />
using DOTNET_ASSIGNMENT_2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DOTNET_ASSIGNMENT_2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DOTNET_ASSIGNMENT_2.Models.Department", b =>
                {
                    b.Property<int>("Dept_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Dept_Id"));

                    b.Property<string>("Dept_Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Dept_Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("DOTNET_ASSIGNMENT_2.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<int>("Dept_Id")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int>("Salary")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Dept_Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DOTNET_ASSIGNMENT_2.Models.Employee", b =>
                {
                    b.HasOne("DOTNET_ASSIGNMENT_2.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("Dept_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
