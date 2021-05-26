using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_licence_exception")]
    public partial class ShipperLicenceException
    {
        [Key]
        [Column("shipper_licence_exce_id")]
        public int ShipperLicenceExceId { get; set; }
        [Column("shipper_licence_id")]
        public int ShipperLicenceId { get; set; }
        [Required]
        [Column("condition")]
        [StringLength(2)]
        public string Condition { get; set; }
        [Required]
        [Column("key_")]
        [StringLength(20)]
        public string Key { get; set; }
        [Required]
        [Column("value_")]
        [StringLength(20)]
        public string Value { get; set; }

        [ForeignKey(nameof(ShipperLicenceId))]
        [InverseProperty("ShipperLicenceExceptions")]
        public virtual ShipperLicence ShipperLicence { get; set; }
    }
}
