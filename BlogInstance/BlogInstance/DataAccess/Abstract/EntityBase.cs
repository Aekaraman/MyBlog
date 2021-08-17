using System;
using System.ComponentModel.DataAnnotations;

namespace BlogInstance.DataAccess.Abstract
{
    public abstract class EntityBase
    {
        //public virtual int Id { get; set; }
        [Display(Name = "Oluşturma Tarihi")]
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        [Display(Name = "Güncelleme Tarihi")]
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        [Display(Name = "Silinsin mi?")]
        public virtual bool IsDeleted { get; set; } = false;
        
        [Display(Name = "Aktif Mi?")]
        public virtual bool IsActive { get; set; } = true;
        [Display(Name = "Oluşturan Adı")]
        public virtual string CreatedByName { get; set; } = "Admin";
    }
}
