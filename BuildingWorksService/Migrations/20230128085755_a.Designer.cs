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
    [Migration("20230128085755_a")]
    partial class a
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.ObjectAddress", b =>
                {
                    b.Property<int>("AddressCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RegionCode")
                        .HasColumnType("int");

                    b.Property<int>("StreetCode")
                        .HasColumnType("int");

                    b.Property<int>("TownCode")
                        .HasColumnType("int");

                    b.HasKey("AddressCode");

                    b.HasIndex("RegionCode");

                    b.HasIndex("StreetCode");

                    b.HasIndex("TownCode");

                    b.ToTable("ObjectAddress");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.RegionId", b =>
                {
                    b.Property<int>("RegionCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RegionCode");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.StreetId", b =>
                {
                    b.Property<int>("StreetCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("TownCode")
                        .HasColumnType("int");

                    b.HasKey("StreetCode");

                    b.HasIndex("TownCode");

                    b.ToTable("Streets");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.TownId", b =>
                {
                    b.Property<int>("TownCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("RegionCode")
                        .HasColumnType("int");

                    b.Property<string>("TownId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("TownCode");

                    b.HasIndex("RegionCode");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.BuildingObject", b =>
                {
                    b.Property<int>("ObjectId")
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

                    b.Property<int>("RegionCode")
                        .HasColumnType("int");

                    b.Property<int>("StreetCode")
                        .HasColumnType("int");

                    b.Property<int>("TownCode")
                        .HasColumnType("int");

                    b.HasKey("ObjectId");

                    b.HasIndex("RegionCode");

                    b.HasIndex("StreetCode");

                    b.HasIndex("TownCode");

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

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Provides.Contract", b =>
                {
                    b.Property<int>("ContractCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Conditions")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProviderId")
                        .HasColumnType("int");

                    b.HasKey("ContractCode");

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
                    b.Property<int>("MaterialCode")
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

                    b.HasKey("MaterialCode");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Provides.Provider", b =>
                {
                    b.Property<int>("ProviderCode")
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

                    b.HasKey("ProviderCode");

                    b.ToTable("Providers");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Registration.UnregisteredUserCode", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.ToTable("UnregisteredUsersCodes");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Registration.User", b =>
                {
                    b.Property<int>("UserCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserCode");

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
                    b.Property<int>("ContractsContractCode")
                        .HasColumnType("int");

                    b.Property<int>("MaterialsMaterialCode")
                        .HasColumnType("int");

                    b.HasKey("ContractsContractCode", "MaterialsMaterialCode");

                    b.HasIndex("MaterialsMaterialCode");

                    b.ToTable("ContractMaterial");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.ObjectAddress", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.RegionId", "RegionId")
                        .WithMany()
                        .HasForeignKey("RegionCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.StreetId", "StreetId")
                        .WithMany()
                        .HasForeignKey("StreetCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.TownId", "TownId")
                        .WithMany()
                        .HasForeignKey("TownCode")
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
                        .HasForeignKey("TownCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TownId");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.TownId", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.RegionId", "RegionId")
                        .WithMany("Towns")
                        .HasForeignKey("RegionCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RegionId");
                });

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.BuildingObjects.BuildingObject", b =>
                {
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.RegionId", "RegionId")
                        .WithMany()
                        .HasForeignKey("RegionCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.StreetId", "StreetId")
                        .WithMany()
                        .HasForeignKey("StreetCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address.TownId", "TownId")
                        .WithMany()
                        .HasForeignKey("TownCode")
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

            modelBuilder.Entity("BuildingWorks.Models.Databasable.Tables.Provides.Contract", b =>
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

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Provides.Contract", "Contract")
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
                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Provides.Contract", null)
                        .WithMany()
                        .HasForeignKey("ContractsContractCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BuildingWorks.Models.Databasable.Tables.Provides.Material", null)
                        .WithMany()
                        .HasForeignKey("MaterialsMaterialCode")
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
