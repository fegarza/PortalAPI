using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_prod_perm_obli")]
    [Index(nameof(Rowguid), Name = "index_480772820", IsUnique = true)]
    public partial class FrelProdPermObli
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
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Key]
        [Column("id_permiso")]
        [StringLength(2)]
        public string IdPermiso { get; set; }
        [Key]
        [Column("numero")]
        [StringLength(30)]
        public string Numero { get; set; }
        [Column("firma_permiso")]
        [StringLength(40)]
        public string FirmaPermiso { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Key]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Column("fec_venc", TypeName = "datetime")]
        public DateTime? FecVenc { get; set; }
    }
}
