using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("ORDER_DETAILs")]
    public class ORDER_DETAIL
    {
        [Key]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string Id { get; set; }

        [Required]
        public int Quanlity { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string OrderId { get; set; }

        [Required]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string MealId { get; set; }

        [Required]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string SideDishId { get; set; }

        [ForeignKey("MealId")]
        public virtual MEAL MEAL { get; set; }

        [ForeignKey("SideDishId")]
        public virtual SIDE_DISH SIDE_DISH { get; set; }

        [ForeignKey("OrderId")]
        public virtual ORDER ODER { get; set; }
    }
}