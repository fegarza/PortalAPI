using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_pedimento_factura")]
    [Index(nameof(Rowguid), Name = "index_449436675", IsUnique = true)]
    public partial class FrelPedimentoFactura
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("razon_social_proveedor")]
        [StringLength(120)]
        public string RazonSocialProveedor { get; set; }
        [Key]
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime FechaFactura { get; set; }
        [Column("id_tipo_factura")]
        [StringLength(4)]
        public string IdTipoFactura { get; set; }
        [Column("calle")]
        [StringLength(80)]
        public string Calle { get; set; }
        [Column("numero")]
        [StringLength(10)]
        public string Numero { get; set; }
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("municipio")]
        [StringLength(80)]
        public string Municipio { get; set; }
        [Column("estado")]
        [StringLength(40)]
        public string Estado { get; set; }
        [Column("irs_proveedor")]
        [StringLength(20)]
        public string IrsProveedor { get; set; }
        [Column("id_pais_origen")]
        [StringLength(3)]
        public string IdPaisOrigen { get; set; }
        [Column("cant_consolidada", TypeName = "numeric(17, 5)")]
        public decimal? CantConsolidada { get; set; }
        [Column("cve_bulto", TypeName = "numeric(1, 0)")]
        public decimal? CveBulto { get; set; }
        [Column("fob_destino")]
        [StringLength(20)]
        public string FobDestino { get; set; }
        [Column("cant_bulto", TypeName = "numeric(5, 0)")]
        public decimal? CantBulto { get; set; }
        [Column("ent_federativa")]
        [StringLength(3)]
        public string EntFederativa { get; set; }
        [Column("codigo_postal")]
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [Column("numero_interior")]
        [StringLength(10)]
        public string NumeroInterior { get; set; }
        [Column("vinculacion")]
        [StringLength(1)]
        public string Vinculacion { get; set; }
        [Column("valor_total_mcia", TypeName = "numeric(14, 2)")]
        public decimal? ValorTotalMcia { get; set; }
        [Column("moneda_facturacion")]
        [StringLength(3)]
        public string MonedaFacturacion { get; set; }
        [Column("factor", TypeName = "numeric(10, 8)")]
        public decimal? Factor { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(18, 0)")]
        public decimal Consecutivo { get; set; }
        [Column("consecutivo_factura", TypeName = "numeric(4, 0)")]
        public decimal? ConsecutivoFactura { get; set; }
        [Column("edocument")]
        [StringLength(13)]
        public string Edocument { get; set; }
        [Column("usuario_autoriza")]
        [StringLength(10)]
        public string UsuarioAutoriza { get; set; }
        [Column("fletes_incrementa", TypeName = "decimal(12, 2)")]
        public decimal? FletesIncrementa { get; set; }
        [Column("id_moneda_flete")]
        [StringLength(4)]
        public string IdMonedaFlete { get; set; }
        [Column("seguros_incrementa", TypeName = "decimal(12, 2)")]
        public decimal? SegurosIncrementa { get; set; }
        [Column("id_moneda_seguro")]
        [StringLength(4)]
        public string IdMonedaSeguro { get; set; }
        [Column("gastos_incrementa_dls", TypeName = "decimal(12, 2)")]
        public decimal? GastosIncrementaDls { get; set; }
        [Column("id_moneda_frontera")]
        [StringLength(4)]
        public string IdMonedaFrontera { get; set; }
        [Column("subdividida")]
        [StringLength(1)]
        public string Subdividida { get; set; }
        [Column("mas_pedimentos")]
        [StringLength(1)]
        public string MasPedimentos { get; set; }
        [Column("embalaje_incrementa", TypeName = "decimal(12, 2)")]
        public decimal? EmbalajeIncrementa { get; set; }
        [Column("id_moneda_embalaje")]
        [StringLength(4)]
        public string IdMonedaEmbalaje { get; set; }
        [Column("vessel")]
        [StringLength(10)]
        public string Vessel { get; set; }
        [Required]
        [Column("id_pack_list")]
        [StringLength(15)]
        public string IdPackList { get; set; }
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime? FechaUltModif { get; set; }
        [Column("cfdi")]
        [StringLength(1)]
        public string Cfdi { get; set; }
        [Column("contingencia")]
        [StringLength(1)]
        public string Contingencia { get; set; }
        [Column("factura_aux")]
        [StringLength(36)]
        public string FacturaAux { get; set; }
        [Column("complemento")]
        [StringLength(1)]
        public string Complemento { get; set; }
        [Column("proveedor_certifica")]
        [StringLength(50)]
        public string ProveedorCertifica { get; set; }
    }
}
