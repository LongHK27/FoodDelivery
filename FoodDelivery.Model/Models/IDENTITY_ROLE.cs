using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("IDENTITY_ROLE")]
    public class IDENTITY_ROLE
    {
        [Key]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }

        public virtual IEnumerable<IDENTITY_USER_ROLE> IdentityUserRoles { get; set; }
    }
}