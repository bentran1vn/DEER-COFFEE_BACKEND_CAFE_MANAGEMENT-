using DeerCoffeeShop.Domain.Entities;

namespace DeerCoffeeShop.Domain.Repositories;

public interface IEmployeeRepository : IEFRepository<Employee, Employee>
{
    string HashPassword(string password);
    bool VerifyPassword(string password, string hash);

    Task<Employee> FindUser(int ID, CancellationToken cancellationToken = default);
}
