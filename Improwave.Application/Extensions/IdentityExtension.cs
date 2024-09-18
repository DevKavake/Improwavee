using System.Security.Claims;

namespace Improwave.Application.Extensions;

public static class IdentityExtension
{
    public static int GetUserId(this ClaimsPrincipal claimsPrincipal)
    {
        if (claimsPrincipal == null)
            return default;

        if (claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier) == null)
            return default;

        var userId = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        if (string.IsNullOrEmpty(userId))
            return default;
        return int.Parse(userId);
    }
}