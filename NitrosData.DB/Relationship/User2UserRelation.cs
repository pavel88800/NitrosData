 using System;
using System.Collections.Generic;
using System.Text;
 using Microsoft.EntityFrameworkCore;
 using Microsoft.EntityFrameworkCore.Metadata.Builders;
 using NitrosData.DB.Models;

 namespace NitrosData.DB.Relationship
{
    class User2UserRelation : IEntityTypeConfiguration<UsersUsers>
    {
        public void Configure(EntityTypeBuilder<UsersUsers> builder)
        {
            builder.HasKey(x => new { x.User1Id, x.User2Id });

            builder
                .HasOne(x => x.User1)
                .WithMany()
                .HasForeignKey(k => k.User1Id)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasOne(x => x.User2)
                .WithMany()
                .HasForeignKey(k => k.User2Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
