using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.UI.Inputs;
using thINC.BukStore.DynamicEntityParameters.Dto;

namespace thINC.BukStore.DynamicEntityParameters
{
    public interface IDynamicParameterAppService
    {
        Task<DynamicParameterDto> Get(int id);

        Task<ListResultDto<DynamicParameterDto>> GetAll();

        Task Add(DynamicParameterDto dto);

        Task Update(DynamicParameterDto dto);

        Task Delete(int id);

        IInputType FindAllowedInputType(string name);
    }
}
