using Abp.Application.Services;
using Clase7v2.MultiTenancy.Dto;

namespace Clase7v2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

