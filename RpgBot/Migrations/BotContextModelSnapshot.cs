﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RpgBot.Context;

namespace RpgBot.Migrations
{
    [DbContext(typeof(BotContext))]
    partial class BotContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("RpgBot.Entity.Group", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("RpgBot.Entity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Experience")
                        .HasColumnType("INTEGER");

                    b.Property<string>("GroupId")
                        .HasColumnType("TEXT");

                    b.Property<int>("HealthPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ManaPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxHealthPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxManaPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxStaminaPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MessagesCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Reputation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StaminaPoints")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("RpgBot.Entity.User", b =>
                {
                    b.HasOne("RpgBot.Entity.Group", "Group")
                        .WithMany("Users")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("RpgBot.Entity.Group", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
