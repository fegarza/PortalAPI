using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fferrocarril")]
    [Index(nameof(Rowguid), Name = "index_1535344534", IsUnique = true)]
    public partial class Fferrocarril
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("fecha_trafico", TypeName = "datetime")]
        public DateTime? FechaTrafico { get; set; }
        [Column("cve_operacion")]
        [StringLength(1)]
        public string CveOperacion { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("notificacion_numero")]
        [StringLength(10)]
        public string NotificacionNumero { get; set; }
        [Column("fecha_notificacion", TypeName = "datetime")]
        public DateTime? FechaNotificacion { get; set; }
        [Column("fecha_premanifiesto", TypeName = "datetime")]
        public DateTime? FechaPremanifiesto { get; set; }
        [Column("bultos", TypeName = "numeric(8, 0)")]
        public decimal? Bultos { get; set; }
        [Column("cve_tipo_flete")]
        [StringLength(1)]
        public string CveTipoFlete { get; set; }
        [Column("importe_flete", TypeName = "numeric(10, 2)")]
        public decimal? ImporteFlete { get; set; }
        [Column("importe_perdiem", TypeName = "numeric(10, 2)")]
        public decimal? ImportePerdiem { get; set; }
        [Column("dias_demoras", TypeName = "numeric(3, 0)")]
        public decimal? DiasDemoras { get; set; }
        [Column("importe_demoras", TypeName = "numeric(10, 2)")]
        public decimal? ImporteDemoras { get; set; }
        [Column("fecha_vencimiento", TypeName = "datetime")]
        public DateTime? FechaVencimiento { get; set; }
        [Column("fecha_descarga", TypeName = "datetime")]
        public DateTime? FechaDescarga { get; set; }
        [Column("fecha_entrega", TypeName = "datetime")]
        public DateTime? FechaEntrega { get; set; }
        [Column("fecha_cruce", TypeName = "datetime")]
        public DateTime? FechaCruce { get; set; }
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Column("id_pais_origen")]
        [StringLength(2)]
        public string IdPaisOrigen { get; set; }
        [Column("id_pais_vendedor")]
        [StringLength(2)]
        public string IdPaisVendedor { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime? FechaUltModif { get; set; }
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_conocimiento", TypeName = "datetime")]
        public DateTime? FechaConocimiento { get; set; }
        [Column("fecha_cruce_list", TypeName = "datetime")]
        public DateTime? FechaCruceList { get; set; }
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Column("status")]
        [StringLength(1)]
        public string Status { get; set; }
        [Column("id_moneda_flete")]
        [StringLength(4)]
        public string IdMonedaFlete { get; set; }
        [Column("factor_flete", TypeName = "numeric(10, 8)")]
        public decimal? FactorFlete { get; set; }
        [Column("id_moneda_factura")]
        [StringLength(4)]
        public string IdMonedaFactura { get; set; }
        [Column("factor_factura", TypeName = "numeric(10, 8)")]
        public decimal? FactorFactura { get; set; }
        [Column("factor_actualizacion", TypeName = "numeric(10, 8)")]
        public decimal? FactorActualizacion { get; set; }
        [Column("otros_gastos_me", TypeName = "numeric(12, 2)")]
        public decimal? OtrosGastosMe { get; set; }
        [Column("id_moneda_otros_gme")]
        [StringLength(4)]
        public string IdMonedaOtrosGme { get; set; }
        [Column("factor_otros_gme", TypeName = "numeric(10, 8)")]
        public decimal? FactorOtrosGme { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("otros_gastos_bod", TypeName = "numeric(12, 2)")]
        public decimal? OtrosGastosBod { get; set; }
        [Column("id_moneda_otros_bod")]
        [StringLength(4)]
        public string IdMonedaOtrosBod { get; set; }
        [Column("factor_otros_bod", TypeName = "numeric(10, 8)")]
        public decimal? FactorOtrosBod { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("envio_correo")]
        [StringLength(1)]
        public string EnvioCorreo { get; set; }
        [Column("perdiem", TypeName = "numeric(10, 2)")]
        public decimal? Perdiem { get; set; }
        [StringLength(15)]
        public string LoadInb { get; set; }
        [Column("monto_anticipo", TypeName = "numeric(12, 2)")]
        public decimal? MontoAnticipo { get; set; }
        [Column("fecha_anticipo", TypeName = "datetime")]
        public DateTime? FechaAnticipo { get; set; }
        [Column("guia_local", TypeName = "numeric(6, 0)")]
        public decimal? GuiaLocal { get; set; }
        [Column("destino")]
        [StringLength(20)]
        public string Destino { get; set; }
        [Column("id_tipo_pedimento")]
        [StringLength(2)]
        public string IdTipoPedimento { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal? IdRectificacion { get; set; }
    }
}
