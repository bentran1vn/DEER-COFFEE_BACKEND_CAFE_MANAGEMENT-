using AutoMapper;
using DeerCoffeeShop.Domain.Entities;
using DeerCoffeeShop.Domain.Repositories;
using DeerCoffeeShop.Infrastructure.Persistence.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Infrastructure.Repositories
{
    public class ShiftRepository(ApplicationDbContext context, IMapper mapper) : RepositoryBase<Shift, Shift, ApplicationDbContext>(context, mapper), IShiftRepostiry
    {
    }
}
