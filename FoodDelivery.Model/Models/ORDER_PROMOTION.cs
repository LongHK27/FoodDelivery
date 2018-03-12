using FoodDelivery.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("ORDER_PROMOTION")]
    public class ORDER_PROMOTION : Auditable
    {
        [Key]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string Id { get; set; }

        [Required]
        public int TotalMeal { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [MaxLength(200)]
        [Column(TypeName = "nvarchar")]
        public string ComboList { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string RestaurantId { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual RESTAURANT RESTAURANT { get; set; }
    }
}