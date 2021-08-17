using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlogInstance.DataAccess.Abstract;

namespace BlogInstance.DataAccess.Entities
{
    //public enum Topic
    //{
    //    Art, Books, Comics, Fiction, Film, Gaming, Humor, Music, Tech, Desing, DataScience,SoftwareEngineering
    //}
    public class Category:EntityBase,IEntity
    {
        [Key]
        [Display(Name = "ID")]
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="{0} boş geçilmemelidir.")]
        [Display(Name = "Kategori Adı")]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Display(Name = "Açıklama")]
        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string CategoryDescription { get; set; }
     

        public ICollection<ArticleAndCategory> ArticleAndCategories { get; set; }
        public ICollection<UserAndCategory> UserAndCategories { get; set; }
    }
}
