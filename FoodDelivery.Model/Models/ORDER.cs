using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("ORDERs")]
    public class ORDER
    {
        [Key]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string CustomerName { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string CustomerEmail { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "nvarchar")]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(20)]
        [Column(TypeName = "nvarchar")]
        public string CustomerMobile { get; set; }

        [MaxLength(1000)]
        [Column(TypeName = "nvarchar")]
        public string CustomerMessage { get; set; }

        [Required]
        public int PromotionPrice { get; set; }

        [Required]
        public int TotalAount { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string PaymentMenthod { get; set; }

        [Required]
        public int PaymentStatus { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        [Required]
        public int Status { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string UserId { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string RestaurantId { get; set; }

        [ForeignKey("UserId")]
        public virtual APPLICATION_USER APPLICATION_USERs { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual RESTAURANT RESTAURANTs { get; set; }

        public virtual IEnumerable<ORDER_DETAIL> ORDER_DETAILs { get; set; }
    }
}