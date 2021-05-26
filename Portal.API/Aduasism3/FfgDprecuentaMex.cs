using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_dprecuenta_mex")]
    public partial class FfgDprecuentaMex
    {
        [Key]
        [Column("id_precuenta")]
        [StringLength(10)]
        public string IdPrecuenta { get; set; }
        [Key]
        [Column("num_detalle", TypeName = "numeric(4, 0)")]
        public decimal NumDetalle { get; set; }
        [Required]
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("cve_comprobable", TypeName = "numeric(1, 0)")]
        public decimal CveComprobable { get; set; }
        [Column("id_unidad_facturacion")]
        [StringLength(4)]
        public string IdUnidadFacturacion { get; set; }
        [Column("precio", TypeName = "numeric(12, 2)")]
        public decimal? Precio { get; set; }
        [Column("cantidad", TypeName = "numeric(12, 5)")]
        public decimal? Cantidad { get; set; }
        [Column("monto", TypeName = "numeric(12, 2)")]
        public decimal? Monto { get; set; }
        [Required]
        [Column("afecta_hon")]
        [StringLength(1)]
        public string AfectaHon { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("cve_concepto", TypeName = "numeric(3, 0)")]
        public decimal? CveConcepto { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("num_documento", TypeName = "numeric(6, 0)")]
        public decimal? NumDocumento { get; set; }
        [Column("num_beneficiario", TypeName = "numeric(6, 0)")]
        public decimal? NumBeneficiario { get; set; }
        [Column("tipo_beneficiario")]
        public int? TipoBeneficiario { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "decimal(5, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Column("numero_vehiculo")]
        [StringLength(15)]
        public string NumeroVehiculo { get; set; }
        [Column("sello")]
        [StringLength(10)]
        public string Sello { get; set; }
        [Column("consecutivo_vehiculo", TypeName = "numeric(5, 0)")]
        public decimal? ConsecutivoVehiculo { get; set; }
        [Column("semaforo")]
        [StringLength(1)]
        public string Semaforo { get; set; }
        [Column("fin_doc_header_id")]
        public int? FinDocHeaderId { get; set; }
        [Column("iva_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? IvaPorcentaje { get; set; }
        [Column("monto_porcentaje", TypeName = "numeric(12, 2)")]
        public decimal? MontoPorcentaje { get; set; }
        [Column("monto_dlls", TypeName = "decimal(14, 2)")]
        public decimal? MontoDlls { get; set; }
        [Column("num_benef_tercero", TypeName = "numeric(6, 0)")]
        public decimal? NumBenefTercero { get; set; }
        [Column("tipo_benef_tercero")]
        public int? TipoBenefTercero { get; set; }
        [Column("num_factura_tercero")]
        [StringLength(30)]
        public string NumFacturaTercero { get; set; }
        [Column("valor_bruto_tercero", TypeName = "decimal(16, 2)")]
        public decimal? ValorBrutoTercero { get; set; }
        [Column("importe_iva_tercero", TypeName = "decimal(16, 2)")]
        public decimal? ImporteIvaTercero { get; set; }
        [Column("por_iva_tecero", TypeName = "numeric(5, 2)")]
        public decimal? PorIvaTecero { get; set; }
        [Column("c_ClaveProdServ")]
        [StringLength(8)]
        public string CClaveProdServ { get; set; }
        [Column("c_ClaveUnidad")]
        [StringLength(3)]
        public string CClaveUnidad { get; set; }
        [StringLength(250)]
        public string UnidadDescripcion { get; set; }
        [Column(TypeName = "numeric(14, 2)")]
        public decimal? Descuento { get; set; }
    }
}
