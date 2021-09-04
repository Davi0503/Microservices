using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization.Api.Service
{
    public interface ILoginService
    {
        string GenerateToken();
    }
}
