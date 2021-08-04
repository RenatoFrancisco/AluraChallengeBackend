using AluraChallengeBackend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AluraChallengeBackend.Data.Mappings
{
    public class VideoMapping : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.ToTable("Videos");
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Title).HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(v => v.Description).HasColumnType("VARCHAR(500)").IsRequired();
            builder.Property(v => v.Url).HasColumnType("VARCHAR(500)").IsRequired();
        }
    }
}