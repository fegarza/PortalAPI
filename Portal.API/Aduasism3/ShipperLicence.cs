using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_licence")]
    public partial class ShipperLicence
    {
        public ShipperLicence()
        {
            ShipperLicenceExceptions = new HashSet<ShipperLicenceException>();
        }

        [Key]
        [Column("shipper_licence_id")]
        public int ShipperLicenceId { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("no_parte")]
        [StringLength(50)]
        public string NoParte { get; set; }
        [Column("licence_code")]
        [StringLength(3)]
        public string LicenceCode { get; set; }
        [Column("licence_number")]
        [StringLength(12)]
        public string LicenceNumber { get; set; }
        [Column("eccn")]
        [StringLength(5)]
        public string Eccn { get; set; }

        [InverseProperty(nameof(ShipperLicenceException.ShipperLicence))]
        public virtual ICollection<ShipperLicenceException> ShipperLicenceExceptions { get; set; }
    }
}
