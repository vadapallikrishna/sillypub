﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sillypub;

namespace sillypub.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210605082540_CreatePlaceSchema")]
    partial class CreatePlaceSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");
            modelBuilder.Entity("sillypub.Models.Place", b => {
                b.Property<string>("Id")
                    .HasColumnType("TEXT");
                b.Property<string>("Name")
                    .HasColumnType("TEXT");
                b.Property<string>("About")
                    .HasColumnType("TEXT");
                b.Property<int>("PhoneNumber")
                    .HasColumnType("INTEGER");
                b.ToTable("Place")
            })
#pragma warning restore 612, 618
        }
    }
}
