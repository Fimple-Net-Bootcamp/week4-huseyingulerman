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
    public class PetSeed : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasData(new Pet { Id=1, AppUserId="b635fc9b-9aea-41a9-b2ea-b2e98536088d", Name="Karabaş", Species="Köpek", IsActive=true, Status=Status.Added },
                new Pet { Id=2, AppUserId="b635fc9b-9aea-41a9-b2ea-b2e98536088e", Name="Müjgan", Species="Kedi", IsActive=true, Status=Status.Added },
                 new Pet { Id=3, AppUserId="b635fc9b-9aea-41a9-b2ea-b2e98536088d", Name="Duman", Species="Papağan", IsActive=true, Status=Status.Added }
                );
        }
    }
}
