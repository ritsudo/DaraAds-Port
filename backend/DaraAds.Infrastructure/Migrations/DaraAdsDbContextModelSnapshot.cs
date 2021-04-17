﻿using System;
using DaraAds.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DaraAds.Infrastructure.Migrations
{
    [DbContext(typeof(DaraAdsDbContext))]
    partial class DaraAdsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("DaraAds.Domain.Abuse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AbuseAdvId")
                        .HasColumnType("integer");

                    b.Property<string>("AbuseText")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("AuthorId")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Priority")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("RemovedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Abuses");
                });

            modelBuilder.Entity("DaraAds.Domain.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Cover")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<DateTime?>("RemovedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Advertisements");
                });

            modelBuilder.Entity("DaraAds.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(true)
                        .HasColumnType("character varying(256)");

                    b.Property<int?>("ParentCategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("RemovedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ParentCategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Транспорт"
                        },
                        new
                        {
                            Id = 200,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Недвижимость"
                        },
                        new
                        {
                            Id = 300,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Бытовая Техника"
                        },
                        new
                        {
                            Id = 400,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Животные"
                        },
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Автомобили",
                            ParentCategoryId = 100
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Мотоциклы",
                            ParentCategoryId = 100
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Спецтехника",
                            ParentCategoryId = 100
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Запчасти",
                            ParentCategoryId = 100
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Квартиры",
                            ParentCategoryId = 200
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Дома",
                            ParentCategoryId = 200
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Новостройки",
                            ParentCategoryId = 200
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Гаражи",
                            ParentCategoryId = 200
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Участки",
                            ParentCategoryId = 200
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Аудио и видео",
                            ParentCategoryId = 300
                        },
                        new
                        {
                            Id = 11,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Игры, приставки",
                            ParentCategoryId = 300
                        },
                        new
                        {
                            Id = 12,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Компьютеры",
                            ParentCategoryId = 300
                        },
                        new
                        {
                            Id = 13,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Ноутбуки",
                            ParentCategoryId = 300
                        },
                        new
                        {
                            Id = 14,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Телефоны, планшеты",
                            ParentCategoryId = 300
                        },
                        new
                        {
                            Id = 15,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Фототехника",
                            ParentCategoryId = 300
                        },
                        new
                        {
                            Id = 16,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Собаки",
                            ParentCategoryId = 400
                        },
                        new
                        {
                            Id = 17,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Кошки",
                            ParentCategoryId = 400
                        },
                        new
                        {
                            Id = 18,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Птицы",
                            ParentCategoryId = 400
                        },
                        new
                        {
                            Id = 19,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Аквариум",
                            ParentCategoryId = 400
                        },
                        new
                        {
                            Id = 20,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Товары для животных",
                            ParentCategoryId = 400
                        });
                });

            modelBuilder.Entity("DaraAds.Domain.Favorite", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AdvertisementId");

                    modelBuilder.Entity("DaraAds.Domain.Image", b =>
                   {
                       b.Property<string>("Id")
                           .HasColumnType("text");

                       b.Property<int?>("AdvertisementId")
                           .HasColumnType("integer");

                       b.Property<DateTime>("CreatedDate")
                           .HasColumnType("timestamp without time zone");
                       b.Property<byte[]>("ImageBlob")
                           .HasColumnType("bytea");

                       b.Property<string>("Name")
                           .HasColumnType("text");

                       b.Property<DateTime?>("RemovedDate")
                           .HasColumnType("timestamp without time zone");

                       b.Property<DateTime?>("UpdatedDate")
                           .HasColumnType("timestamp without time zone");

                       b.Property<string>("UserId")
                           .HasColumnType("text");

                       b.HasKey("Id");

                       b.HasIndex("AdvertisementId");

                       b.HasIndex("UserId");
                       b.ToTable("Favorites");
                       b.ToTable("Image");
                   });

                    modelBuilder.Entity("DaraAds.Domain.User", b =>
                        {
                            b.Property<string>("Id")
                                .HasColumnType("text");

                            b.Property<string>("Avatar")
                                .HasColumnType("text");

                            b.Property<DateTime>("CreatedDate")
                                .HasColumnType("timestamp without time zone");

                            b.Property<string>("Email")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)");

                            b.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(256)
                                .IsUnicode(true)
                                .HasColumnType("character varying(256)");

                            b.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(256)
                                .IsUnicode(true)
                                .HasColumnType("character varying(256)");

                            b.Property<string>("Phone")
                                .HasMaxLength(12)
                                .HasColumnType("character varying(12)");

                            b.Property<DateTime?>("RemovedDate")
                                .HasColumnType("timestamp without time zone");

                            b.Property<DateTime?>("UpdatedDate")
                                .HasColumnType("timestamp without time zone");

                            b.Property<string>("Username")
                                .IsRequired()
                                .HasMaxLength(30)
                                .HasColumnType("character varying(30)");

                            b.HasKey("Id");

                            b.ToTable("DomainUsers");
                        });

                    modelBuilder.Entity("DaraAds.Infrastructure.Identity.IdentityUser", b =>
                        {
                            b.Property<string>("Id")
                                .HasColumnType("text");

                            b.Property<int>("AccessFailedCount")
                                .HasColumnType("integer");

                            b.Property<string>("ConcurrencyStamp")
                                .IsConcurrencyToken()
                                .HasColumnType("text");

                            b.Property<string>("Email")
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)");

                            b.Property<bool>("EmailConfirmed")
                                .HasColumnType("boolean");

                            b.Property<bool>("LockoutEnabled")
                                .HasColumnType("boolean");

                            b.Property<DateTimeOffset?>("LockoutEnd")
                                .HasColumnType("timestamp with time zone");

                            b.Property<string>("NormalizedEmail")
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)");

                            b.Property<string>("NormalizedUserName")
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)");

                            b.Property<string>("PasswordHash")
                                .HasColumnType("text");

                            b.Property<string>("PhoneNumber")
                                .HasColumnType("text");

                            b.Property<bool>("PhoneNumberConfirmed")
                                .HasColumnType("boolean");

                            b.Property<string>("SecurityStamp")
                                .HasColumnType("text");

                            b.Property<bool>("TwoFactorEnabled")
                                .HasColumnType("boolean");

                            b.Property<string>("UserName")
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)");

                            b.HasKey("Id");

                            b.HasIndex("NormalizedEmail")
                                .HasDatabaseName("EmailIndex");

                            b.HasIndex("NormalizedUserName")
                                .IsUnique()
                                .HasDatabaseName("UserNameIndex");

                            b.ToTable("AspNetUsers");

                            b.HasData(
                                new
                                {
                                    Id = "e4266faa-8fc0-4972-bf1c-14533f1ccffd",
                                    AccessFailedCount = 0,
                                    ConcurrencyStamp = "2cec64a3-83af-43e4-b910-91fbf8d31748",
                                    Email = "admin",
                                    EmailConfirmed = true,
                                    LockoutEnabled = false,
                                    NormalizedUserName = "ADMIN",
                                    PasswordHash = "AQAAAAEAACcQAAAAEJ80DBjL0/gTUd1St35E1MTnsVecNwI3WZNjIJe5lw7TAyApA0CZ3e6+tMOq8/RIWg==",
                                    PhoneNumberConfirmed = false,
                                    SecurityStamp = "6db823b5-e1ab-4d1d-b41f-bcccb9f8d6b9",
                                    TwoFactorEnabled = false,
                                    UserName = "admin"
                                });
                        });

                    modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                        {
                            b.Property<string>("Id")
                                .HasColumnType("text");

                            b.Property<string>("ConcurrencyStamp")
                                .IsConcurrencyToken()
                                .HasColumnType("text");

                            b.Property<string>("Name")
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)");

                            b.Property<string>("NormalizedName")
                                .HasMaxLength(256)
                                .HasColumnType("character varying(256)");

                            b.HasKey("Id");

                            b.HasIndex("NormalizedName")
                                .IsUnique()
                                .HasDatabaseName("RoleNameIndex");

                            b.ToTable("AspNetRoles");

                            b.HasData(
                                new
                                {
                                    Id = "7ca197bb-d569-4fb9-b214-7f719973050e",
                                    ConcurrencyStamp = "0b3e25bb-f11f-472c-8a40-05c5dccdf39e",
                                    Name = "Admin",
                                    NormalizedName = "ADMIN"
                                },
                                new
                                {
                                    Id = "b09f2dce-4821-4cf3-aa27-37f9d920bc01",

                                    ConcurrencyStamp = "bb4d1e3c-0ff4-4272-9457-5130364e2314",
                                    Name = "User",
                                    NormalizedName = "USER"
                                },
                                new
                                {
                                    Id = "E8E08651-ED1B-468E-A931-F73E2563CD85",
                                    ConcurrencyStamp = "b0c1d982-f368-43e8-9a51-e9fd6a744850",
                                    Name = "Moderator",
                                    NormalizedName = "MODERATOR"
                                });
                        });

                    modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                        {
                            b.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b.Property<string>("ClaimType")
                                .HasColumnType("text");

                            b.Property<string>("ClaimValue")
                                .HasColumnType("text");

                            b.Property<string>("RoleId")
                                .IsRequired()
                                .HasColumnType("text");

                            b.HasKey("Id");

                            b.HasIndex("RoleId");

                            b.ToTable("AspNetRoleClaims");
                        });

                    modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                        {
                            b.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer")
                                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                            b.Property<string>("ClaimType")
                                .HasColumnType("text");

                            b.Property<string>("ClaimValue")
                                .HasColumnType("text");

                            b.Property<string>("UserId")
                                .IsRequired()
                                .HasColumnType("text");

                            b.HasKey("Id");

                            b.HasIndex("UserId");

                            b.ToTable("AspNetUserClaims");
                        });

                    modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                        {
                            b.Property<string>("LoginProvider")
                                .HasColumnType("text");

                            b.Property<string>("ProviderKey")
                                .HasColumnType("text");

                            b.Property<string>("ProviderDisplayName")
                                .HasColumnType("text");

                            b.Property<string>("UserId")
                                .IsRequired()
                                .HasColumnType("text");

                            b.HasKey("LoginProvider", "ProviderKey");

                            b.HasIndex("UserId");

                            b.ToTable("AspNetUserLogins");
                        });

                    modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                        {
                            b.Property<string>("UserId")
                                .HasColumnType("text");

                            b.Property<string>("RoleId")
                                .HasColumnType("text");

                            b.HasKey("UserId", "RoleId");

                            b.HasIndex("RoleId");

                            b.ToTable("AspNetUserRoles");

                            b.HasData(
                                new
                                {
                                    UserId = "e4266faa-8fc0-4972-bf1c-14533f1ccffd",
                                    RoleId = "7ca197bb-d569-4fb9-b214-7f719973050e"
                                });
                        });

                    modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                        {
                            b.Property<string>("UserId")
                                .HasColumnType("text");

                            b.Property<string>("LoginProvider")
                                .HasColumnType("text");

                            b.Property<string>("Name")
                                .HasColumnType("text");

                            b.Property<string>("Value")
                                .HasColumnType("text");

                            b.HasKey("UserId", "LoginProvider", "Name");

                            b.ToTable("AspNetUserTokens");
                        });

                    modelBuilder.Entity("DaraAds.Domain.Advertisement", b =>
                        {
                            b.HasOne("DaraAds.Domain.Category", "Category")
                                .WithMany()
                                .HasForeignKey("CategoryId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b.HasOne("DaraAds.Domain.User", "OwnerUser")
                                .WithMany()
                                .HasForeignKey("OwnerId");

                            b.Navigation("Category");

                            b.Navigation("OwnerUser");
                        });

                    modelBuilder.Entity("DaraAds.Domain.Category", b =>
                        {
                            b.HasOne("DaraAds.Domain.Category", "ParentCategory")
                                .WithMany("ChildCategories")
                                .HasForeignKey("ParentCategoryId")
                                .OnDelete(DeleteBehavior.Restrict);

                            b.Navigation("ParentCategory");
                        });

                    modelBuilder.Entity("DaraAds.Domain.Favorite", b =>
                        {
                            b.HasOne("DaraAds.Domain.Advertisement", "Advertisement")
                                .WithMany()
                                .HasForeignKey("AdvertisementId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b.HasOne("DaraAds.Domain.User", "User")
                                .WithMany("Favorites");
                            modelBuilder.Entity("DaraAds.Domain.Image", b =>
                        {
                            b.HasOne("DaraAds.Domain.Advertisement", "Advertisement")
                                .WithMany("Images")
                                .HasForeignKey("AdvertisementId");

                            b.HasOne("DaraAds.Domain.User", "User")
                                .WithMany("Images")
                                .HasForeignKey("UserId");

                            b.Navigation("Advertisement");

                            b.Navigation("User");
                        });

                            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                        {
                            b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                                .WithMany()
                                .HasForeignKey("RoleId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();
                        });

                            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                        {
                            b.HasOne("DaraAds.Infrastructure.Identity.IdentityUser", null)
                                .WithMany()
                                .HasForeignKey("UserId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();
                        });

                            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                        {
                            b.HasOne("DaraAds.Infrastructure.Identity.IdentityUser", null)
                                .WithMany()
                                .HasForeignKey("UserId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();
                        });

                            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                        {
                            b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                                .WithMany()
                                .HasForeignKey("RoleId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b.HasOne("DaraAds.Infrastructure.Identity.IdentityUser", null)
                                .WithMany()
                                .HasForeignKey("UserId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();
                        });

                            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                        {
                            b.HasOne("DaraAds.Infrastructure.Identity.IdentityUser", null)
                                .WithMany()
                                .HasForeignKey("UserId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();
                        });

                            modelBuilder.Entity("DaraAds.Domain.Advertisement", b =>
                        {
                            b.Navigation("Images");
                        });

                            modelBuilder.Entity("DaraAds.Domain.Category", b =>
                        {
                            b.Navigation("ChildCategories");
                        });

                            modelBuilder.Entity("DaraAds.Domain.User", b =>
                        {
                            b.Navigation("Favorites");
                            b.Navigation("Images");
                        });
                        });
                });
        }
    }
}
