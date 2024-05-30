namespace DeerCoffeeShop.Domain.Entities.Base
{
    public class RefreshToken
    {
        public required string Token { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Expired { get; set; }

    }
}
