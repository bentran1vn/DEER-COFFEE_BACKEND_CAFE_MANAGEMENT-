using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeerCoffeeShop.Domain.Common.Exception;

public class IncorrectPasswordException(string message) : System.Exception(message)
{
}
