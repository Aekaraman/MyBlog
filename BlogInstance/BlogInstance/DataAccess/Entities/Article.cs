using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlogInstance.DataAccess.Abstract;

namespace BlogInstance.DataAccess.Entities
{
    //Post or Article --I prefer Article  
    public class Article:EntityBase,IEntity 
    {
        [Key]
        [Display(Name = "ID")]
        public int ArticleID { get; set; }
        [Required]
        [Display(Name = "Başlık")]
        [StringLength(150)]
        public string Title { get; set; }
        
        [Required]
        [Display(Name = "İçerik")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Display(Name = "Resim URL")]
        [DataType(DataType.ImageUrl)]
        public string ThumbNail { get; set; }

        [Display(Name = "Oluşturma tarihi")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Görüntülenme Sayısı")]
        public int ViewsCount { get; set; }

        [Display(Name ="Yorum Sayısı")]
        public int CommentCount { get; set; }

        public int UserID { get; set; }
        public virtual User User { get; set; }


        public ICollection<ArticleAndCategory> ArticleAndCategories { get; set; }

    }
}
