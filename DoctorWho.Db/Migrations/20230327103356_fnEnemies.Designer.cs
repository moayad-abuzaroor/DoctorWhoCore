﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20230327103356_fnEnemies")]
    partial class fnEnemies
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DoctorWho.Db.Functions.fnCompanionClass", b =>
                {
                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("fnCompanionClass");
                });

            modelBuilder.Entity("DoctorWho.Db.Functions.fnEnemiesClass", b =>
                {
                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("fnEnemiesClass");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("AuthorId");

                    b.ToTable("tblAuthor");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Anthony Coburn"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Terry Nation"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "David Whitaker"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "John Lucarotti"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Peter R. Newman"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"));

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("CompanionId");

                    b.ToTable("tblCompanion");

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Susan Foreman",
                            WhoPlayed = "Carole Ann Ford"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "Barbara Wright",
                            WhoPlayed = "Jacqueline Hill"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Ian Chesterton",
                            WhoPlayed = "William Russell"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Vicki",
                            WhoPlayed = "Maureen O'Brien"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Steven Taylor",
                            WhoPlayed = "Peter Purves"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("DoctorNumber")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("tblDoctor");

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1908, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "William Hartnell",
                            DoctorNumber = "1",
                            FirstEpisodeDate = new DateTime(1963, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1966, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1920, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Patrick Troughton",
                            DoctorNumber = "2",
                            FirstEpisodeDate = new DateTime(1966, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1969, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1919, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Jon Pertwee",
                            DoctorNumber = "3",
                            FirstEpisodeDate = new DateTime(1970, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1974, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1934, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Tom Baker",
                            DoctorNumber = "4",
                            FirstEpisodeDate = new DateTime(1974, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1981, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(1982, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Jodie Whittaker",
                            DoctorNumber = "5",
                            FirstEpisodeDate = new DateTime(2018, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("EnemyId");

                    b.ToTable("tblEnemy");

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "It landed here way back in the 9th century. After a long; deadly battle; The Dalek was defeated. It’s casing was destroyed; the creature inside was cut into three pieces so it could never reform. Two were successfully transported away and guarded by the order of the custodians. But one piece was left behind. It stayed in Sheffield; where it was found 12 centuries later and was accidentally woken up. You would think a squiddy thing like that couldn’t get far. But turns out it could hitch a ride on humans. It built it’s own casing from spare parts and bits of it’s original outer shell.",
                            EnemyName = "Daleks"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "Krasko was released from prison and travelled back in time to change the past.",
                            EnemyName = "Krasko"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "A mythical Pictish Beast; discovered by the Doctor to be all too real…",
                            EnemyName = "The Eaters of Light"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "A malevolent cyborg known for ending battles by eating his enemies dead or alive. Don’t lose your head!",
                            EnemyName = "Hydroflax"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "A maitre d’ who can make any problem disappear. Even if he has to digest passengers himself.",
                            EnemyName = "Flemming"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("tblEpisode");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Classic",
                            Notes = "",
                            SeriesNumber = 1,
                            Title = "An Unearthly Child (An Unearthly Child - Part One)"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 1,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(1963, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Classic",
                            Notes = "",
                            SeriesNumber = 1,
                            Title = "The Cave of Skulls (An Unearthly Child - Part Two)"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2020, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Revised",
                            Notes = "",
                            SeriesNumber = 2,
                            Title = "The Timeless Children"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 2,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Revised",
                            Notes = "",
                            SeriesNumber = 2,
                            Title = "Ascension of the Cybermen"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 2,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Special",
                            Notes = "",
                            SeriesNumber = 3,
                            Title = "Revolution of the Daleks"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeCompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeCompanionId"));

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeCompanionId");

                    b.HasIndex("CompanionId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("tblEpisodeCompanion");

                    b.HasData(
                        new
                        {
                            EpisodeCompanionId = 1,
                            CompanionId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 2,
                            CompanionId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 3,
                            CompanionId = 2,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeCompanionId = 4,
                            CompanionId = 2,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeCompanionId = 5,
                            CompanionId = 3,
                            EpisodeId = 1
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeEnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeEnemyId"));

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeEnemyId");

                    b.HasIndex("EnemyId");

                    b.HasIndex("EpisodeId");

                    b.ToTable("tblEpisodeEnemy");

                    b.HasData(
                        new
                        {
                            EpisodeEnemyId = 1,
                            EnemyId = 1,
                            EpisodeId = 1
                        },
                        new
                        {
                            EpisodeEnemyId = 2,
                            EnemyId = 1,
                            EpisodeId = 2
                        },
                        new
                        {
                            EpisodeEnemyId = 3,
                            EnemyId = 2,
                            EpisodeId = 3
                        },
                        new
                        {
                            EpisodeEnemyId = 4,
                            EnemyId = 3,
                            EpisodeId = 4
                        },
                        new
                        {
                            EpisodeEnemyId = 5,
                            EnemyId = 5,
                            EpisodeId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Models.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Doctor", "Doctor")
                        .WithMany()
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Companion", "Companion")
                        .WithMany()
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Models.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Db.Models.Enemy", "Enemy")
                        .WithMany()
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Models.Episode", "Episode")
                        .WithMany()
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });
#pragma warning restore 612, 618
        }
    }
}
