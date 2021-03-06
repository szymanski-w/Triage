﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TriageApp.API.Data;

namespace TriageApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200219150204_AddedUserAndPatientEntity")]
    partial class AddedUserAndPatientEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("TriageApp.API.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CapRecurrence")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Consciousness")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsBreathing")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsWalking")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PatientName")
                        .HasColumnType("TEXT");

                    b.Property<int>("RescueOrder")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RespRate")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("TriageApp.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TriageApp.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
