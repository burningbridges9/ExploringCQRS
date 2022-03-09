using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfiguration
{
    internal class TrackConfiguration : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Title).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Description).HasMaxLength(100);
        }
    }
}
