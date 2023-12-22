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
    public class TrainingSeed : IEntityTypeConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.HasData(new Training
            {
                Id= 1,
                Name="Toilet",
                Price=100,
                IsActive=true,
                Status=Status.Added
            },
            new Training
            {
                Id= 2,
                Name="Speaking",
                Price=500,
                IsActive=true,
                Status=Status.Added
            });
        }
    }
}
