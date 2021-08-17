using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlogInstance.DataAccess.Abstract;

namespace BlogInstance.DataAccess.Entities
{
    public class User:EntityBase,IEntity
    {
        public User()
        {
            Articles = new HashSet<Article>();

        }
        [Key]
        [Display(Name = "ID")]
        public int UserID { get; set; }
        [Required]
        [Display(Name = "Adı")]
        [StringLength(50)]
        public string UserFirstName { get; set; }
        [Required]
        [Display(Name = "Soyadı")]
        [StringLength(50)]
        public string UserLastName { get; set; }
        
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(50)]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Posta Adresi")]
        public string UserEmail { get; set; }

        [Display(Name = "Notlarım")]
        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string UserDescription { get; set; }
        
        [Display(Name = "Küçük Resim")]
        [DataType(DataType.ImageUrl)]
        public string UserThumbnail { get; set; }

        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public byte[] UserPassword { get; set; }

        public string PageName { get { return "https://medium.com/@" + this.UserName; } }
        public string FullName { get { return this.UserFirstName + " " + this.UserLastName; } }

        public int RoleId { get; set; }
        public Role Role{ get; set; }

        

        public virtual ICollection<Article> Articles{ get; set; }

        public ICollection<UserAndCategory> UserAndCategories { get; set; }
    }
}
