﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using WLab1.Data;

namespace Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Web.Models.Doctor", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Name");

                b.Property<string>("Speciality");

                b.HasKey("Id");

                b.ToTable("Doctors");
            });

            modelBuilder.Entity("Web.Models.Hospital", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Address");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(200);

                b.HasKey("Id");

                b.ToTable("Hospitals");
            });

            modelBuilder.Entity("Web.Models.HospitalDoctor", b =>
            {
                b.Property<int>("HospitalId");

                b.Property<int>("DoctorId");

                b.HasKey("HospitalId", "DoctorId");

                b.HasIndex("DoctorId");

                b.ToTable("HospitalDoctors");
            });

            modelBuilder.Entity("Web.Models.HospitalLab", b =>
            {
                b.Property<int>("HospitalId");

                b.Property<int>("LabId");

                b.HasKey("HospitalId", "LabId");

                b.HasIndex("LabId");

                b.ToTable("HospitalLabs");
            });

            modelBuilder.Entity("Web.Models.HospitalPhone", b =>
            {
                b.Property<int>("HospitalId");

                b.Property<int>("PhoneId");

                b.Property<string>("Number")
                    .IsRequired()
                    .HasMaxLength(20);

                b.HasKey("HospitalId", "PhoneId");

                b.ToTable("HospitalPhones");
            });

            modelBuilder.Entity("Web.Models.Lab", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Address");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(200);

                b.HasKey("Id");

                b.ToTable("Labs");
            });

            modelBuilder.Entity("Web.Models.LabPhone", b =>
            {
                b.Property<int>("LabId");

                b.Property<int>("PhoneId");

                b.Property<string>("Number")
                    .IsRequired()
                    .HasMaxLength(20);

                b.HasKey("LabId", "PhoneId");

                b.ToTable("LabPhones");
            });

            modelBuilder.Entity("Web.Models.Placement", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int>("Bed");

                b.Property<int>("WardId");

                b.HasKey("Id");

                b.HasIndex("WardId");

                b.ToTable("Placements");
            });

            modelBuilder.Entity("Web.Models.Ward", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<int>("HospitalId");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(200);

                b.HasKey("Id");

                b.HasIndex("HospitalId");

                b.ToTable("Wards");
            });

            modelBuilder.Entity("Web.Models.WardStaff", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<string>("Name");

                b.Property<string>("Position");

                b.Property<int>("WardId");

                b.HasKey("Id");

                b.HasIndex("WardId");

                b.ToTable("WardStaff");
            });

            modelBuilder.Entity("Web.Models.HospitalDoctor", b =>
            {
                b.HasOne("Web.Models.Doctor", "Doctor")
                    .WithMany("Hospitals")
                    .HasForeignKey("DoctorId")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("Web.Models.Hospital", "Hospital")
                    .WithMany("Doctors")
                    .HasForeignKey("HospitalId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Web.Models.HospitalLab", b =>
            {
                b.HasOne("Web.Models.Hospital", "Hospital")
                    .WithMany("Labs")
                    .HasForeignKey("HospitalId")
                    .OnDelete(DeleteBehavior.Cascade);

                b.HasOne("Web.Models.Lab", "Lab")
                    .WithMany("Hospitals")
                    .HasForeignKey("LabId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Web.Models.HospitalPhone", b =>
            {
                b.HasOne("Web.Models.Hospital", "Hospital")
                    .WithMany("Phones")
                    .HasForeignKey("HospitalId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Web.Models.LabPhone", b =>
            {
                b.HasOne("Web.Models.Lab", "Lab")
                    .WithMany("Phones")
                    .HasForeignKey("LabId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Web.Models.Placement", b =>
            {
                b.HasOne("Web.Models.Ward", "Ward")
                    .WithMany("Placements")
                    .HasForeignKey("WardId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Web.Models.Ward", b =>
            {
                b.HasOne("Web.Models.Hospital", "Hospital")
                    .WithMany("Wards")
                    .HasForeignKey("HospitalId")
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity("Web.Models.WardStaff", b =>
            {
                b.HasOne("Web.Models.Ward", "Ward")
                    .WithMany("WardStaffs")
                    .HasForeignKey("WardId")
                    .OnDelete(DeleteBehavior.Cascade);
            });
#pragma warning restore 612, 618
        }
    }
}