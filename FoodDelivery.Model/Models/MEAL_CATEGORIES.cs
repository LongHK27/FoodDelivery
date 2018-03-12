﻿using FoodDelivery.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("MEAL_CATEGORIESs")]
    public class MEAL_CATEGORIES : Auditable
    {
        [Key]
        [MaxLength(64)]
        public string Id { get; set; }

        public int Display { get; set; }

        public virtual IEnumerable<MEAL> MEALs { get; set; }
    }
}