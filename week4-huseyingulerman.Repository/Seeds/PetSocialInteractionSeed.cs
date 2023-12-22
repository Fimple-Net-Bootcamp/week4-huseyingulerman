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
    public class PetSocialInteractionSeed : IEntityTypeConfiguration<SocialInteractionPet>
    {
        public void Configure(EntityTypeBuilder<SocialInteractionPet> builder)
        {
            builder.HasData(new SocialInteractionPet
            {
                Id= 1,
                PetId= 1,
                SocialInteractionId= 1,
                IsActive=true,
                Status=Status.Added
            },
            new SocialInteractionPet
            {
                Id= 2,
                PetId= 1,
                SocialInteractionId= 4,
                IsActive=true,
                Status=Status.Added
            },
            new SocialInteractionPet
            {
                Id= 3,
                PetId= 2,
                SocialInteractionId= 2,
                IsActive=true,
                Status=Status.Added
            },
            new SocialInteractionPet
            {
                Id= 4,
                PetId= 2,
                SocialInteractionId= 4,
                IsActive=true,
                Status=Status.Added
            },
            new SocialInteractionPet
            {
                Id= 5,
                PetId= 3,
                SocialInteractionId= 3,
                IsActive=true,
                Status=Status.Added
            },
            new SocialInteractionPet
            {
                Id= 6,
                PetId= 3,
                SocialInteractionId= 4,
                IsActive=true,
                Status=Status.Added
            });
        }
    }
}
