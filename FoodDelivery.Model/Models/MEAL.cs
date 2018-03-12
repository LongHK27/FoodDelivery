using FoodDelivery.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("MEAL")]
    public class MEAL : Auditable
    {
        [Key]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string Id { get; set; }

        [Required]
        public int Price { get; set; }

        [MaxLength(2000)]
        [Column(TypeName = "nvarchar")]
        public string Content { get; set; }

        public DateTime UpdateDate { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string UpdateBy { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar", Order = 1)]
        public string RestaurantId { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar", Order = 2)]
        public string MealCategoryId { get; set; }

        [ForeignKey("MealCategoryId")]
        public virtual MEAL_CATEGORIES MEAL_CATEGORY { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual RESTAURANT RESTAURANT { get; set; }

        public virtual IEnumerable<ORDER_DETAIL> ORDER_DETAIL { get; set; }
        public virtual IEnumerable<SIDE_DISH> SIDE_DISH { get; set; }
    }
}