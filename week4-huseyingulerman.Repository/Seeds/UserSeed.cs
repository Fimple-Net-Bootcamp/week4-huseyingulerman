using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_huseyingulerman.Core.Entities;

namespace week4_huseyingulerman.Repository.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(new AppUser {Id="b635fc9b-9aea-41a9-b2ea-b2e98536088d",FİrstName="Hüseyin",LastName="Gülerman",UserName="huseying",Email="huseyin@gmail.com" },
            new AppUser { Id="b635fc9b-9aea-41a9-b2ea-b2e98536088e", FİrstName="Eray", LastName="Tabak", UserName="erayt", Email="Eray@gmail.com" }
            );
        }
    }
}
