using Domain.History;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mapping
{
    public class HistoryMapping : IEntityTypeConfiguration<History>
    {
        public void Configure(EntityTypeBuilder<History> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.MysteryNumber)
                .IsRequired();

            builder.Property(x => x.GuessedNumber)
                .IsRequired();

            builder.Property(x => x.Turn)
                .IsRequired();

            builder.Property(x => x.DatePlayed)
                .IsRequired();
        }
    }
}
