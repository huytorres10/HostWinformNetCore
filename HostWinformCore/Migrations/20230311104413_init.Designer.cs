﻿// <auto-generated />
using HostWinformCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HostWinformCore.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20230311104413_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("HostWinformCore.Config", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Name")
                        .HasColumnName("Name")
                        .HasColumnType("INTEGER")
                        .HasMaxLength(20);

                    b.Property<int>("Note")
                        .HasColumnName("Note")
                        .HasColumnType("INTEGER")
                        .HasMaxLength(200);

                    b.Property<int>("Value")
                        .HasColumnName("Value")
                        .HasColumnType("INTEGER")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Config");
                });
#pragma warning restore 612, 618
        }
    }
}
