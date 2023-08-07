﻿// <auto-generated />
using System;
using Assignment_ToDoWebApp.ToDoWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ToDoWeb.Migrations
{
    [DbContext(typeof(ToDoContext))]
    [Migration("20230807083249_ToDo Renamed CreatedDate to CompletionDate")]
    partial class ToDoRenamedCreatedDatetoCompletionDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.19");

            modelBuilder.Entity("Assignment_ToDoWebApp.ToDoWeb.Models.Entities.ToDo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CompletionDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id")
                        .HasName("PK_ToDoId");

                    b.ToTable("ToDos");
                });
#pragma warning restore 612, 618
        }
    }
}
