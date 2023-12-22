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
    public class SocialInteractionSeed : IEntityTypeConfiguration<SocialInteraction>
    {
        public void Configure(EntityTypeBuilder<SocialInteraction> builder)
        {
            builder.HasData(new SocialInteraction
            {
                Id= 1,
                Name="DogShower",
                IsActive=true,
                Place="Cafe",
                Status=Status.Added
            },
            new SocialInteraction
            {
                Id= 2,
                Name="CatShower",
                IsActive=true,
                Place="Cafe",
                Status=Status.Added
            },
            new SocialInteraction
            {
                Id= 3,
                Name="ParrotDay",
                IsActive=true,
                Place="Cafe",
                Status=Status.Added
            },
            new SocialInteraction
            {
                Id= 4,
                Name="GameDay",
                IsActive=true,
                Place="Cafe",
                Status=Status.Added
            }
            );
        }
    }
}
