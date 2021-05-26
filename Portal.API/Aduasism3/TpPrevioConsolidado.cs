using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_previo_consolidado")]
    public partial class TpPrevioConsolidado
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_previo")]
        public short IdPrevio { get; set; }
        [Column("aduana_despacho")]
        public int AduanaDespacho { get; set; }
        [Column("tipo_operacion")]
        [StringLength(250)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("clave_documento")]
        [StringLength(6)]
        public string ClaveDocumento { get; set; }
        [Column("rfc_importador_exportador")]
        [StringLength(13)]
        public string RfcImportadorExportador { get; set; }
        [Column("aduana_entrada_salida")]
        public int AduanaEntradaSalida { get; set; }
        [Column("curp_importador_exportador")]
        [StringLength(18)]
        public string CurpImportadorExportador { get; set; }
        [Column("curp_apoderado_mandatario")]
        [StringLength(18)]
        public string CurpApoderadoMandatario { get; set; }
        [Column("destino")]
        [StringLength(250)]
        public string Destino { get; set; }
        [Column("rfc_agente_aduanal_sociedad_factura")]
        [StringLength(13)]
        public string RfcAgenteAduanalSociedadFactura { get; set; }
    }
}
