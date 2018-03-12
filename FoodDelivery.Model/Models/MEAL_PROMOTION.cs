using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("MEAL_PROMOTIONs")]
    public class MEAL_PROMOTION
    {
        [Key]
        [MaxLength(64)]
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
        public string ComboList { get; set; }

        [Required]
        [MaxLength(64)]
        public string RestaurantId { get; set; }

        [Required]
        [MaxLength(64)]
        public string MealId { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual RESTAURANT RESTAURANTs { get; set; }

        [ForeignKey("MealId")]
        public virtual MEAL MEALs { get; set; }
    }
}