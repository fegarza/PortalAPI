using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_general_fac_ame")]
    public partial class FfgGeneralFacAme
    {
        [Column("id_forwarding")]
        [StringLength(8)]
        public string IdForwarding { get; set; }
        [Column("tax_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? TaxPorcentaje { get; set; }
        [Column("imp_exp")]
        [StringLength(1)]
        public string ImpExp { get; set; }
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("pago_automatico")]
        [StringLength(1)]
        public string PagoAutomatico { get; set; }
        [Column("anticipo_automatico")]
        [StringLength(1)]
        public string AnticipoAutomatico { get; set; }
        [Column("leyenda_factura")]
        [StringLength(1)]
        public string LeyendaFactura { get; set; }
        [Column("leyenda_rel_envio")]
        [StringLength(1)]
        public string LeyendaRelEnvio { get; set; }
        [Column("auto_factura")]
        [StringLength(1)]
        public string AutoFactura { get; set; }
        [Column("prefijo_factura")]
        [StringLength(3)]
        public string PrefijoFactura { get; set; }
        [Column("auto_folio")]
        [StringLength(1)]
        public string AutoFolio { get; set; }
        [Column("prefijo_relacion")]
        [StringLength(3)]
        public string PrefijoRelacion { get; set; }
        [Column("auto_relacion")]
        [StringLength(1)]
        public string AutoRelacion { get; set; }
        [Column("prefijo_folio")]
        [StringLength(3)]
        public string PrefijoFolio { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("id_cliente")]
        [StringLength(4)]
        public string IdCliente { get; set; }
        [Column("numempresa")]
        public int? Numempresa { get; set; }
        [Column("numero_copias", TypeName = "numeric(18, 0)")]
        public decimal? NumeroCopias { get; set; }
    }
}
