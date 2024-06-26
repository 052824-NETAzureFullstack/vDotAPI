﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using songAPI.Data;

#nullable disable

namespace songAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("songAPI.Models.Album", b =>
                {
                    b.Property<int>("AlbumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AlbumId"));

                    b.Property<int?>("ArtistId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlbumId");

                    b.HasIndex("ArtistId");

                    b.ToTable("Albums", (string)null);
                });

            modelBuilder.Entity("songAPI.Models.Artist", b =>
                {
                    b.Property<int>("ArtistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ArtistId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtistId");

                    b.ToTable("Artists", (string)null);
                });

            modelBuilder.Entity("songAPI.Models.Title", b =>
                {
                    b.Property<int>("songId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("songId"));

                    b.Property<int>("albumId")
                        .HasColumnType("int");

                    b.Property<int>("artistId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("releaseDate")
                        .HasColumnType("date");

                    b.Property<string>("titleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("songId");

                    b.HasIndex("albumId");

                    b.HasIndex("artistId");

                    b.ToTable("Titles", (string)null);
                });

            modelBuilder.Entity("songAPI.Models.Album", b =>
                {
                    b.HasOne("songAPI.Models.Artist", null)
                        .WithMany("Discography")
                        .HasForeignKey("ArtistId");
                });

            modelBuilder.Entity("songAPI.Models.Title", b =>
                {
                    b.HasOne("songAPI.Models.Album", null)
                        .WithMany("trackList")
                        .HasForeignKey("albumId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("songAPI.Models.Artist", null)
                        .WithMany("trackList")
                        .HasForeignKey("artistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("songAPI.Models.Album", b =>
                {
                    b.Navigation("trackList");
                });

            modelBuilder.Entity("songAPI.Models.Artist", b =>
                {
                    b.Navigation("Discography");

                    b.Navigation("trackList");
                });
#pragma warning restore 612, 618
        }
    }
}
