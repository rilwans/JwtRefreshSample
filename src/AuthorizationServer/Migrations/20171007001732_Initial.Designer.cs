﻿// <auto-generated />
using AuthorizationServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using System;

namespace AuthorizationServer.Migrations
{
    [DbContext(typeof(AuthDbContext))]
    [Migration("20171007001732_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("AuthorizationServer.Models.Token", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("ClientId")
                        .HasColumnName("client_id");

                    b.Property<int>("IsStop")
                        .HasColumnName("is_stop");

                    b.Property<string>("RefreshToken")
                        .HasColumnName("refresh_token");

                    b.HasKey("Id");

                    b.ToTable("token");
                });
#pragma warning restore 612, 618
        }
    }
}
