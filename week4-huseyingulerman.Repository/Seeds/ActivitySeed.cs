using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.Entities;
using week4_huseyingulerman.Core.Enums;

namespace week4_huseyingulerman.Repository.Seeds
{
    public class ActivitySeed : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasData(new Activity
            {
                Id=1,
                Name="Koşmak",
                IsActive=true,
                Status=Status.Added
            },
            new Activity
            {
                Id=2,
                Name="Yürümek",
                IsActive=true,
                Status=Status.Added
            }
            );
        }
    }
}
