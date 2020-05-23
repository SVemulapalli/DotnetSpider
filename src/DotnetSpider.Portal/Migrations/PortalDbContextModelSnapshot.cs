﻿// <auto-generated />
using System;
using DotnetSpider.Portal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotnetSpider.Portal.Migrations
{
    [DbContext(typeof(PortalDbContext))]
    partial class PortalDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DotnetSpider.Portal.Data.Spider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreationTime")
                        .HasColumnName("CREATION_TIME")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Cron")
                        .IsRequired()
                        .HasColumnName("CRON")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<bool>("Enabled")
                        .HasColumnName("ENABLED")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Environment")
                        .HasColumnName("ENVIRONMENT")
                        .HasColumnType("varchar(2000) CHARACTER SET utf8mb4")
                        .HasMaxLength(2000);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnName("IMAGE")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset>("LastModificationTime")
                        .HasColumnName("LAST_MODIFICATION_TIME")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("Volume")
                        .HasColumnName("VOLUME")
                        .HasColumnType("varchar(2000) CHARACTER SET utf8mb4")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.HasIndex("CreationTime");

                    b.HasIndex("Name");

                    b.ToTable("SPIDER");
                });

            modelBuilder.Entity("DotnetSpider.Portal.Data.SpiderHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int");

                    b.Property<string>("Batch")
                        .HasColumnName("BATCH")
                        .HasColumnType("varchar(36) CHARACTER SET utf8mb4")
                        .HasMaxLength(36);

                    b.Property<string>("ContainerId")
                        .HasColumnName("CONTAINER_ID")
                        .HasColumnType("varchar(100) CHARACTER SET utf8mb4")
                        .HasMaxLength(100);

                    b.Property<DateTimeOffset>("CreationTime")
                        .HasColumnName("CREATION_TIME")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("SpiderId")
                        .HasColumnName("SPIDER_ID")
                        .HasColumnType("int");

                    b.Property<string>("SpiderName")
                        .IsRequired()
                        .HasColumnName("SPIDER_NAME")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnName("STATUS")
                        .HasColumnType("varchar(20) CHARACTER SET utf8mb4")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("Batch");

                    b.HasIndex("CreationTime");

                    b.HasIndex("SpiderId");

                    b.ToTable("SPIDER_HISTORIES");
                });
#pragma warning restore 612, 618
        }
    }
}
