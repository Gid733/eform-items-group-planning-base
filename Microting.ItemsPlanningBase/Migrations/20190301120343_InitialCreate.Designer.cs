﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microting.ItemsPlanningBase.Infrastucture.Data;

namespace Microting.ItemsPlanningBase.Migrations
{
    [DbContext(typeof(ItemsPlanningPnDbContext))]
    [Migration("20190301120343_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            string autoIDGenStrategy = "SqlServer:ValueGenerationStrategy";
            object autoIDGenStrategyValue = SqlServerValueGenerationStrategy.IdentityColumn;
            if (DbConfig.IsMySQL)
            {
                autoIDGenStrategy = "MySql:ValueGenerationStrategy";
                autoIDGenStrategyValue = MySqlValueGenerationStrategy.IdentityColumn;
            }
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

            modelBuilder.Entity("Microting.ItemsPlanningBase.Infrastucture.Data.Entities.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Description");

                    b.Property<bool>("Enabled");

                    b.Property<int>("ItemListId");

                    b.Property<string>("Name");

                    b.Property<string>("RepeatType");

                    b.Property<string>("Sku");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("ItemListId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Microting.ItemsPlanningBase.Infrastucture.Data.Entities.ItemCase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("ItemId");

                    b.Property<int>("SdkCaseId");

                    b.Property<int>("SdkSiteId");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.Property<int>("eFomrId");

                    b.HasKey("Id");

                    b.ToTable("ItemCases");
                });

            modelBuilder.Entity("Microting.ItemsPlanningBase.Infrastucture.Data.Entities.ItemCaseVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<int>("ItemCaseId");

                    b.Property<int>("SdkCaseId");

                    b.Property<int>("SdkSiteId");

                    b.Property<int>("Status");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.Property<int>("eFomrId");

                    b.HasKey("Id");

                    b.ToTable("ItemCaseVersions");
                });

            modelBuilder.Entity("Microting.ItemsPlanningBase.Infrastucture.Data.Entities.ItemLIst", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Description");

                    b.Property<bool>("Enabled");

                    b.Property<string>("Name");

                    b.Property<int>("RelatedeFormId");

                    b.Property<string>("RelatedeFormName");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ItemLists");
                });

            modelBuilder.Entity("Microting.ItemsPlanningBase.Infrastucture.Data.Entities.ItemListVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Description");

                    b.Property<bool>("Enabled");

                    b.Property<int>("ItemList");

                    b.Property<string>("Name");

                    b.Property<int>("RelatedeFormId");

                    b.Property<string>("RelatedeFormName");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ItemListVersions");
                });

            modelBuilder.Entity("Microting.ItemsPlanningBase.Infrastucture.Data.Entities.ItemVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Description");

                    b.Property<bool>("Enabled");

                    b.Property<int>("ItemId");

                    b.Property<string>("Name");

                    b.Property<string>("RepeatType");

                    b.Property<string>("Sku");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ItemVersions");
                });

            modelBuilder.Entity("Microting.ItemsPlanningBase.Infrastucture.Data.Entities.ItemsPlanningPnSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ItemsPlanningPnSettings");
                });

            modelBuilder.Entity("Microting.ItemsPlanningBase.Infrastucture.Data.Entities.ItemsPlanningPnSettingVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation(autoIDGenStrategy, autoIDGenStrategyValue);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<int>("CreatedByUserId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("TrashInspectionPnSettingId");

                    b.Property<DateTime?>("UpdatedAt");

                    b.Property<int>("UpdatedByUserId");

                    b.Property<string>("Value");

                    b.Property<int>("Version");

                    b.Property<string>("WorkflowState")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("ItemsPlanningPnSettingVersions");
                });

            modelBuilder.Entity("Microting.ItemsPlanningBase.Infrastucture.Data.Entities.Item", b =>
                {
                    b.HasOne("Microting.ItemsPlanningBase.Infrastucture.Data.Entities.ItemLIst")
                        .WithMany("Items")
                        .HasForeignKey("ItemListId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
