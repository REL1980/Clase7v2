using System.ComponentModel.DataAnnotations;

namespace Clase7v2.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}