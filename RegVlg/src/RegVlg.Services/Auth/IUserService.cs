using System.Collections.Generic;
using System.Security.Claims;

namespace RegVlg.Services.Auth
{
    public interface IUserService
    {
        ClaimsPrincipal GetClaimsPrincipal(string userName, IEnumerable<string> roles = null);
    }
}
