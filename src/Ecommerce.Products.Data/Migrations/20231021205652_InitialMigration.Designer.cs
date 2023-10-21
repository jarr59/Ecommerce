﻿// <auto-generated />
using Ecommerce.Products.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecommerce.Products.Data.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20231021205652_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecommerce.Products.Product", b =>
                {
                    b.Property<string>("AccountId")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Id")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Brand")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("AccountId", "Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Ecommerce.Products.Product", b =>
                {
                    b.OwnsMany("EcommerceKernel.CommonClass.Multimedia", "Multimedias", b1 =>
                        {
                            b1.Property<string>("AccountId")
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("Id")
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("MultimediaId")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("MimeType")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("Url")
                                .IsRequired()
                                .HasMaxLength(2000)
                                .HasColumnType("nvarchar(2000)");

                            b1.Property<string>("Version")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.HasKey("AccountId", "Id", "MultimediaId");

                            b1.ToTable("Multimedia");

                            b1.WithOwner()
                                .HasForeignKey("AccountId", "Id");
                        });

                    b.OwnsOne("EcommerceKernel.ValueObjects.DescriptionVo", "LargeDescription", b1 =>
                        {
                            b1.Property<string>("ProductAccountId")
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("ProductId")
                                .HasColumnType("nvarchar(50)");

                            b1.Property<int>("TextualMarkup")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(2000)
                                .HasColumnType("nvarchar(2000)");

                            b1.HasKey("ProductAccountId", "ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductAccountId", "ProductId");
                        });

                    b.OwnsMany("EcommerceKernel.ValueObjects.DynamicFieldVo", "DynamicFields", b1 =>
                        {
                            b1.Property<string>("ProductAccountId")
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("ProductId")
                                .HasColumnType("nvarchar(50)");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasMaxLength(250)
                                .HasColumnType("nvarchar(250)");

                            b1.HasKey("ProductAccountId", "ProductId", "Id");

                            b1.ToTable("DynamicFieldVo");

                            b1.WithOwner()
                                .HasForeignKey("ProductAccountId", "ProductId");
                        });

                    b.Navigation("DynamicFields");

                    b.Navigation("LargeDescription")
                        .IsRequired();

                    b.Navigation("Multimedias");
                });
#pragma warning restore 612, 618
        }
    }
}