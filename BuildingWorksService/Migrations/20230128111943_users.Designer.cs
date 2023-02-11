﻿// <auto-generated />
using System;
using BuildingWorks.Databasable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace BuildingWorksService.Migrations
{
    [DbContext(typeof(BuildingWorksDbContext))]
    [Migration("20230128111943_users")]
    partial class users
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.ObjectAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("StreetId")
                        .HasColumnType("int");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.HasIndex("StreetId");

                    b.HasIndex("TownId");

                    b.ToTable("ObjectAddress");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.RegionId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.StreetId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TownId");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.TownId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<string>("TownId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.BuildingObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ObjectCustomer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ObjectName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ObjectType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("RegionId")
                        .HasColumnType("int");

                    b.Property<int>("StreetId")
                        .HasColumnType("int");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RegionId");

                    b.HasIndex("StreetId");

                    b.HasIndex("TownId");

                    b.ToTable("BuildingObject");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Plans.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CompleteTime")
                        .HasColumnType("datetime(6)");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(65,30)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("ObjectId")
                        .HasColumnType("int");

                    b.Property<string>("PathToImage")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ObjectId");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Plans.PlanDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PlanId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<string>("WorkPart")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.ToTable("PlansDetails");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Providers.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Conditions")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProviderId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Provides.ContractsByMaterials", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BuildingObjectId")
                        .HasColumnType("int");

                    b.Property<int>("ContractId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuildingObjectId");

                    b.HasIndex("ContractId");

                    b.HasIndex("MaterialId");

                    b.ToTable("ContractsByMaterials");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Provides.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Measure")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("PricePerOne")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Provides.Provider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AdditionalData")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Registration.UnregisteredUserCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UnregisteredUsersCodes");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Registration.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Workers.BrigadeId", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BrigadierId")
                        .HasColumnType("int");

                    b.Property<int>("ObjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrigadierId")
                        .IsUnique();

                    b.HasIndex("ObjectId");

                    b.ToTable("Brigades");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Workers.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BrigadeId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("StartWorkDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("WorkerPost")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("BrigadeId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Workers.WorkerSalary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<float>("BaseSalary")
                        .HasColumnType("float");

                    b.Property<int>("ChildrenCount")
                        .HasColumnType("int");

                    b.Property<float>("Experience")
                        .HasColumnType("float");

                    b.Property<float>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<int>("WorkedDays")
                        .HasColumnType("int");

                    b.Property<int>("WorkerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkerId");

                    b.ToTable("WorkersSalaries");
                });

            modelBuilder.Entity("ContractMaterial", b =>
                {
                    b.Property<int>("ContractsId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialsId")
                        .HasColumnType("int");

                    b.HasKey("ContractsId", "MaterialsId");

                    b.HasIndex("MaterialsId");

                    b.ToTable("ContractMaterial");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.ObjectAddress", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.RegionId", "RegionId")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.StreetId", "StreetId")
                        .WithMany()
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.TownId", "TownId")
                        .WithMany()
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegionId");

                    b.Navigation("StreetId");

                    b.Navigation("TownId");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.StreetId", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.TownId", "TownId")
                        .WithMany("Streets")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TownId");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.TownId", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.RegionId", "RegionId")
                        .WithMany("Towns")
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegionId");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.BuildingObject", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.RegionId", "RegionId")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.StreetId", "StreetId")
                        .WithMany()
                        .HasForeignKey("StreetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.TownId", "TownId")
                        .WithMany()
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegionId");

                    b.Navigation("StreetId");

                    b.Navigation("TownId");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Plans.Plan", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.BuildingObject", "BuildingObject")
                        .WithMany()
                        .HasForeignKey("ObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BuildingObject");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Plans.PlanDetail", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Plans.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Providers.Contract", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Provides.Provider", "Provider")
                        .WithMany("Contracts")
                        .HasForeignKey("ProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Provider");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Provides.ContractsByMaterials", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.BuildingObject", "BuildingObject")
                        .WithMany("Contracts")
                        .HasForeignKey("BuildingObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Providers.Contract", "Contract")
                        .WithMany()
                        .HasForeignKey("ContractId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Provides.Material", "Material")
                        .WithMany()
                        .HasForeignKey("MaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BuildingObject");

                    b.Navigation("Contract");

                    b.Navigation("Material");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Workers.BrigadeId", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Workers.Worker", "Brigadier")
                        .WithOne("BrigadeId")
                        .HasForeignKey("BuildingWorks.Models.Databasable.Tables.Workers.BrigadeId", "BrigadierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.BuildingObject", "BuildingObject")
                        .WithMany()
                        .HasForeignKey("ObjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brigadier");

                    b.Navigation("BuildingObject");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Workers.Worker", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Workers.BrigadeId", null)
                        .WithMany("Workers")
                        .HasForeignKey("BrigadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Workers.WorkerSalary", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Workers.Worker", "Worker")
                        .WithMany("WorkersSalaries")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("ContractMaterial", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Providers.Contract", null)
                        .WithMany()
                        .HasForeignKey("ContractsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Provides.Material", null)
                        .WithMany()
                        .HasForeignKey("MaterialsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.RegionId", b =>
                {
                    b.Navigation("Towns");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.TownId", b =>
                {
                    b.Navigation("Streets");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.BuildingObject", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Provides.Provider", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Workers.BrigadeId", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Workers.Worker", b =>
                {
                    b.Navigation("BrigadeId")
                        .IsRequired();

                    b.Navigation("WorkersSalaries");
                });
#pragma warning restore 612, 618
        }
    }
}
