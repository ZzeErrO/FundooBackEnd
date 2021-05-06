﻿// <auto-generated />
using CommonLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace RepositoryLayer.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20210428114643_EFCoreCodeFirstSample.Models.UserContextSeed")]
    partial class EFCoreCodeFirstSampleModelsUserContextSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RepositoryLayer.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            Email = "uncle.bob@gmail.com",
                            FirstName = "Uncle",
                            LastName = "Bob",
                            Password = "abrakadabra"
                        },
                        new
                        {
                            UserId = 2L,
                            Email = "jan.kirsten@gmail.com",
                            FirstName = "Jan",
                            LastName = "Kirsten",
                            Password = "++LoveisLife++"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
