using portfolio_Authentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio_Authentication.Servies
{
    public interface IAuthenticateServies
    {
        string Authenticate(int CustomerId, string Password);
    }
}
