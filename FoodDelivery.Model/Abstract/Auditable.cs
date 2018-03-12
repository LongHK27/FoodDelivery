using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [Required]
        public DateTime CreateDate { get; set; }

        [MaxLength(64)]
        [Column(TypeName = "nchar")]
        public string CreateBy { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Alias { get; set; }

        [MaxLength(1000)]
        [Column(TypeName = "nvarchar")]
        public string ImageLink { get; set; }

        [MaxLength(2000)]
        [Column(TypeName = "nvarchar")]
        public string Description { get; set; }
    }
}