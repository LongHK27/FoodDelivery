using FoodDelivery.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("MEAL_CATEGORIES")]
    public class MEAL_CATEGORIES : Auditable
    {
        [Key]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string Id { get; set; }

        public int Display { get; set; }

        public virtual IEnumerable<MEAL> MEAL { get; set; }
    }
}