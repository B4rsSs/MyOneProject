using System.ComponentModel.DataAnnotations;

namespace MyOneProject.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public int Id { get; set; }

        [Display(Name = "Название")]
        public virtual string? Title { get; set; }

        [Display(Name = "Краткое описание")]
        public virtual string? SubTitle { get; set; }

        [Display(Name = "Полное описание")]
        public virtual string? Description { get; set; }

        [Display(Name = "Титульная картинка")]
        public virtual string? TitleImagePath { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }
    }
}
