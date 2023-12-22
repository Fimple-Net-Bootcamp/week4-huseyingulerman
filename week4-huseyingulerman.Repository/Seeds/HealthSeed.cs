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
    public class HealthSeed : IEntityTypeConfiguration<Health>
    {
        public void Configure(EntityTypeBuilder<Health> builder)
        {
            builder.HasData(new Health
            {
                Id= 1,Situation="İyi",PetId=1,IsActive=true,Status=Status.Added
            },
            new Health
            {
                Id= 2,
                Situation="Kötü",
                PetId=2,
                IsActive=true,
                Status=Status.Added
            },
            new Health
            {
                Id= 3,
                Situation="Orta",
                PetId=1,
                IsActive=true,
                Status=Status.Added
            },
            new Health
            {
                Id= 4,
                Situation="Orta-İyi",
                PetId=2,
                IsActive=true,
                Status=Status.Added
            },
                new Health
                {
                    Id= 5,
                    Situation="Mükemmel",
                    PetId=3,
                    IsActive=true,
                    Status=Status.Added
                }
            );
        }
    }
}
