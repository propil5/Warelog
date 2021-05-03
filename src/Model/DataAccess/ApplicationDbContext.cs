﻿using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.IO;
using WarelogManager.Model.DataTransfer.Warehouse;
using WarelogManager.Server.Models;

namespace WarelogManager.Server
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }

        public virtual DbSet<ProductDto> Products { get; set; }
        public virtual DbSet<CompanyDto> Companies { get; set; }
        public virtual DbSet<PalletDto> Pallets { get; set; }

        internal ApplicationDbContext CreateDbContext(object p)
        {
            throw new System.NotImplementedException();
        }

        //public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
        //{
        //    //public ApplicationDbContext CreateDbContext(string[] args)
        //    //{
        //    //    return new ApplicationDbContext();
        //    //    //IConfigurationRoot configuration = new ConfigurationBuilder()
        //    //    //    .SetBasePath(Directory.GetCurrentDirectory())
        //    //    //    .AddJsonFile(@Directory.GetCurrentDirectory() + "/../../WarelogManager/src/Serverappsettings.json")
        //    //    //    .Build();
        //    //    //var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
        //    //    //var connectionString = configuration.GetConnectionString("DatabaseConnection");
        //    //    //builder.UseSqlServer(connectionString);
        //    //    //return new ApplicationDbContext(builder.Options, new OperationalStoreOptionsMigrations());
        //    //}
        //}

        public class OperationalStoreOptionsMigrations : IOptions<OperationalStoreOptions>
        {
            public OperationalStoreOptions Value => new OperationalStoreOptions()
            {
                DeviceFlowCodes = new TableConfiguration("DeviceCodes"),
                EnableTokenCleanup = false,
                PersistedGrants = new TableConfiguration("PersistedGrants"),
                TokenCleanupBatchSize = 100,
                TokenCleanupInterval = 3600,
            };
        }
    }
}