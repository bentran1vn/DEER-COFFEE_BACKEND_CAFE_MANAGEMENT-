using AutoMapper;
using DeerCoffeeShop.Domain.Entities;
using DeerCoffeeShop.Domain.Repositories;
using DeerCoffeeShop.Infrastructure.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Infrastructure.Repositories;

public class EmployeeRepository(ApplicationDbContext dbContext, IMapper mapper) : RepositoryBase<Employee, Employee, ApplicationDbContext>(dbContext, mapper), IEmployeeRepository
{
    public bool VerifyPassword(string password, string hash)
    => BCrypt.Net.BCrypt.Verify(password, hash);


    public string HashPassword(string password)
    => BCrypt.Net.BCrypt.HashPassword(password);

    public Task<Employee> FindUser(int ID, CancellationToken cancellationToken = default)
    {
        return dbContext.Employees.Where(x => x.EmployeeID == ID).AsNoTracking().FirstOrDefaultAsync(cancellationToken);
    }
}
