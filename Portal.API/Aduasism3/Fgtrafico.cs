using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fgtrafico")]
    [Index(nameof(IdCliente), nameof(CveTipoOperacion), nameof(IdEmbarque), nameof(IdBodega), Name = "Indx_fgtrafico_id_cliente_cve_id_embarque_id_bodega")]
    [Index(nameof(IdEmbarque), Name = "Indx_fgtrafico_id_embarque")]
    [Index(nameof(IdReferencia), Name = "Indx_fgtrafico_id_referencia")]
    [Index(nameof(IdReferencia), nameof(IdRectificacion), Name = "Indx_fgtrafico_id_referencia_id_rectificacion")]
    [Index(nameof(Rowguid), Name = "index_91147370", IsUnique = true)]
    public partial class Fgtrafico
    {
        public Fgtrafico()
        {
            FrelTrafPerms = new HashSet<FrelTrafPerm>();
        }

        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
        [Required]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion_aduana")]
        [StringLength(1)]
        public string SeccionAduana { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("factor_actualizacion", TypeName = "numeric(10, 8)")]
        public decimal FactorActualizacion { get; set; }
        [Column("id_pedimento")]
        [StringLength(7)]
        public string IdPedimento { get; set; }
        [Required]
        [Column("id_pais_origen")]
        [StringLength(4)]
        public string IdPaisOrigen { get; set; }
        [Required]
        [Column("id_pais_vendedor")]
        [StringLength(4)]
        public string IdPaisVendedor { get; set; }
        [Column("peso_tot_bruto", TypeName = "numeric(14, 3)")]
        public decimal PesoTotBruto { get; set; }
        [Column("increm_flete", TypeName = "numeric(12, 2)")]
        public decimal? IncremFlete { get; set; }
        [Column("increm_seguro", TypeName = "numeric(12, 2)")]
        public decimal? IncremSeguro { get; set; }
        [Column("no_inc_flete", TypeName = "numeric(12, 2)")]
        public decimal? NoIncFlete { get; set; }
        [Column("no_inc_seguro", TypeName = "numeric(12, 2)")]
        public decimal? NoIncSeguro { get; set; }
        [Column("otros_gastos_m_e", TypeName = "numeric(12, 2)")]
        public decimal? OtrosGastosME { get; set; }
        [Column("otros_gastos_dlls", TypeName = "numeric(12, 2)")]
        public decimal? OtrosGastosDlls { get; set; }
        [Column("anexo_pedimento", TypeName = "text")]
        public string AnexoPedimento { get; set; }
        [Column("observaciones_cte", TypeName = "text")]
        public string ObservacionesCte { get; set; }
        [Column("observaciones_operativas", TypeName = "text")]
        public string ObservacionesOperativas { get; set; }
        [Column("factor_me_pais_origen", TypeName = "numeric(10, 8)")]
        public decimal FactorMePaisOrigen { get; set; }
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime FechaReg { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Column("observacion_pedim")]
        [StringLength(250)]
        public string ObservacionPedim { get; set; }
        [Column("no_poliza")]
        [StringLength(8)]
        public string NoPoliza { get; set; }
        [Required]
        [Column("marca")]
        [StringLength(20)]
        public string Marca { get; set; }
        [Column("situacion")]
        [StringLength(1)]
        public string Situacion { get; set; }
        [Column("valor_factura", TypeName = "numeric(12, 2)")]
        public decimal? ValorFactura { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("factura_pack_list")]
        [StringLength(1)]
        public string FacturaPackList { get; set; }
        [Column("id_tipo_pedimento")]
        [StringLength(2)]
        public string IdTipoPedimento { get; set; }
        [Column("id_moneda_comercial")]
        [StringLength(4)]
        public string IdMonedaComercial { get; set; }
        [Column("id_moneda_flete")]
        [StringLength(4)]
        public string IdMonedaFlete { get; set; }
        [Column("factor_flete", TypeName = "numeric(10, 8)")]
        public decimal? FactorFlete { get; set; }
        [Column("id_moneda_seguro")]
        [StringLength(4)]
        public string IdMonedaSeguro { get; set; }
        [Column("factor_seguro", TypeName = "numeric(10, 8)")]
        public decimal? FactorSeguro { get; set; }
        [Column("id_moneda_otros")]
        [StringLength(4)]
        public string IdMonedaOtros { get; set; }
        [Column("factor_otros", TypeName = "numeric(10, 8)")]
        public decimal? FactorOtros { get; set; }
        [Column("id_moneda_frontera")]
        [StringLength(4)]
        public string IdMonedaFrontera { get; set; }
        [Column("factor_frontera", TypeName = "numeric(10, 8)")]
        public decimal? FactorFrontera { get; set; }
        [Column("id_moneda_flete_ni")]
        [StringLength(4)]
        public string IdMonedaFleteNi { get; set; }
        [Column("factor_flete_ni", TypeName = "numeric(10, 8)")]
        public decimal? FactorFleteNi { get; set; }
        [Column("id_moneda_seguro_ni")]
        [StringLength(4)]
        public string IdMonedaSeguroNi { get; set; }
        [Column("factor_seguro_ni", TypeName = "numeric(10, 8)")]
        public decimal? FactorSeguroNi { get; set; }
        [Column("clasificador")]
        [StringLength(6)]
        public string Clasificador { get; set; }
        [Column("fecha_clasificacion", TypeName = "datetime")]
        public DateTime? FechaClasificacion { get; set; }
        [Column("clasficacion_modif")]
        [StringLength(6)]
        public string ClasficacionModif { get; set; }
        [Column("fecha_modif", TypeName = "datetime")]
        public DateTime? FechaModif { get; set; }
        [Column("remesa")]
        [StringLength(15)]
        public string Remesa { get; set; }
        [Column("fecha_doctos", TypeName = "datetime")]
        public DateTime? FechaDoctos { get; set; }
        [Column("cve_flete", TypeName = "numeric(1, 0)")]
        public decimal? CveFlete { get; set; }
        [Column("id_situacion", TypeName = "numeric(4, 0)")]
        public decimal? IdSituacion { get; set; }
        [Column("otros_gastos_bod", TypeName = "numeric(12, 2)")]
        public decimal? OtrosGastosBod { get; set; }
        [Column("id_moneda_otros_bod")]
        [StringLength(4)]
        public string IdMonedaOtrosBod { get; set; }
        [Column("factor_otros_bod", TypeName = "numeric(10, 8)")]
        public decimal? FactorOtrosBod { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("id_consignatario")]
        [StringLength(10)]
        public string IdConsignatario { get; set; }
        [Column("tipo_opn")]
        [StringLength(1)]
        public string TipoOpn { get; set; }
        [Column("status_trafico")]
        public short? StatusTrafico { get; set; }
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Column("referencia_aux")]
        [StringLength(50)]
        public string ReferenciaAux { get; set; }
        [Column("entry_number")]
        [StringLength(15)]
        public string EntryNumber { get; set; }
        [Column("fecha_ult_doc_rec", TypeName = "datetime")]
        public DateTime? FechaUltDocRec { get; set; }
        [Column("inbond")]
        [StringLength(1)]
        public string Inbond { get; set; }
        [Column("plant_code")]
        [StringLength(4)]
        public string PlantCode { get; set; }
        [Column("prorrateo")]
        [StringLength(1)]
        public string Prorrateo { get; set; }
        [Column("op_especial")]
        [StringLength(1)]
        public string OpEspecial { get; set; }
        [Column("trafico_vulnerable")]
        [StringLength(1)]
        public string TraficoVulnerable { get; set; }
        [Column("fecha_vulnerable", TypeName = "datetime")]
        public DateTime? FechaVulnerable { get; set; }

        [ForeignKey(nameof(IdUsuario))]
        [InverseProperty(nameof(Fusuario.Fgtraficos))]
        public virtual Fusuario IdUsuarioNavigation { get; set; }
        [InverseProperty("IdTraficoNavigation")]
        public virtual FbultoTraf FbultoTraf { get; set; }
        [InverseProperty(nameof(FrelTrafPerm.IdTraficoNavigation))]
        public virtual ICollection<FrelTrafPerm> FrelTrafPerms { get; set; }
    }
}
