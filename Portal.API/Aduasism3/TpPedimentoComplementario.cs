using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_pedimento_complementario")]
    public partial class TpPedimentoComplementario
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_pedimento_comp")]
        public short IdPedimentoComp { get; set; }
        [Required]
        [Column("clave_documento")]
        [StringLength(6)]
        public string ClaveDocumento { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(12, 2)")]
        public decimal? TipoCambio { get; set; }
        [Column("curp_importador_exportador")]
        [StringLength(18)]
        public string CurpImportadorExportador { get; set; }
        [Column("rfc_importador_exportador")]
        [StringLength(13)]
        public string RfcImportadorExportador { get; set; }
        [Column("razon_social_importador_exportador")]
        [StringLength(120)]
        public string RazonSocialImportadorExportador { get; set; }
        [Column("curp_apoderado_mandatario")]
        [StringLength(18)]
        public string CurpApoderadoMandatario { get; set; }
        [Column("rfc_agente_aduanal_sociedad_factura")]
        [StringLength(13)]
        public string RfcAgenteAduanalSociedadFactura { get; set; }
    }
}
