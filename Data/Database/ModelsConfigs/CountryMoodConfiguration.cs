using Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Database.ModelsConfigs
{
    public class CountryMoodConfiguration : IEntityTypeConfiguration<CountryMood>
    {
        public void Configure(EntityTypeBuilder<CountryMood> builder)
        {
            builder
                .HasIndex(x => x.UserId)
                .IsUnique(true);
        }
    }
}
