﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoFinalMVCCore.Data;

#nullable disable

namespace ProjetoFinalMVCCore.Migrations
{
    [DbContext(typeof(EFContext))]
    [Migration("20220523164924_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjetoFinalMVCCore.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("cargaHoraria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cursoId")
                        .HasColumnType("int");

                    b.Property<string>("materia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nivel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome_curso");

                    b.Property<int>("valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("cursoId");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("ProjetoFinalMVCCore.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("formacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("nome_professor");

                    b.HasKey("Id");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("ProjetoFinalMVCCore.Models.Curso", b =>
                {
                    b.HasOne("ProjetoFinalMVCCore.Models.Curso", "curso")
                        .WithMany()
                        .HasForeignKey("cursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("curso");
                });
#pragma warning restore 612, 618
        }
    }
}
