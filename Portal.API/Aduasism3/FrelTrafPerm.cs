using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_traf_perm")]
    [Index(nameof(Rowguid), Name = "index_161435649", IsUnique = true)]
    public partial class FrelTrafPerm
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
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
        [StringLength(40)]
        public string Firma { get; set; }
        [Key]
        [Column("num_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumSecuencial { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("cantidad_tarifa", TypeName = "numeric(15, 3)")]
        public decimal? CantidadTarifa { get; set; }

        [ForeignKey(nameof(IdTrafico))]
        [InverseProperty(nameof(Fgtrafico.FrelTrafPerms))]
        public virtual Fgtrafico IdTraficoNavigation { get; set; }
    }
}
