﻿// <auto-generated />
using System;
using ControleChamadosRedeSuporte.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleChamadosRedeSuporte.Migrations
{
    [DbContext(typeof(CCRSContext))]
    [Migration("20190428170507_OtherEntities")]
    partial class OtherEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ControleChamadosRedeSuporte.Models.Chamado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DescProblema");

                    b.Property<int?>("FuncionarioId");

                    b.Property<int?>("SolicitanteId");

                    b.Property<int>("Status");

                    b.Property<string>("Tel");

                    b.Property<int?>("TipoProblemaId");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("SolicitanteId");

                    b.HasIndex("TipoProblemaId");

                    b.ToTable("Chamado");
                });

            modelBuilder.Entity("ControleChamadosRedeSuporte.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("GraduacaoId");

                    b.Property<string>("Name");

                    b.Property<int>("Rg");

                    b.Property<int>("Tipo");

                    b.Property<int?>("UnidadeId");

                    b.HasKey("Id");

                    b.HasIndex("GraduacaoId");

                    b.HasIndex("UnidadeId");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("ControleChamadosRedeSuporte.Models.Graduacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Grad");

                    b.HasKey("Id");

                    b.ToTable("Graduacao");
                });

            modelBuilder.Entity("ControleChamadosRedeSuporte.Models.TipoProblema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Problema");

                    b.HasKey("Id");

                    b.ToTable("TipoProblema");
                });

            modelBuilder.Entity("ControleChamadosRedeSuporte.Models.Unidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Unidade");
                });

            modelBuilder.Entity("ControleChamadosRedeSuporte.Models.Chamado", b =>
                {
                    b.HasOne("ControleChamadosRedeSuporte.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");

                    b.HasOne("ControleChamadosRedeSuporte.Models.Funcionario", "Solicitante")
                        .WithMany()
                        .HasForeignKey("SolicitanteId");

                    b.HasOne("ControleChamadosRedeSuporte.Models.TipoProblema", "TipoProblema")
                        .WithMany("Chamados")
                        .HasForeignKey("TipoProblemaId");
                });

            modelBuilder.Entity("ControleChamadosRedeSuporte.Models.Funcionario", b =>
                {
                    b.HasOne("ControleChamadosRedeSuporte.Models.Graduacao", "Graduacao")
                        .WithMany("Funcionarios")
                        .HasForeignKey("GraduacaoId");

                    b.HasOne("ControleChamadosRedeSuporte.Models.Unidade", "Unidade")
                        .WithMany("Funcionarios")
                        .HasForeignKey("UnidadeId");
                });
#pragma warning restore 612, 618
        }
    }
}
