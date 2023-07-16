﻿// <auto-generated />
using System;
using DiyetGunlugu.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiyetGunlugu.DAL.Migrations
{
    [DbContext(typeof(DiyetGunlugu_DbContext))]
    [Migration("20230627153835_ver1")]
    partial class ver1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.EatingMeal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EatingMealTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MealTime")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserID")
                        .HasColumnType("int");

                    b.Property<int>("Piece")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("ServingID")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UserInformationID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ServingID");

                    b.HasIndex("UserInformationID");

                    b.ToTable("EatingMeals");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.Foods", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Carbohydrate")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserID")
                        .HasColumnType("int");

                    b.Property<float>("Fat")
                        .HasColumnType("real");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("FoofPicture")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserID")
                        .HasColumnType("int");

                    b.Property<float>("Protein")
                        .HasColumnType("real");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfFoodsID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TypeOfFoodsID");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.Servings", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserID")
                        .HasColumnType("int");

                    b.Property<int>("FoodID")
                        .HasColumnType("int");

                    b.Property<int>("MeasurementType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserID")
                        .HasColumnType("int");

                    b.Property<int>("ServingGrams")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("FoodID");

                    b.ToTable("Serving");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.TypeOfFoods", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserID")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfFood")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TypeOfFoods");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("ActivationCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FirstLogin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserID")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.UserInformation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ActivityLevel")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserID")
                        .HasColumnType("int");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<byte>("Height")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserID")
                        .HasColumnType("int");

                    b.Property<string>("NameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<byte>("TargetWeight")
                        .HasColumnType("tinyint");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("UserInformations");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.WeightChange", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreateUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeletedUserID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedUserID")
                        .HasColumnType("int");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserInformationID")
                        .HasColumnType("int");

                    b.Property<int>("weight")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserInformationID");

                    b.ToTable("WeightChanges");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.EatingMeal", b =>
                {
                    b.HasOne("DiyetGunlugu.MODEL.Entity.Servings", "Serving")
                        .WithMany("EatingMeals")
                        .HasForeignKey("ServingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiyetGunlugu.MODEL.Entity.UserInformation", "UserInformation")
                        .WithMany("EatingMeals")
                        .HasForeignKey("UserInformationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Serving");

                    b.Navigation("UserInformation");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.Foods", b =>
                {
                    b.HasOne("DiyetGunlugu.MODEL.Entity.TypeOfFoods", "TypeOfFood")
                        .WithMany("Foods")
                        .HasForeignKey("TypeOfFoodsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeOfFood");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.Servings", b =>
                {
                    b.HasOne("DiyetGunlugu.MODEL.Entity.Foods", "Food")
                        .WithMany("Servings")
                        .HasForeignKey("FoodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.UserInformation", b =>
                {
                    b.HasOne("DiyetGunlugu.MODEL.Entity.User", "User")
                        .WithMany("UserInformation")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.WeightChange", b =>
                {
                    b.HasOne("DiyetGunlugu.MODEL.Entity.UserInformation", "UserInformation")
                        .WithMany("WeightChanges")
                        .HasForeignKey("UserInformationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserInformation");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.Foods", b =>
                {
                    b.Navigation("Servings");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.Servings", b =>
                {
                    b.Navigation("EatingMeals");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.TypeOfFoods", b =>
                {
                    b.Navigation("Foods");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.User", b =>
                {
                    b.Navigation("UserInformation");
                });

            modelBuilder.Entity("DiyetGunlugu.MODEL.Entity.UserInformation", b =>
                {
                    b.Navigation("EatingMeals");

                    b.Navigation("WeightChanges");
                });
#pragma warning restore 612, 618
        }
    }
}
