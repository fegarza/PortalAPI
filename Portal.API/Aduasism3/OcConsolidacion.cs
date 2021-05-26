using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_consolidacion")]
    public partial class OcConsolidacion
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_consolidacion")]
        [StringLength(10)]
        public string IdConsolidacion { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("tipo_importacion")]
        [StringLength(1)]
        public string TipoImportacion { get; set; }
        [Required]
        [Column("clave_documento")]
        [StringLength(5)]
        public string ClaveDocumento { get; set; }
        [Column("tipo_transporte")]
        [StringLength(2)]
        public string TipoTransporte { get; set; }
        [Required]
        [Column("id_moneda")]
        [StringLength(4)]
        public string IdMoneda { get; set; }
        [Column("valor_factura", TypeName = "decimal(12, 2)")]
        public decimal ValorFactura { get; set; }
        [Column("valor_comercial", TypeName = "decimal(12, 2)")]
        public decimal ValorComercial { get; set; }
        [Column("importe_flete", TypeName = "decimal(12, 2)")]
        public decimal ImporteFlete { get; set; }
        [Column("importe_seguro", TypeName = "decimal(12, 2)")]
        public decimal ImporteSeguro { get; set; }
        [Column("importe_embalaje", TypeName = "decimal(12, 2)")]
        public decimal ImporteEmbalaje { get; set; }
        [Column("importe_otros", TypeName = "decimal(12, 2)")]
        public decimal ImporteOtros { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal PesoKilos { get; set; }
        [Column("bultos")]
        public int Bultos { get; set; }
        [Column("remesa")]
        public bool Remesa { get; set; }
        [Column("numero_remesa")]
        public int NumeroRemesa { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion")]
        public short? IdRectificacion { get; set; }
        [Column("corresponsalia")]
        public bool Corresponsalia { get; set; }
        [Required]
        [Column("corresponsal")]
        [StringLength(8)]
        public string Corresponsal { get; set; }
        [Required]
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Required]
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Required]
        [Column("seccion")]
        [StringLength(2)]
        public string Seccion { get; set; }
        [Required]
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
        [Column("consolidado")]
        public bool Consolidado { get; set; }
        [Column("fecha_consolidacion", TypeName = "datetime")]
        public DateTime? FechaConsolidacion { get; set; }
        [Column("usuario_consolida")]
        [StringLength(6)]
        public string UsuarioConsolida { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("virtual")]
        public bool Virtual { get; set; }
        [Column("tipo_carga")]
        [StringLength(2)]
        public string TipoCarga { get; set; }
        [Column("sello1")]
        [StringLength(21)]
        public string Sello1 { get; set; }
        [Column("sello2")]
        [StringLength(21)]
        public string Sello2 { get; set; }
        [Column("modo_transporte")]
        [StringLength(2)]
        public string ModoTransporte { get; set; }
        [Column("embarque")]
        [StringLength(35)]
        public string Embarque { get; set; }
        [Column("fecha_entrega", TypeName = "datetime")]
        public DateTime? FechaEntrega { get; set; }
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("id_destino")]
        [StringLength(4)]
        public string IdDestino { get; set; }
        [Column("notificacion")]
        public bool Notificacion { get; set; }
        [Column("fecha_cruce", TypeName = "datetime")]
        public DateTime? FechaCruce { get; set; }
        [Column("tarifa_importe", TypeName = "decimal(12, 2)")]
        public decimal? TarifaImporte { get; set; }
        [Column("gastos_mexicanos", TypeName = "decimal(12, 2)")]
        public decimal? GastosMexicanos { get; set; }
        [Column("gastos_americanos", TypeName = "decimal(12, 2)")]
        public decimal? GastosAmericanos { get; set; }
        [Column("haz_mat")]
        public bool HazMat { get; set; }
        [Column("gastos_flete", TypeName = "decimal(12, 2)")]
        public decimal GastosFlete { get; set; }
        [Column("gastos_seguro", TypeName = "decimal(12, 2)")]
        public decimal GastosSeguro { get; set; }
        [Column("gastos_embalaje", TypeName = "decimal(12, 2)")]
        public decimal GastosEmbalaje { get; set; }
        [Column("gastos_otros", TypeName = "decimal(12, 2)")]
        public decimal GastosOtros { get; set; }
        [Column("id_plant_code")]
        [StringLength(4)]
        public string IdPlantCode { get; set; }
        [Column("fecha_factor_moneda", TypeName = "datetime")]
        public DateTime? FechaFactorMoneda { get; set; }
        [Column("inbond")]
        public bool Inbond { get; set; }
        [Column("directo")]
        public bool Directo { get; set; }
        [Column("no_eei")]
        [StringLength(15)]
        public string NoEei { get; set; }
        [Column("pedimento_anticipado")]
        public bool? PedimentoAnticipado { get; set; }
        [Column("packing")]
        public bool? Packing { get; set; }
        [Column("automatica_regla318")]
        public bool AutomaticaRegla318 { get; set; }
        [Column("operacion_especial")]
        public bool? OperacionEspecial { get; set; }
    }
}
