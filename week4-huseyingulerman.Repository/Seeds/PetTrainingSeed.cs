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
    public class PetTrainingSeed : IEntityTypeConfiguration<PetTraining>
    {
        public void Configure(EntityTypeBuilder<PetTraining> builder)
        {
            builder.HasData(new PetTraining
            {
                Id= 1,
                PetId= 1,
                TrainingId= 1,
                IsActive=true,
                Status=Status.Added
            },
            new PetTraining
            {
                Id= 2,
                PetId= 2,
                TrainingId= 1,
                IsActive=true,
                Status=Status.Added
            },
            new PetTraining
            {
                Id= 3,
                PetId= 3,
                TrainingId= 1,
                IsActive=true,
                Status=Status.Added
            },
            new PetTraining
            {
                Id= 4,
                PetId= 3,
                TrainingId= 2,
                IsActive=true,
                Status=Status.Added
            });
        }
    }
}
