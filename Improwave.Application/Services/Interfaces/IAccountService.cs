using Improwave.Domain.Interfaces;
using Improwave.Domain.ViewModels.User;

namespace Improwave.Application.Services.Interfaces;

public interface IAccountService
{
    Task<bool> RegisterUser(RegisterViewModel registerViewModel);
}