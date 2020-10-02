using Abp.AutoMapper;
using thINC.BukStore.Localization.Dto;

namespace thINC.BukStore.Web.Areas.AppAreaName.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}