﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TasterNotes.Persistence;

#nullable disable

namespace TasterNotes.Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240821135505_TastingDateOptional")]
    partial class TastingDateOptional
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.7");

            modelBuilder.Entity("TasterNotes.Persistence.Models.Auth.RefreshSession", b =>
                {
                    b.Property<Guid>("RefreshSessionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpiresOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fingerprint")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.HasKey("RefreshSessionId");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshSessions");
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Dishwares.Dishware", b =>
                {
                    b.Property<Guid>("DishwareId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Kind")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Volume")
                        .HasColumnType("INTEGER");

                    b.HasKey("DishwareId");

                    b.HasIndex("UserId");

                    b.ToTable("Dishware");
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Notes.DescriptorSet", b =>
                {
                    b.Property<Guid>("NoteId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Animal")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Berry")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Bread")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Candied")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Chemical")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Citrus")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Confectionary")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Creamy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DriedFrruity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Earthy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Floral")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FreshFruity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Herbaceous")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mineral")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Mushroom")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Nutty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sea")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Spicy")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Tropical")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Vegetable")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Woody")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Yeast")
                        .HasColumnType("INTEGER");

                    b.HasKey("NoteId");

                    b.ToTable("DescriptorSet");
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Notes.Note", b =>
                {
                    b.Property<Guid>("NoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AftertasteComment")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<int>("AftertasteDuration")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AftertasteIntense")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrewingAmount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrewingDishware")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("BrewingMethod")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<int>("BrewingTemperature")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrewingVolume")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("DishwareId")
                        .HasColumnType("TEXT");

                    b.Property<string>("DryLeafAppearance")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<string>("DryLeafAroma")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImpressionComment")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<int>("ImpressionRate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InfusionAppearance")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<string>("InfusionAroma")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<int>("InfusionBalance")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InfusionBody")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InfusionBouquet")
                        .HasColumnType("INTEGER");

                    b.Property<string>("InfusionComment")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<int>("InfusionExtractivity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Kind")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("OtherComment")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateOnly?>("TastingDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("WellCombinedWith")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("TEXT");

                    b.Property<int?>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("NoteId");

                    b.HasIndex("DishwareId");

                    b.HasIndex("UserId");

                    b.ToTable("Notes");
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Notes.Taste", b =>
                {
                    b.Property<Guid>("NoteId")
                        .HasColumnType("TEXT");

                    b.Property<int>("Bitter")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Salty")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sour")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sweety")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Umami")
                        .HasColumnType("INTEGER");

                    b.HasKey("NoteId");

                    b.ToTable("Taste");
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Users.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("RemovedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("Role")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Auth.RefreshSession", b =>
                {
                    b.HasOne("TasterNotes.Persistence.Models.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Dishwares.Dishware", b =>
                {
                    b.HasOne("TasterNotes.Persistence.Models.Users.User", null)
                        .WithMany("Dishwares")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Notes.DescriptorSet", b =>
                {
                    b.HasOne("TasterNotes.Persistence.Models.Notes.Note", null)
                        .WithOne("DescriptorSet")
                        .HasForeignKey("TasterNotes.Persistence.Models.Notes.DescriptorSet", "NoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Notes.Note", b =>
                {
                    b.HasOne("TasterNotes.Persistence.Models.Dishwares.Dishware", "Dishware")
                        .WithMany()
                        .HasForeignKey("DishwareId");

                    b.HasOne("TasterNotes.Persistence.Models.Users.User", "User")
                        .WithMany("Notes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dishware");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Notes.Taste", b =>
                {
                    b.HasOne("TasterNotes.Persistence.Models.Notes.Note", null)
                        .WithOne("Taste")
                        .HasForeignKey("TasterNotes.Persistence.Models.Notes.Taste", "NoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Notes.Note", b =>
                {
                    b.Navigation("DescriptorSet")
                        .IsRequired();

                    b.Navigation("Taste")
                        .IsRequired();
                });

            modelBuilder.Entity("TasterNotes.Persistence.Models.Users.User", b =>
                {
                    b.Navigation("Dishwares");

                    b.Navigation("Notes");
                });
#pragma warning restore 612, 618
        }
    }
}
