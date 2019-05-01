﻿// <auto-generated />
using ControleChamadosRedeSuporte.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleChamadosRedeSuporte.Migrations
{
    [DbContext(typeof(CCRSContext))]
    [Migration("20190427165339_Graduacao")]
    partial class Graduacao
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ControleChamadosRedeSuporte.Models.Graduacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Grad");

                    b.HasKey("Id");

                    b.ToTable("Graduacao");
                });

            modelBuilder.Entity("ControleChamadosRedeSuporte.Models.Unidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Unidade");
                });
#pragma warning restore 612, 618
        }
    }
}
