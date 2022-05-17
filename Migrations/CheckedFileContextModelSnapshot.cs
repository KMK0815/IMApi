﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Protronic.CeckedFileInfo;

#nullable disable

namespace IMApi.Migrations
{
    [DbContext(typeof(CheckedFileContext))]
    partial class CheckedFileContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0-preview.4.22229.2");

            modelBuilder.Entity("Protronic.CeckedFileInfo.ConversionInfo", b =>
                {
                    b.Property<string>("ConveretedFilePath")
                        .HasColumnType("TEXT");

                    b.Property<string>("BackgroundColor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ConversionName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Label")
                        .HasColumnType("TEXT");

                    b.Property<string>("OriginalFileFileName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Type")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("ConveretedFilePath");

                    b.HasIndex("OriginalFileFileName");

                    b.ToTable("Conversions");
                });

            modelBuilder.Entity("Protronic.CeckedFileInfo.ConvertedFile", b =>
                {
                    b.Property<string>("WebURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConversionConveretedFilePath")
                        .HasColumnType("TEXT");

                    b.Property<uint>("FileCrc")
                        .HasColumnType("INTEGER");

                    b.Property<long>("FileLength")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FileType")
                        .HasColumnType("TEXT");

                    b.Property<string>("OriginalFileFileName")
                        .HasColumnType("TEXT");

                    b.HasKey("WebURL");

                    b.HasIndex("ConversionConveretedFilePath");

                    b.HasIndex("OriginalFileFileName");

                    b.ToTable("ConvertedFiles");
                });

            modelBuilder.Entity("Protronic.CeckedFileInfo.OriginalFile", b =>
                {
                    b.Property<string>("FileName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Artikelnummer")
                        .HasColumnType("TEXT");

                    b.Property<uint>("FileCrc")
                        .HasColumnType("INTEGER");

                    b.Property<long>("FileLength")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileType")
                        .HasColumnType("TEXT");

                    b.Property<string>("WebURL")
                        .HasColumnType("TEXT");

                    b.Property<int>("lang")
                        .HasColumnType("INTEGER");

                    b.HasKey("FileName");

                    b.ToTable("OriginalFiles");
                });

            modelBuilder.Entity("Protronic.CeckedFileInfo.ConversionInfo", b =>
                {
                    b.HasOne("Protronic.CeckedFileInfo.OriginalFile", null)
                        .WithMany("Conversions")
                        .HasForeignKey("OriginalFileFileName");
                });

            modelBuilder.Entity("Protronic.CeckedFileInfo.ConvertedFile", b =>
                {
                    b.HasOne("Protronic.CeckedFileInfo.ConversionInfo", "Conversion")
                        .WithMany()
                        .HasForeignKey("ConversionConveretedFilePath");

                    b.HasOne("Protronic.CeckedFileInfo.OriginalFile", null)
                        .WithMany("ConvertedFiles")
                        .HasForeignKey("OriginalFileFileName");

                    b.Navigation("Conversion");
                });

            modelBuilder.Entity("Protronic.CeckedFileInfo.OriginalFile", b =>
                {
                    b.Navigation("Conversions");

                    b.Navigation("ConvertedFiles");
                });
#pragma warning restore 612, 618
        }
    }
}
