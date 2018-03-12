using FoodDelivery.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("RESTAURANTs")]
    public class RESTAURANT : Auditable
    {
        [Key]
        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string Id { get; set; }

        public DateTime UpdateDate { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string UpdateBy { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "nvarchar")]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string Location { get; set; }

        public virtual IEnumerable<MEAL_PROMOTION> MEAL_PROMOTIONs { get; set; }
        public virtual IEnumerable<ORDER_PROMOTION> ODER_PROMOTIONs { get; set; }
        public virtual IEnumerable<ORDER> ODERs { get; set; }
    }
}