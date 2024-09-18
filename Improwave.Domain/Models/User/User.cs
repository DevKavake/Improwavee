using System.Diagnostics.SymbolStore;
using Improwave.Domain.Models.Common;

namespace Improwave.Domain.Models.User;

public class User:BaseEntity<int>
{
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public bool IsAdmin { get; set; } = false;
}