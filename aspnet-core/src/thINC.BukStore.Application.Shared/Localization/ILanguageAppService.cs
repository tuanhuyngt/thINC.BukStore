using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using thINC.BukStore.Localization.Dto;

namespace thINC.BukStore.Localization
{
    public interface ILanguageAppService : IApplicationService
    {
        Task<GetLanguagesOutput> GetLanguages();

        Task<GetLanguageForEditOutput> GetLanguageForEdit(NullableIdDto input);

        Task CreateOrUpdateLanguage(CreateOrUpdateLanguageInput input);

        Task DeleteLanguage(EntityDto input);

        Task SetDefaultLanguage(SetDefaultLanguageInput input);

        Task<PagedResultDto<LanguageTextListDto>> GetLanguageTexts(GetLanguageTextsInput input);

        Task UpdateLanguageText(UpdateLanguageTextInput input);
    }
}
