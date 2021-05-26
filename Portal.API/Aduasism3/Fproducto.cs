using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fproducto")]
    [Index(nameof(Rowguid), Name = "index_1175727291", IsUnique = true)]
    public partial class Fproducto
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Key]
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("desc_abreviado")]
        [StringLength(16)]
        public string DescAbreviado { get; set; }
        [Column("descripcion_clas")]
        [StringLength(250)]
        public string DescripcionClas { get; set; }
        [Column("grs_azucar_x_kg", TypeName = "numeric(14, 3)")]
        public decimal? GrsAzucarXKg { get; set; }
        [Column("peso_neto_kgs", TypeName = "decimal(18, 6)")]
        public decimal? PesoNetoKgs { get; set; }
        [Column("peso_bruto_kgs", TypeName = "decimal(18, 6)")]
        public decimal? PesoBrutoKgs { get; set; }
        [Column("precio_unitario", TypeName = "numeric(16, 7)")]
        public decimal PrecioUnitario { get; set; }
        [Required]
        [Column("id_unidad")]
        [StringLength(5)]
        public string IdUnidad { get; set; }
        [Required]
        [Column("id_pais_origen")]
        [StringLength(4)]
        public string IdPaisOrigen { get; set; }
        [Required]
        [Column("cve_cert_origen")]
        [StringLength(1)]
        public string CveCertOrigen { get; set; }
        [Required]
        [Column("cve_carta_juram")]
        [StringLength(1)]
        public string CveCartaJuram { get; set; }
        [Required]
        [Column("cve_series")]
        [StringLength(1)]
        public string CveSeries { get; set; }
        [Required]
        [Column("cve_tlc")]
        [StringLength(1)]
        public string CveTlc { get; set; }
        [Column("criterio")]
        [StringLength(1)]
        public string Criterio { get; set; }
        [Column("costo_neto")]
        [StringLength(8)]
        public string CostoNeto { get; set; }
        [Column("origen_mercancia")]
        [StringLength(3)]
        public string OrigenMercancia { get; set; }
        [Column("fabricante")]
        [StringLength(1)]
        public string Fabricante { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Required]
        [Column("clasificado")]
        [StringLength(1)]
        public string Clasificado { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ult_modificacion", TypeName = "datetime")]
        public DateTime FechaUltModificacion { get; set; }
        [Required]
        [Column("id_usuario_ult_modificacion")]
        [StringLength(6)]
        public string IdUsuarioUltModificacion { get; set; }
        [Column("fecha_exp_carta", TypeName = "datetime")]
        public DateTime? FechaExpCarta { get; set; }
        [Column("folio")]
        [StringLength(15)]
        public string Folio { get; set; }
        [Column("anexo18", TypeName = "text")]
        public string Anexo18 { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("num_solicitud")]
        [StringLength(15)]
        public string NumSolicitud { get; set; }
        [Column("id_tipo_material")]
        [StringLength(2)]
        public string IdTipoMaterial { get; set; }
        [StringLength(1)]
        public string Activo { get; set; }
        [Column("con_iva")]
        [StringLength(1)]
        public string ConIva { get; set; }
        [Column("sku")]
        [StringLength(50)]
        public string Sku { get; set; }
        [Column("tipo_status")]
        [StringLength(1)]
        public string TipoStatus { get; set; }
        [Column("status")]
        [StringLength(30)]
        public string Status { get; set; }
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Column("autorizado")]
        [StringLength(1)]
        public string Autorizado { get; set; }
        [Column("ieps", TypeName = "decimal(5, 2)")]
        public decimal Ieps { get; set; }
        [Column("pesos_x_litro", TypeName = "decimal(10, 2)")]
        public decimal PesosXLitro { get; set; }
        [Column("hazmat")]
        [StringLength(1)]
        public string Hazmat { get; set; }
        [Column("un_number")]
        [StringLength(10)]
        public string UnNumber { get; set; }
        [Column("class")]
        [StringLength(5)]
        public string Class { get; set; }
        [Column("packing_group")]
        [StringLength(10)]
        public string PackingGroup { get; set; }
        [Column("marca")]
        [StringLength(100)]
        public string Marca { get; set; }
        [Column("req_num_serie")]
        [StringLength(1)]
        public string ReqNumSerie { get; set; }
        [Column("vulnerable")]
        [StringLength(1)]
        public string Vulnerable { get; set; }
        [Column("economia")]
        [StringLength(1)]
        public string Economia { get; set; }
        [Column("marca_registrada")]
        [StringLength(1)]
        public string MarcaRegistrada { get; set; }
        [Column("anexo27")]
        [StringLength(1)]
        public string Anexo27 { get; set; }
        [Column("restriccion_horario")]
        [StringLength(1)]
        public string RestriccionHorario { get; set; }
        [Column("anexo10")]
        [StringLength(1)]
        public string Anexo10 { get; set; }
        [Column("pref_criterio")]
        [StringLength(2)]
        public string PrefCriterio { get; set; }
        [Column("producer")]
        [StringLength(3)]
        public string Producer { get; set; }
        [Column("net_cost")]
        [StringLength(2)]
        public string NetCost { get; set; }
        [Column("co")]
        [StringLength(2)]
        public string Co { get; set; }
        [Column("hts_edi")]
        [StringLength(8)]
        public string HtsEdi { get; set; }
        [Column("regla_8va")]
        [StringLength(1)]
        public string Regla8va { get; set; }
        [Column("id_usuario_ult_mod_prod_activo")]
        [StringLength(6)]
        public string IdUsuarioUltModProdActivo { get; set; }
        [Column("fecha_ult_mod_prod_activo", TypeName = "datetime")]
        public DateTime? FechaUltModProdActivo { get; set; }
        [Column("prio_1")]
        [StringLength(1)]
        public string Prio1 { get; set; }
        [Column("prio_2")]
        [StringLength(1)]
        public string Prio2 { get; set; }
        [Column("prio_3")]
        [StringLength(1)]
        public string Prio3 { get; set; }
        [Column("complemento")]
        [StringLength(20)]
        public string Complemento { get; set; }
        [Column("tipo_moneda_ieps")]
        [StringLength(3)]
        public string TipoMonedaIeps { get; set; }
        [Column("tipo_ieps")]
        [StringLength(1)]
        public string TipoIeps { get; set; }
        [Column("descripcion_clasificacion_op_esp")]
        [StringLength(250)]
        public string DescripcionClasificacionOpEsp { get; set; }
    }
}
