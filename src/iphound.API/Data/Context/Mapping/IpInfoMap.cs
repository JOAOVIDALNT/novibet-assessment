using iphound.API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iphound.API.Data.Context.Mapping;

public class IpInfoMap : IEntityTypeConfiguration<IpInfo>
{
    public void Configure(EntityTypeBuilder<IpInfo> builder)
    {
        builder.ToTable("IpInfos")
            .HasKey(x => x.Id);
        
        builder.Property(x => x.CountryName).IsRequired().HasMaxLength(100);
        builder.Property(x => x.TwoLetterCode).IsRequired().HasMaxLength(2).IsFixedLength();
        builder.Property(x => x.ThreeLetterCode).IsRequired().HasMaxLength(3).IsFixedLength();
    }
}