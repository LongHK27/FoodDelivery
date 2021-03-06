﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("SIDE_DISH")]
    public class SIDE_DISH
    {
        [Key]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int Status { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string MealId { get; set; }

        [ForeignKey("MealId")]
        public virtual MEAL MEAL { get; set; }
    }
}