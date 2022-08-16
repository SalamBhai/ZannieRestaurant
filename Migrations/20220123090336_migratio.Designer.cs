﻿// <auto-generated />
using System;
using Cakes_N_Treats_By_Zannie.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cakes_N_Treats_By_Zannie.Migrations
{
    [DbContext(typeof(ZannieContext))]
    [Migration("20220123090336_migratio")]
    partial class migratio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<string>("CommentContent")
                        .HasColumnType("text");

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime");

                    b.Property<int>("CommentType")
                        .HasColumnType("int");

                    b.Property<string>("ToWhomCommentIsDirected")
                        .HasColumnType("text");

                    b.Property<int?>("TreatId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TreatId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.Delivery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("DeliveryCost")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime");

                    b.Property<int>("DeliveryStatus")
                        .HasColumnType("int");

                    b.Property<int>("DispatchRiderId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAccumulatedPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("DispatchRiderId");

                    b.ToTable("Deliveries");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("datetime");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("text");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("DeliveryId")
                        .HasColumnType("int");

                    b.Property<decimal>("OrderPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("OrderReference")
                        .HasColumnType("text");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("int");

                    b.Property<bool>("PaymentPaid")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("TotalOrderQuantityOnAChosenTreat")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.TreatOrders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("TreatId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("UnitQuantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderID");

                    b.HasIndex("TreatId");

                    b.ToTable("TreatOrders");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("varchar(32)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("UserAddress")
                        .HasColumnType("text");

                    b.Property<string>("UserPhoto")
                        .HasColumnType("text");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmailAddress")
                        .IsUnique();

                    b.HasIndex("Password")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("user.Desktop.Cakes_N_Treats_By_Zannie.Entities.Treat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateofTreatregistration")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("NumberofTreatsInPack")
                        .HasColumnType("int");

                    b.Property<string>("TreatDescription")
                        .HasColumnType("text");

                    b.Property<string>("TreatPhoto")
                        .HasColumnType("text");

                    b.Property<decimal>("TreatPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Treats");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.DispatchRider", b =>
                {
                    b.HasBaseType("Cakes_N_Treats_By_Zannie.Entities.User");

                    b.HasDiscriminator().HasValue("DispatchRider");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.Comment", b =>
                {
                    b.HasOne("user.Desktop.Cakes_N_Treats_By_Zannie.Entities.Treat", "Treat")
                        .WithMany("Comments")
                        .HasForeignKey("TreatId");

                    b.HasOne("Cakes_N_Treats_By_Zannie.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Treat");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.Delivery", b =>
                {
                    b.HasOne("Cakes_N_Treats_By_Zannie.Entities.DispatchRider", "DispatchRider")
                        .WithMany("Deliveries")
                        .HasForeignKey("DispatchRiderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DispatchRider");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.Order", b =>
                {
                    b.HasOne("Cakes_N_Treats_By_Zannie.Entities.Delivery", "Delivery")
                        .WithMany("Orders")
                        .HasForeignKey("DeliveryId");

                    b.HasOne("Cakes_N_Treats_By_Zannie.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Delivery");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.TreatOrders", b =>
                {
                    b.HasOne("Cakes_N_Treats_By_Zannie.Entities.Order", "Order")
                        .WithMany("TreatOrders")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("user.Desktop.Cakes_N_Treats_By_Zannie.Entities.Treat", "Treat")
                        .WithMany("TreatOrders")
                        .HasForeignKey("TreatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Treat");
                });

            modelBuilder.Entity("user.Desktop.Cakes_N_Treats_By_Zannie.Entities.Treat", b =>
                {
                    b.HasOne("Cakes_N_Treats_By_Zannie.Entities.Category", "Category")
                        .WithMany("Treats")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.Category", b =>
                {
                    b.Navigation("Treats");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.Delivery", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.Order", b =>
                {
                    b.Navigation("TreatOrders");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("user.Desktop.Cakes_N_Treats_By_Zannie.Entities.Treat", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("TreatOrders");
                });

            modelBuilder.Entity("Cakes_N_Treats_By_Zannie.Entities.DispatchRider", b =>
                {
                    b.Navigation("Deliveries");
                });
#pragma warning restore 612, 618
        }
    }
}
