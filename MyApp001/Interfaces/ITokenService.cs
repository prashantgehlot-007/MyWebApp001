using MyApp001.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp001.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
