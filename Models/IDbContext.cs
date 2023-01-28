﻿using BuildingWorks.Models.Databasable.Tables.BuildingObjects;
using BuildingWorks.Models.Databasable.Tables.BuildingObjects.Address;
using BuildingWorks.Models.Databasable.Tables.Plans;
using BuildingWorks.Models.Databasable.Tables.Provides;
using Microsoft.EntityFrameworkCore;
using BuildingWorks.Models.Databasable.Tables.Registration;
using BuildingWorks.Models.Databasable.Tables.Workers;
using BuildingWorks.Models.Databasable.Tables.Providers;

namespace Models.Contexts
{
    public interface IDbContext
    {
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<ContractsByMaterials> ContractsByMaterials { get; set; }
        public DbSet<BuildingObject> BuildingObject { get; set; }
        public DbSet<ObjectAddress> ObjectAddress { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanDetail> PlansDetails { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UnregisteredUserCode> UnregisteredUsersCodes { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Brigade> Brigades { get; set; }
        public DbSet<WorkerSalary> WorkersSalaries { get; set; }
    }
}
