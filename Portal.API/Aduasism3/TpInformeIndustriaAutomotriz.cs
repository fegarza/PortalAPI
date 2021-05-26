using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_informe_industria_automotriz")]
    public partial class TpInformeIndustriaAutomotriz
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_informe")]
        public short IdInforme { get; set; }
        [Column("aduana_despacho")]
        public int? AduanaDespacho { get; set; }
        [Column("curp_apoderado_mandatario")]
        [StringLength(18)]
        public string CurpApoderadoMandatario { get; set; }
        [Column("clave_documento")]
        [StringLength(6)]
        public string ClaveDocumento { get; set; }
        [Column("aduana_entrada_salida")]
        public int? AduanaEntradaSalida { get; set; }
        [Column("rfc_importador_exportador")]
        [StringLength(13)]
        public string RfcImportadorExportador { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(9, 6)")]
        public decimal? TipoCambio { get; set; }
    }
}
