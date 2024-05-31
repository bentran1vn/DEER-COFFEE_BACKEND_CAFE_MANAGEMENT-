using AutoMapper;
using DeerCoffeeShop.Domain.Entities;
using DeerCoffeeShop.Domain.Repositories;
using DeerCoffeeShop.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
namespace DeerCoffeeShop.Infrastructure.Repositories;

public class RoleRepository(ApplicationDbContext dbContext, IMapper mapper) : RepositoryBase<Role, Role, ApplicationDbContext>(dbContext, mapper), IRoleRepository
{
    public Task<Role?> FindRole(string Name, CancellationToken cancellationToken = default)
    {
        return dbContext.Roles.Where(x => x.Name == Name).AsNoTracking().FirstOrDefaultAsync(cancellationToken);
    }
}
