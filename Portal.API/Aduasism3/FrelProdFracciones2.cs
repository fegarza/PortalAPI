using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("frel_prod_fracciones2")]
    public partial class FrelProdFracciones2
    {
        [Column("id_cliente")]
        [StringLength(255)]
        public string IdCliente { get; set; }
        [Column("id_proveedor")]
        [StringLength(255)]
        public string IdProveedor { get; set; }
        [Column("id_producto")]
        [StringLength(255)]
        public string IdProducto { get; set; }
        [Column("id_fraccion_mex")]
        [StringLength(255)]
        public string IdFraccionMex { get; set; }
        [Column("cve_tipo_opn")]
        [StringLength(255)]
        public string CveTipoOpn { get; set; }
        [Column("id_usuario")]
        [StringLength(255)]
        public string IdUsuario { get; set; }
        [Column("fecha_reg", TypeName = "smalldatetime")]
        public DateTime? FechaReg { get; set; }
        [Column("id_usuario_clasifica")]
        [StringLength(255)]
        public string IdUsuarioClasifica { get; set; }
        [Column("id_usuario_ultmodif")]
        [StringLength(255)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("fecha_ultmodif", TypeName = "smalldatetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Column("clasificado")]
        [StringLength(255)]
        public string Clasificado { get; set; }
    }
}
