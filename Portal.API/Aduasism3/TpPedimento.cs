using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_pedimento")]
    public partial class TpPedimento
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Column("pedimento")]
        public int Pedimento { get; set; }
        [Column("tipo_operacion")]
        public int TipoOperacion { get; set; }
        [Required]
        [Column("clave_documento")]
        [StringLength(6)]
        public string ClaveDocumento { get; set; }
        [Column("destino")]
        public int? Destino { get; set; }
        [Column("aduana")]
        public int? Aduana { get; set; }
        [Column("tipo_cambio", TypeName = "decimal(9, 6)")]
        public decimal? TipoCambio { get; set; }
        [Column("peso_bruto", TypeName = "decimal(14, 3)")]
        public decimal? PesoBruto { get; set; }
        [Column("medio_transporte_salida")]
        public int? MedioTransporteSalida { get; set; }
        [Column("medio_transporte_arribo")]
        public int? MedioTransporteArribo { get; set; }
        [Column("medio_transporte_entrada")]
        public int? MedioTransporteEntrada { get; set; }
        [Column("curp_apoderado_mandatario")]
        [StringLength(18)]
        public string CurpApoderadoMandatario { get; set; }
        [Column("rfc_agente_aduanal_soc_factura")]
        [StringLength(13)]
        public string RfcAgenteAduanalSocFactura { get; set; }
        [Column("valor_dolares", TypeName = "decimal(12, 2)")]
        public decimal? ValorDolares { get; set; }
        [Column("valor_aduana_total", TypeName = "decimal(12, 0)")]
        public decimal? ValorAduanaTotal { get; set; }
        [Column("valor_comercial_total", TypeName = "decimal(12, 0)")]
        public decimal? ValorComercialTotal { get; set; }
        [Column("id_rectificacion")]
        public short? IdRectificacion { get; set; }
        [Column("id_importador_exp")]
        public short? IdImportadorExp { get; set; }
        [Column("id_pedimento_comp")]
        public short? IdPedimentoComp { get; set; }
        [Column("id_previo")]
        public short? IdPrevio { get; set; }
        [Column("id_informe")]
        public short? IdInforme { get; set; }
    }
}
