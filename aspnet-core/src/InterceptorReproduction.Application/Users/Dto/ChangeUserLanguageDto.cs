using System.ComponentModel.DataAnnotations;

namespace InterceptorReproduction.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}