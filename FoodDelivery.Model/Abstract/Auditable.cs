using System;
using System.ComponentModel.DataAnnotations;

namespace FoodDelivery.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [Required]
        public DateTime CreateDate { get; set; }
        [MaxLength(64)]
        public string CreateBy { get; set; }
        [Required]
        public int Status { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Alias { get; set; }
        [MaxLength(1000)]
        public string ImageLink { get; set; }
        [MaxLength(2000)]
        public string Description { get; set; }
    }
}