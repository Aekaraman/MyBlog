using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BlogInstance.DataAccess.Abstract;

namespace BlogInstance.DataAccess.Entities
{
    public class Role:EntityBase,IEntity
    {
        
        [Display(Name = "ID")]
        public int RoleId { get; set; }
        
        [Display(Name = "Statü Adı")]
        [StringLength(50)]
        public string RoleName { get; set; }
        [Display(Name = "Statü Açıklaması")]
        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string RoleDescription { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
