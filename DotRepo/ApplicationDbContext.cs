using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotRepo
{
    public class ApplicationDbContext<T> : DbContext, IDataLoader<T> where T : class, IModel
    {
        private readonly IOptions<DataMappingOption> _mappingOptions;

        public DbSet<T> Data { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext<T>> options, IOptions<DataMappingOption> mappingOptions) : base(options)
        {
            _mappingOptions = mappingOptions ?? throw new ArgumentNullException("Missing data mapping configuration");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T>(entity =>
            {
                entity.ToTable(_mappingOptions.Value.TableName);

                foreach (var item in _mappingOptions.Value.PropertyMap)
                {
                    entity.Property(item.Key).HasColumnName(item.Value);
                }

                entity.HasKey(_mappingOptions.Value.Keys);

            });
        }

        public IList<T> GetData()
        {
            return Data.ToList<T>();
        }
    }
}
