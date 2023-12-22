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
    public class FoodSeed : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasData(new Food { Id=1, Calory=100, Name="Köpek Maması", IsActive=true, Status=Status.Added, }, new Food { Id=2, Calory=200, Name="Kedi Maması", IsActive=true, Status=Status.Added, });
        }
    }
}
