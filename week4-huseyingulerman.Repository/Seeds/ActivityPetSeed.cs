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
    public class ActivityPetSeed : IEntityTypeConfiguration<ActivityPet>
    {
        public void Configure(EntityTypeBuilder<ActivityPet> builder)
        {
            builder.HasData(new ActivityPet
            {
                Id= 1,
                ActivityId= 1,
                PetId= 1,
                IsActive= true,
                Status=Status.Added
            },
            new ActivityPet
            {
                Id= 2,
                ActivityId= 2,
                PetId= 2,
                IsActive= true,
                Status=Status.Added
            }
            );
        }
    }
}
