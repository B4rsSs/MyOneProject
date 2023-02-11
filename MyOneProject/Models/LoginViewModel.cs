using System.ComponentModel.DataAnnotations;

namespace MyOneProject.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Введите логин")]
        public string UserName { get;set; }

        [Required]
        [Display(Name = "Введите пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня ?")]
        public bool RememberMe { get; set; }
    }
}
