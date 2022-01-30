using System.Threading.Tasks;
using Abp.Application.Services;
using Clase7v2.Authorization.Accounts.Dto;

namespace Clase7v2.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
