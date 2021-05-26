using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_pedimentos_externos")]
    public partial class FfgPedimentosExterno
    {
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("no_fracciones", TypeName = "numeric(3, 0)")]
        public decimal? NoFracciones { get; set; }
        [Column("valor_normal", TypeName = "numeric(12, 0)")]
        public decimal? ValorNormal { get; set; }
        [Column("difer_impuesto", TypeName = "numeric(12, 2)")]
        public decimal? DiferImpuesto { get; set; }
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("iva_pedimento", TypeName = "numeric(12, 0)")]
        public decimal? IvaPedimento { get; set; }
        [Column("fecha_pedi", TypeName = "datetime")]
        public DateTime? FechaPedi { get; set; }
        [Column("trans_pedi")]
        [StringLength(6)]
        public string TransPedi { get; set; }
        [Column("talon")]
        [StringLength(20)]
        public string Talon { get; set; }
        [Column("imp_exp")]
        [StringLength(1)]
        public string ImpExp { get; set; }
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("regimen")]
        [StringLength(2)]
        public string Regimen { get; set; }
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Column("fact_pedi")]
        [StringLength(15)]
        public string FactPedi { get; set; }
        [Column("origen")]
        [StringLength(2)]
        public string Origen { get; set; }
        [Column("marcas")]
        [StringLength(20)]
        public string Marcas { get; set; }
        [Column("numero_mcia")]
        [StringLength(15)]
        public string NumeroMcia { get; set; }
        [Column("descripcion_mcia")]
        [StringLength(250)]
        public string DescripcionMcia { get; set; }
        [Column("peso_mcia", TypeName = "numeric(14, 3)")]
        public decimal? PesoMcia { get; set; }
        [Column("bultos", TypeName = "numeric(8, 0)")]
        public decimal? Bultos { get; set; }
        [Column("id_cliente_pedi")]
        [StringLength(6)]
        public string IdClientePedi { get; set; }
        [Column("nombre_cli_pedi")]
        [StringLength(120)]
        public string NombreCliPedi { get; set; }
        [Column("rfc_cli_pedi")]
        [StringLength(13)]
        public string RfcCliPedi { get; set; }
        [Column("domici_cli_pedi")]
        [StringLength(80)]
        public string DomiciCliPedi { get; set; }
        [Column("colonia_cli_pedi")]
        [StringLength(30)]
        public string ColoniaCliPedi { get; set; }
        [Column("calle_numero_pedi")]
        [StringLength(10)]
        public string CalleNumeroPedi { get; set; }
        [Column("ciudad_cli_pedi")]
        [StringLength(40)]
        public string CiudadCliPedi { get; set; }
        [Column("estado_cli_pedi")]
        [StringLength(10)]
        public string EstadoCliPedi { get; set; }
        [Column("cp_cli_pedi")]
        [StringLength(10)]
        public string CpCliPedi { get; set; }
        [Column("id_agencia_aduanal")]
        [StringLength(4)]
        public string IdAgenciaAduanal { get; set; }
        [Column("aduana_razon_social")]
        [StringLength(40)]
        public string AduanaRazonSocial { get; set; }
        [Column("tipo_cambio_ped", TypeName = "numeric(9, 6)")]
        public decimal? TipoCambioPed { get; set; }
        [Column("factor_moneda", TypeName = "numeric(10, 8)")]
        public decimal? FactorMoneda { get; set; }
        [Column("valor_factura", TypeName = "numeric(12, 2)")]
        public decimal? ValorFactura { get; set; }
        [Column("prov_razon_social")]
        [StringLength(120)]
        public string ProvRazonSocial { get; set; }
        [Column("linea_razon_social")]
        [StringLength(40)]
        public string LineaRazonSocial { get; set; }
        [Column("destino_embarque")]
        [StringLength(120)]
        public string DestinoEmbarque { get; set; }
        [Column("municipio_embarque")]
        [StringLength(40)]
        public string MunicipioEmbarque { get; set; }
        [Column("cve_flete", TypeName = "decimal(1, 0)")]
        public decimal? CveFlete { get; set; }
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
        [Column("cve_trans")]
        [StringLength(2)]
        public string CveTrans { get; set; }
        [Column("cant_pedi", TypeName = "numeric(12, 0)")]
        public decimal? CantPedi { get; set; }
        [Column("observa_fact_prov")]
        [StringLength(255)]
        public string ObservaFactProv { get; set; }
        [Column("fecha_fact_prov", TypeName = "datetime")]
        public DateTime? FechaFactProv { get; set; }
        [Column("iva2_pedimento", TypeName = "decimal(18, 0)")]
        public decimal? Iva2Pedimento { get; set; }
        [Column("dta_pedimento", TypeName = "decimal(18, 0)")]
        public decimal? DtaPedimento { get; set; }
        [Column("adval_pedimento", TypeName = "decimal(18, 0)")]
        public decimal? AdvalPedimento { get; set; }
        [Column("otros_pedimento", TypeName = "decimal(18, 0)")]
        public decimal? OtrosPedimento { get; set; }
        [Column("suma_facturas", TypeName = "decimal(10, 0)")]
        public decimal? SumaFacturas { get; set; }
        [Column("suma_contenedores")]
        public int? SumaContenedores { get; set; }
        [Column("facturas")]
        [StringLength(250)]
        public string Facturas { get; set; }
    }
}
