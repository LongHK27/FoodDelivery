using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDelivery.Model.Models
{
    [Table("APPLICATION_USER")]
    public class APPLICATION_USER
    {
        [Key]
        [MaxLength(64)]
        [Column(TypeName="nchar")]
        public string Id { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string FullName { get; set; }

        public DateTime? Birthday { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Email { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "nvarchar")]
        public string Phone { set; get; }

        [MaxLength(200)]
        [Column(TypeName = "nvarchar")]
        public string Address { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Username { get; set; }

        [MaxLength(20)]
        [Column(TypeName = "nvarchar")]
        public string Password { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "nvarchar")]
        public string SercurityStamp { get; set; }

        [Required]
        public int Status { get; set; }

        public virtual IEnumerable<IDENTITY_USER_ROLE> IDENTITY_USER_ROLE { get; set; }
        public virtual IEnumerable<IDENTITY_USER_CLAIMS> IDENTITY_USER_CLAIM { get; set; }
    }
}