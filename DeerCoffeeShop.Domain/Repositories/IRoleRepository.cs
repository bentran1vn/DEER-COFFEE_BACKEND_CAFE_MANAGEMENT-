using DeerCoffeeShop.Domain.Entities;

namespace DeerCoffeeShop.Domain.Repositories;

public interface IRoleRepository : IEFRepository<Role, Role>
{
    Task<Role?> FindRole(string Name, CancellationToken cancellationToken = default);
}
