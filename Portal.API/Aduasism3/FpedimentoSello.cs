using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_sello")]
    [Index(nameof(Rowguid), Name = "index_2085582468", IsUnique = true)]
    public partial class FpedimentoSello
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Key]
        [Column("numero_vehiculo")]
        [StringLength(15)]
        public string NumeroVehiculo { get; set; }
        [Key]
        [Column("sello")]
        [StringLength(21)]
        public string Sello { get; set; }
        [Column("marca")]
        [StringLength(30)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(8)]
        public string Modelo { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(5, 0)")]
        public decimal Consecutivo { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("cantidad_bultos", TypeName = "numeric(8, 0)")]
        public decimal? CantidadBultos { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("total_guias", TypeName = "numeric(3, 0)")]
        public decimal? TotalGuias { get; set; }
        [Column("num_ident_uni")]
        [StringLength(20)]
        public string NumIdentUni { get; set; }
        [Column("peso_kgs", TypeName = "decimal(14, 3)")]
        public decimal? PesoKgs { get; set; }
        [Column("observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
        [Column("granel")]
        [StringLength(3)]
        public string Granel { get; set; }
        [StringLength(20)]
        public string Transportista { get; set; }
        [StringLength(20)]
        public string Transfer { get; set; }
        [Column("Destino_Final")]
        [StringLength(15)]
        public string DestinoFinal { get; set; }
        [Column("Bodega_Dest")]
        [StringLength(15)]
        public string BodegaDest { get; set; }
        [Column("Hora_Ent_Doc", TypeName = "datetime")]
        public DateTime? HoraEntDoc { get; set; }
        [Column("Hora_Salio_Cruce", TypeName = "datetime")]
        public DateTime? HoraSalioCruce { get; set; }
        [Column("Hora_Adua_Mex", TypeName = "datetime")]
        public DateTime? HoraAduaMex { get; set; }
        [Column("Hora_Adua_Ame", TypeName = "datetime")]
        public DateTime? HoraAduaAme { get; set; }
        [Column("Hora_Entrega", TypeName = "datetime")]
        public DateTime? HoraEntrega { get; set; }
        [Column("id_embarque")]
        [StringLength(50)]
        public string IdEmbarque { get; set; }
        [Column("fecha_salida_origen", TypeName = "datetime")]
        public DateTime? FechaSalidaOrigen { get; set; }
        [Column("fecha_arribo_fron", TypeName = "datetime")]
        public DateTime? FechaArriboFron { get; set; }
        [Column("id_transportista_origen")]
        [StringLength(4)]
        public string IdTransportistaOrigen { get; set; }
        [Column("id_transportista_destino")]
        [StringLength(4)]
        public string IdTransportistaDestino { get; set; }
        [Column("fletes_remesa", TypeName = "numeric(11, 2)")]
        public decimal? FletesRemesa { get; set; }
        [Column("seguros_remesa", TypeName = "numeric(11, 2)")]
        public decimal? SegurosRemesa { get; set; }
        [Column("otros_remesa", TypeName = "numeric(11, 2)")]
        public decimal? OtrosRemesa { get; set; }
        [Column("embalajes_remesa", TypeName = "numeric(11, 2)")]
        public decimal? EmbalajesRemesa { get; set; }
        [Column("id_moneda_flete_rem")]
        [StringLength(4)]
        public string IdMonedaFleteRem { get; set; }
        [Column("id_moneda_seguro_rem")]
        [StringLength(4)]
        public string IdMonedaSeguroRem { get; set; }
        [Column("id_moneda_otros_rem")]
        [StringLength(4)]
        public string IdMonedaOtrosRem { get; set; }
        [Column("id_moneda_embalaje_rem")]
        [StringLength(4)]
        public string IdMonedaEmbalajeRem { get; set; }
        [Column("factor_flete_rem", TypeName = "numeric(10, 8)")]
        public decimal? FactorFleteRem { get; set; }
        [Column("factor_seguro_rem", TypeName = "numeric(10, 8)")]
        public decimal? FactorSeguroRem { get; set; }
        [Column("factor_otros_rem", TypeName = "numeric(10, 8)")]
        public decimal? FactorOtrosRem { get; set; }
        [Column("factor_embalaje_rem", TypeName = "numeric(10, 8)")]
        public decimal? FactorEmbalajeRem { get; set; }
        [Column("semana", TypeName = "numeric(3, 0)")]
        public decimal? Semana { get; set; }
        [Column("observaciones_texto", TypeName = "text")]
        public string ObservacionesTexto { get; set; }
        [Column("contacto")]
        [StringLength(30)]
        public string Contacto { get; set; }
        [Column("guia_mex")]
        [StringLength(10)]
        public string GuiaMex { get; set; }
        [Column("guia_ame")]
        [StringLength(10)]
        public string GuiaAme { get; set; }
        [Column("prefile")]
        [StringLength(20)]
        public string Prefile { get; set; }
        [Column("placas")]
        [StringLength(20)]
        public string Placas { get; set; }
        [Column("tipo_contenedor")]
        public short? TipoContenedor { get; set; }
        [Column("edocument")]
        [StringLength(13)]
        public string Edocument { get; set; }
        [Column("cve_entrada_aduana")]
        [StringLength(1)]
        public string CveEntradaAduana { get; set; }
        [Column("id_apoderado")]
        [StringLength(6)]
        public string IdApoderado { get; set; }
        [Column("guia")]
        [StringLength(20)]
        public string Guia { get; set; }
        [Column("campo12")]
        [StringLength(1)]
        public string Campo12 { get; set; }
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro_usuario", TypeName = "datetime")]
        public DateTime? FechaRegistroUsuario { get; set; }
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_registro_ult_modif", TypeName = "datetime")]
        public DateTime? FechaRegistroUltModif { get; set; }
        [Column("contingencia")]
        [StringLength(1)]
        public string Contingencia { get; set; }
    }
}
