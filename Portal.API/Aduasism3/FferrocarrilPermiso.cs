using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fferrocarril_permiso")]
    [Index(nameof(Rowguid), Name = "index_1412916105", IsUnique = true)]
    public partial class FferrocarrilPermiso
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(15)]
        public string IdFactura { get; set; }
        [Key]
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Key]
        [Column("numero_sec", TypeName = "decimal(4, 0)")]
        public decimal NumeroSec { get; set; }
        [Key]
        [Column("secuencial")]
        public int Secuencial { get; set; }
        [Required]
        [Column("id_permiso")]
        [StringLength(2)]
        public string IdPermiso { get; set; }
        [Column("numero_permiso")]
        [StringLength(7)]
        public string NumeroPermiso { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
