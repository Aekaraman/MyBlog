using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogInstance.ViewModels
{
    public class CategoryforArticleViewModel
    {
        [Key]
        [Display(Name = "Kategori ID")]
        public int CategoryId  { get; set; }

        [Display(Name = "Name")]
        public string CategoryName { get; set; }

        [NotMapped]
        public bool IsSelected { get; set; }
    }
}
