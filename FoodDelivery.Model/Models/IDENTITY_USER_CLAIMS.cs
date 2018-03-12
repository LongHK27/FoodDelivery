using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("IDENTITY_USER_CLAIMSs")]
    public class IDENTITY_USER_CLAIMS
    {
        [Key]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string Id { get; set; }

        [Required]
        public int ClaimType { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string ClaimValue { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string ApplicationId { get; set; }

        [ForeignKey("ApplicationId")]
        public virtual APPLICATION_USER APPLICATION_USERs { get; set; }
    }
}