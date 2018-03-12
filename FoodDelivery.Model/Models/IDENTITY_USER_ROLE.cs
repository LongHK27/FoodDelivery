using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("IDENTITY_USER_ROLEs")]
    public class IDENTITY_USER_ROLE
    {
        [Key]
        [MaxLength(64)]
        public string IdentityRoleId { get; set; }

        [Key]
        [MaxLength(64)]
        public string ApplicationId { get; set; }

        [ForeignKey("IdentityRoleId")]
        public virtual IDENTITY_ROLE IDENTITY_ROLEs { get; set; }

        [ForeignKey("ApplicationId")]
        public virtual APPLICATION_USER APPLICATION_USERs { get; set; }
    }
}