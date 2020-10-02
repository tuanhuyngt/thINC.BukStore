using System.ComponentModel.DataAnnotations;

namespace thINC.BukStore.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}