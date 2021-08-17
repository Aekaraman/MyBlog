using System.ComponentModel.DataAnnotations;

namespace BlogInstance.DataAccess.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [Display(Name = "Kategori Adı")]
        [MaxLength(70, ErrorMessage = "{0} {1} karakterden büyük olmamalı")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string CategoryName { get; set; }

        [Display(Name = "Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden büyük olmamalı")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olmamalıdır")]
        public string CategoryDescription { get; set; }

        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [Display(Name = "Aktif mi?")]
        public bool IsActive { get; set; }
        [Required(ErrorMessage = "{0} boş geçilmemelidir.")]
        [Display(Name = "Silindi mi?")]
        public bool IsDeleted { get; set; }
    }
}
