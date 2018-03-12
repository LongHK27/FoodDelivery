using FoodDelivery.Model.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("MEAL_PROMOTION")]
    public class MEAL_PROMOTION : Auditable
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
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [MaxLength(200)]
        [Column(TypeName = "nvarchar")]
        public string ComboList { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string RestaurantId { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string MealId { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual RESTAURANT RESTAURANT { get; set; }

        [ForeignKey("MealId")]
        public virtual MEAL MEAL { get; set; }
    }
}