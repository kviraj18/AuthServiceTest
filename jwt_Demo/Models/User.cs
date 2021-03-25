using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio_Authentication.Models
{
    public class User
    {
        public int CustomerId { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }


    }
}
