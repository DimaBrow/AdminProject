using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using AdminProject.Models;
using AdminProject.Entities;

namespace AdminProject.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20170502194217_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AdminProject.Entities.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("AdminLevel");

                    b.Property<int>("Age");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("AdminProject.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("AdminId");

                    b.Property<int>("Age");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FlatNumber")
                        .IsRequired();

                    b.Property<string>("HouseNumber")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AdminProject.Entities.UserTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int?>("AdminId");

                    b.Property<int>("Category");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("UserId");

                    b.ToTable("UserTasks");
                });

            modelBuilder.Entity("AdminProject.Entities.User", b =>
                {
                    b.HasOne("AdminProject.Entities.Admin")
                        .WithMany("ListOfUsers")
                        .HasForeignKey("AdminId");
                });

            modelBuilder.Entity("AdminProject.Entities.UserTask", b =>
                {
                    b.HasOne("AdminProject.Entities.Admin")
                        .WithMany("ListOfTasks")
                        .HasForeignKey("AdminId");

                    b.HasOne("AdminProject.Entities.User")
                        .WithMany("ListOfTasks")
                        .HasForeignKey("UserId");
                });
        }
    }
}
