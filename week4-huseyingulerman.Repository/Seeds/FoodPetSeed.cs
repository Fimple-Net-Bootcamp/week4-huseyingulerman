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
    public class FoodPetSeed : IEntityTypeConfiguration<FoodPet>
    {
        public void Configure(EntityTypeBuilder<FoodPet> builder)
        {
            builder.HasData(new FoodPet
            {
                Id = 1,
                FoodId = 1,
                PetId = 1,
                IsActive= true,
                Status=Status.Added
            },
            new FoodPet
            {
                Id = 2,
                FoodId = 2,
                PetId = 2,
                IsActive= true,
                Status=Status.Added
            }
            );
        }
    }
}
