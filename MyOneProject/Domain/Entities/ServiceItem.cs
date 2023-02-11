using System.ComponentModel.DataAnnotations;

namespace MyOneProject.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название услуги")]
        [Display(Name = "Название услуги")]
        public override string? Title { get; set; }

        [Display(Name = "Краткое описание услуги")]
        public override string? SubTitle { get; set; }

        [Display(Name = "Полное описание услуги")]
        public override string? Description { get; set; }
    }
}
