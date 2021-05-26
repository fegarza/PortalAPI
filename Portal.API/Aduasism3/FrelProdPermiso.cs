using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_prod_permiso")]
    [Index(nameof(Rowguid), Name = "index_145435592", IsUnique = true)]
    public partial class FrelProdPermiso
    {
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
        [Key]
        [Column("cve_opcional", TypeName = "numeric(1, 0)")]
        public decimal CveOpcional { get; set; }
        [Column("num_permiso")]
        [StringLength(17)]
        public string NumPermiso { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
