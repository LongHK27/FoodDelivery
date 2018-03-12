using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("IDENTITY_ROLEs")]
    public class IDENTITY_ROLE
    {
        [Key]
        [MaxLength(64)]
        public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual IEnumerable<IDENTITY_USER_ROLE> IdentityUserRoles { get; set; }
    }
}