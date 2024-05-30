using DeerCoffeeShop.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeerCoffeeShop.Infrastructure.Persistence.Configurations
{
    internal class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasOne(r => r.RestaurantChain)
                .WithMany()
                .HasForeignKey(r => r.RestaurantChainID)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
