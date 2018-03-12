using FoodDelivery.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("MEALs")]
    public class MEAL : Auditable
    {
        [Key]
        [MaxLength(64)]
        public string Id { get; set; }

        [Required]
        public int Price { get; set; }

        [MaxLength(2000)]
        public string Content { get; set; }

        public DateTime UpdateDate { get; set; }

        [MaxLength(64)]
        public string UpdateBy { get; set; }

        [Required]
        [MaxLength(64)]
        public string RestaurantId { get; set; }

        [Required]
        [MaxLength(64)]
        public string MealCategoryId { get; set; }

        [ForeignKey("MealCategoryId")]
        public virtual MEAL_CATEGORIES MEAL_CATEGORYs { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual RESTAURANT RESTAURANTs { get; set; }

        public virtual IEnumerable<ORDER_DETAIL> ORDER_DETAILs { get; set; }
        public virtual IEnumerable<SIDE_DISH> SIDE_DISHs { get; set; }
    }
}