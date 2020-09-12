using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using P.C.Inftra.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace P.C.Inftra.DataAccess.Concrete.EntityFramework.Context
{


    public class ModelContext : DbContext
    {
        public ModelContext()
        {

        }
        public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
        {

        }
        public virtual DbSet<Category> Categorys { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();


            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            optionsBuilder.ConfigureWarnings(w => w.Ignore(CoreEventId.LazyLoadOnDisposedContextWarning));

        }


    }

}


