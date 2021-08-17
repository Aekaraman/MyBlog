using System.ComponentModel.DataAnnotations;

namespace BlogInstance.DataAccess.Entities
{
    public class ArticleAndCategory
    {
        [Display(Name = "Makale Kodu")]
        public int ArticleID { get; set; }
        public Article Article { get; set; }
        [Display(Name = "Kategori Kodu")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }


    }
}
