using DeerCoffeeShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Domain.Repositories;

public interface IEmployeeRepository : IEFRepository<Employee, Employee>
{
    string HashPassword(string password);
    bool VerifyPassword(string password, string hash);

    Task<Employee> FindUser(int ID, CancellationToken cancellationToken = default);
}
