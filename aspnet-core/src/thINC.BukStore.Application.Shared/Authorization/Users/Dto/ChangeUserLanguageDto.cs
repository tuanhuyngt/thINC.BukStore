using System.ComponentModel.DataAnnotations;

namespace thINC.BukStore.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
