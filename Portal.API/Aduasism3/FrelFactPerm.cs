using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_fact_perm")]
    public partial class FrelFactPerm
    {
        [Key]
        [Column("id_Factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("num_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumSecuencial { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Key]
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Key]
        [Column("id_permiso")]
        [StringLength(2)]
        public string IdPermiso { get; set; }
        [Column("cve_opcional", TypeName = "numeric(1, 0)")]
        public decimal CveOpcional { get; set; }
        [Key]
        [Column("num_permiso")]
        [StringLength(30)]
        public string NumPermiso { get; set; }
        [Column("firma")]
        [StringLength(17)]
        public string Firma { get; set; }
    }
}
