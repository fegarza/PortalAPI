using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("frel_prod_frac1")]
    public partial class FrelProdFrac1
    {
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("id_producto")]
        [StringLength(20)]
        public string IdProducto { get; set; }
        [Required]
        [Column("id_fraccion_mex")]
        [StringLength(8)]
        public string IdFraccionMex { get; set; }
        [Required]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime FechaReg { get; set; }
        [Required]
        [Column("id_usuario_clasifica")]
        [StringLength(6)]
        public string IdUsuarioClasifica { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime FechaUltmodif { get; set; }
        [Column("clasificado")]
        [StringLength(1)]
        public string Clasificado { get; set; }
        [Column("id_fraccion_historico")]
        [StringLength(8)]
        public string IdFraccionHistorico { get; set; }
        [Column("fecha_cla_fisica", TypeName = "datetime")]
        public DateTime? FechaClaFisica { get; set; }
        [Column("id_usuario_cla_fisica")]
        [StringLength(6)]
        public string IdUsuarioClaFisica { get; set; }
    }
}
