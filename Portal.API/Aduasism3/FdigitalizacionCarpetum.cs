using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdigitalizacion_carpeta")]
    public partial class FdigitalizacionCarpetum
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("carpeta")]
        [StringLength(250)]
        public string Carpeta { get; set; }
        [Column("rango", TypeName = "numeric(9, 0)")]
        public decimal? Rango { get; set; }
        [Column("automatico")]
        [StringLength(1)]
        public string Automatico { get; set; }
        [Column("compra_vta_para_impo")]
        [StringLength(1)]
        public string CompraVtaParaImpo { get; set; }
        [Column("vinculacion_afecta_precio")]
        [StringLength(1)]
        public string VinculacionAfectaPrecio { get; set; }
        [Column("restricciones")]
        [StringLength(1)]
        public string Restricciones { get; set; }
        [Column("contraprestaciones")]
        [StringLength(1)]
        public string Contraprestaciones { get; set; }
        [Column("revisiones_o_regalias")]
        [StringLength(1)]
        public string RevisionesORegalias { get; set; }
        [Column("unica_o_semestral")]
        [StringLength(1)]
        public string UnicaOSemestral { get; set; }
        [Column("metodo_a_o_b")]
        [StringLength(1)]
        public string MetodoAOB { get; set; }
        [Column("cve_id_contacto")]
        [StringLength(6)]
        public string CveIdContacto { get; set; }
        [Column("ruta_fact_mex")]
        [StringLength(250)]
        public string RutaFactMex { get; set; }
        [Column("rango_fact_mex", TypeName = "numeric(9, 0)")]
        public decimal? RangoFactMex { get; set; }
    }
}
