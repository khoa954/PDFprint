﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PDFprint.Data;

#nullable disable

namespace PDFprint.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240108030117_UpdateCONGNOTHEOTHANGdtb")]
    partial class UpdateCONGNOTHEOTHANGdtb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PDFprint.Models.CHITIETCONGNO", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("CONGNOTHEOTHANGId")
                        .HasColumnType("int");

                    b.Property<string>("DIENGIAI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KENHPHANPHOI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NGAYCHUNGTU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHATSINHGIAM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PHATSINHTANG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SOCHUNGTU")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CONGNOTHEOTHANGId");

                    b.ToTable("CHITIETCONGNO");
                });

            modelBuilder.Entity("PDFprint.Models.CONGNOTHEOTHANG", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("ChiNhanh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CongNoConLai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CongNoConLaiTheoChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CongNoThangTruoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NgayKhaiTruong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaiKhoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TongPhatSinhGiam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TongPhatSinhTang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("CONGNOTHEOTHANG");
                });

            modelBuilder.Entity("PDFprint.Models.MAKH", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("MAKH");
                });

            modelBuilder.Entity("PDFprint.Models.CHITIETCONGNO", b =>
                {
                    b.HasOne("PDFprint.Models.CONGNOTHEOTHANG", "CONGNOTHEOTHANG")
                        .WithMany()
                        .HasForeignKey("CONGNOTHEOTHANGId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CONGNOTHEOTHANG");
                });
#pragma warning restore 612, 618
        }
    }
}
