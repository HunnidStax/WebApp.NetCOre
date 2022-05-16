using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using System;
using System.Collections.Generic;
using Timesheets.Responces;

namespace Timesheets.Services.ServInterfaces
{
    public interface IService
    {
        TokenResponse Authenticate(string user, string password);
        string RefreshToken(string token);
    }
}
