using System.Threading.Tasks;
using Abp.Application.Services;
using Clase7v2.Sessions.Dto;

namespace Clase7v2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
