using System.ComponentModel.DataAnnotations;

namespace VueCore.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}