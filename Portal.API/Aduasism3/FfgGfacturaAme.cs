using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_gfactura_ame")]
    public partial class FfgGfacturaAme
    {
        [Required]
        [Column("id_factura_ame")]
        [StringLength(10)]
        public string IdFacturaAme { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Required]
        [Column("tipo_factura")]
        [StringLength(1)]
        public string TipoFactura { get; set; }
        [Required]
        [Column("situacion_factura")]
        [StringLength(1)]
        public string SituacionFactura { get; set; }
        [Column("numero_folio", TypeName = "numeric(12, 0)")]
        public decimal? NumeroFolio { get; set; }
        [Required]
        [Column("id_tabulador")]
        [StringLength(3)]
        public string IdTabulador { get; set; }
        [Column("total_gts_comp", TypeName = "numeric(12, 2)")]
        public decimal? TotalGtsComp { get; set; }
        [Column("total_complemen", TypeName = "numeric(12, 2)")]
        public decimal? TotalComplemen { get; set; }
        [Column("tax_porcentaje", TypeName = "numeric(5, 2)")]
        public decimal? TaxPorcentaje { get; set; }
        [Column("tax", TypeName = "numeric(12, 2)")]
        public decimal? Tax { get; set; }
        [Column("anticipo", TypeName = "numeric(12, 2)")]
        public decimal? Anticipo { get; set; }
        [Column("saldo", TypeName = "numeric(12, 2)")]
        public decimal? Saldo { get; set; }
        [Column("id_cliente_pedi")]
        [StringLength(6)]
        public string IdClientePedi { get; set; }
        [Column("id_cliente_fact")]
        [StringLength(6)]
        public string IdClienteFact { get; set; }
        [Column("nombre_cli_fact")]
        [StringLength(48)]
        public string NombreCliFact { get; set; }
        [Column("rfc_cli_fact")]
        [StringLength(13)]
        public string RfcCliFact { get; set; }
        [Column("domici_cli_fact")]
        [StringLength(80)]
        public string DomiciCliFact { get; set; }
        [Column("colonia_cli_fact")]
        [StringLength(30)]
        public string ColoniaCliFact { get; set; }
        [Column("calle_numero_fact")]
        [StringLength(10)]
        public string CalleNumeroFact { get; set; }
        [Column("ciudad_cli_fact")]
        [StringLength(40)]
        public string CiudadCliFact { get; set; }
        [Column("estado_cli_fact")]
        [StringLength(10)]
        public string EstadoCliFact { get; set; }
        [Column("cp_cli_fact")]
        [StringLength(10)]
        public string CpCliFact { get; set; }
        [Column("poli_anticipo")]
        [StringLength(40)]
        public string PoliAnticipo { get; set; }
        [Column("fecha_incial", TypeName = "datetime")]
        public DateTime? FechaIncial { get; set; }
        [Column("fecha_final", TypeName = "datetime")]
        public DateTime? FechaFinal { get; set; }
        [Column("id_corresponsal")]
        [StringLength(6)]
        public string IdCorresponsal { get; set; }
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Column("id_pedimento")]
        [StringLength(7)]
        public string IdPedimento { get; set; }
        [Column("id_linea")]
        [StringLength(6)]
        public string IdLinea { get; set; }
        [Column("numero_guia")]
        [StringLength(30)]
        public string NumeroGuia { get; set; }
        [Column("fecha_entrada", TypeName = "datetime")]
        public DateTime? FechaEntrada { get; set; }
        [Column("fecha_cruce", TypeName = "datetime")]
        public DateTime? FechaCruce { get; set; }
        [Column("no_caja")]
        [StringLength(20)]
        public string NoCaja { get; set; }
        [Column("color_semaforo")]
        [StringLength(1)]
        public string ColorSemaforo { get; set; }
        [Column("sello")]
        [StringLength(10)]
        public string Sello { get; set; }
        [Column("imp_exp")]
        [StringLength(1)]
        public string ImpExp { get; set; }
        [Column("regimen")]
        [StringLength(2)]
        public string Regimen { get; set; }
        [Column("factura_prov")]
        [StringLength(15)]
        public string FacturaProv { get; set; }
        [Column("valor_factura", TypeName = "numeric(11, 2)")]
        public decimal? ValorFactura { get; set; }
        [Column("id_orden_compra")]
        [StringLength(15)]
        public string IdOrdenCompra { get; set; }
        [Column("fecha_factura_prov", TypeName = "datetime")]
        public DateTime? FechaFacturaProv { get; set; }
        [Column("descripcion_mcia")]
        [StringLength(70)]
        public string DescripcionMcia { get; set; }
        [Column("peso_mcia", TypeName = "numeric(14, 3)")]
        public decimal? PesoMcia { get; set; }
        [Column("bultos", TypeName = "numeric(8, 0)")]
        public decimal? Bultos { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("id_forwarding")]
        [StringLength(8)]
        public string IdForwarding { get; set; }
        [Column("factura_enviada")]
        [StringLength(1)]
        public string FacturaEnviada { get; set; }
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
        [Column("peso_libras", TypeName = "numeric(14, 3)")]
        public decimal? PesoLibras { get; set; }
        [Column("dias_demoras", TypeName = "numeric(3, 0)")]
        public decimal? DiasDemoras { get; set; }
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Column("fecha_contable", TypeName = "datetime")]
        public DateTime? FechaContable { get; set; }
        [Column("status_contable", TypeName = "numeric(1, 0)")]
        public decimal? StatusContable { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("id_factura_mex")]
        [StringLength(10)]
        public string IdFacturaMex { get; set; }
        [Column("fecha_fact_mex", TypeName = "datetime")]
        public DateTime? FechaFactMex { get; set; }
        [Column("distribuida")]
        [StringLength(1)]
        public string Distribuida { get; set; }
        [Column("numproy")]
        [StringLength(20)]
        public string Numproy { get; set; }
        [Column("poliza_contable", TypeName = "decimal(4, 0)")]
        public decimal? PolizaContable { get; set; }
        [Column("periodo_contable", TypeName = "decimal(6, 0)")]
        public decimal? PeriodoContable { get; set; }
        [Column("movimiento_contable", TypeName = "decimal(6, 0)")]
        public decimal? MovimientoContable { get; set; }
        [Column("usuario")]
        [StringLength(8)]
        public string Usuario { get; set; }
        [Column("grupo")]
        [StringLength(8)]
        public string Grupo { get; set; }
        [Column("numempresa")]
        public int? Numempresa { get; set; }
        [Column("prov_razon_social")]
        [StringLength(120)]
        public string ProvRazonSocial { get; set; }
        [Column("prov_calle")]
        [StringLength(80)]
        public string ProvCalle { get; set; }
        [Column("prov_numero")]
        [StringLength(10)]
        public string ProvNumero { get; set; }
        [Column("prov_colonia")]
        [StringLength(30)]
        public string ProvColonia { get; set; }
        [Column("prov_cp")]
        [StringLength(8)]
        public string ProvCp { get; set; }
        [Column("prov_id_municipio")]
        [StringLength(4)]
        public string ProvIdMunicipio { get; set; }
        [Column("fecha_cancelacion", TypeName = "datetime")]
        public DateTime? FechaCancelacion { get; set; }
        [Column("cve_flete", TypeName = "decimal(1, 0)")]
        public decimal? CveFlete { get; set; }
        [Column("cliente_destino")]
        [StringLength(120)]
        public string ClienteDestino { get; set; }
        [Column("id_escape")]
        public int? IdEscape { get; set; }
        [Column("id_tipo_vehic")]
        [StringLength(2)]
        public string IdTipoVehic { get; set; }
        [Column("prov_irs")]
        [StringLength(20)]
        public string ProvIrs { get; set; }
        [Column("horas_semaforo")]
        public int? HorasSemaforo { get; set; }
    }
}
