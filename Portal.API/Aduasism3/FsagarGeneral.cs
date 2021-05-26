using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fsagar_general")]
    [Index(nameof(Rowguid), Name = "index_2043206379", IsUnique = true)]
    public partial class FsagarGeneral
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("razon_social_cliente")]
        [StringLength(120)]
        public string RazonSocialCliente { get; set; }
        [Required]
        [Column("calle_cliente")]
        [StringLength(80)]
        public string CalleCliente { get; set; }
        [Required]
        [Column("numero_cliente")]
        [StringLength(10)]
        public string NumeroCliente { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Required]
        [Column("municipio_cliente")]
        [StringLength(80)]
        public string MunicipioCliente { get; set; }
        [Required]
        [Column("estado")]
        [StringLength(40)]
        public string Estado { get; set; }
        [Required]
        [Column("cp_cliente")]
        [StringLength(10)]
        public string CpCliente { get; set; }
        [Column("fecha_tramite", TypeName = "datetime")]
        public DateTime FechaTramite { get; set; }
        [Required]
        [Column("tipo_certificado")]
        [StringLength(1)]
        public string TipoCertificado { get; set; }
        [Required]
        [Column("certificado")]
        [StringLength(6)]
        public string Certificado { get; set; }
        [Required]
        [Column("ruta", TypeName = "text")]
        public string Ruta { get; set; }
        [Required]
        [Column("vehiculo")]
        [StringLength(100)]
        public string Vehiculo { get; set; }
        [Required]
        [Column("matricula")]
        [StringLength(17)]
        public string Matricula { get; set; }
        [Required]
        [Column("flejes")]
        [StringLength(25)]
        public string Flejes { get; set; }
        [Column("duracion", TypeName = "decimal(6, 0)")]
        public decimal Duracion { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(10)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Column("leyenda", TypeName = "text")]
        public string Leyenda { get; set; }
        [Column("vigencia", TypeName = "datetime")]
        public DateTime? Vigencia { get; set; }
        [Column("colonia")]
        [StringLength(60)]
        public string Colonia { get; set; }
        [Column("firma_sagar")]
        [StringLength(8)]
        public string FirmaSagar { get; set; }
        [Column("cve_municipio")]
        [StringLength(5)]
        public string CveMunicipio { get; set; }
        [Column("secuencial", TypeName = "decimal(4, 0)")]
        public decimal? Secuencial { get; set; }
        [Column("entidad_federativa")]
        [StringLength(3)]
        public string EntidadFederativa { get; set; }
        [Column("telefono")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column("guia_orden")]
        [StringLength(30)]
        public string GuiaOrden { get; set; }
        [Column("permiso")]
        [StringLength(17)]
        public string Permiso { get; set; }
        [Column("transportista")]
        [StringLength(80)]
        public string Transportista { get; set; }
        [Column("cve_transporte")]
        [StringLength(2)]
        public string CveTransporte { get; set; }
        [Column("planta")]
        [StringLength(13)]
        public string Planta { get; set; }
        [Column("cordon_norte")]
        [StringLength(2)]
        public string CordonNorte { get; set; }
        [Column("cordon_centro")]
        [StringLength(2)]
        public string CordonCentro { get; set; }
        [Column("cordon_sur")]
        [StringLength(2)]
        public string CordonSur { get; set; }
        [Column("cordon_istmo")]
        [StringLength(2)]
        public string CordonIstmo { get; set; }
        [Column("cordon_peninsular")]
        [StringLength(2)]
        public string CordonPeninsular { get; set; }
        [Column("folio_certificado")]
        [StringLength(16)]
        public string FolioCertificado { get; set; }
        [Column("municipio_imp")]
        [StringLength(50)]
        public string MunicipioImp { get; set; }
        [Column("colonia_imp")]
        [StringLength(60)]
        public string ColoniaImp { get; set; }
        [Column("clave_oisa")]
        [StringLength(3)]
        public string ClaveOisa { get; set; }
        [Column("clave_oisa_base")]
        [StringLength(2)]
        public string ClaveOisaBase { get; set; }
        [Column("tipo_insp")]
        [StringLength(2)]
        public string TipoInsp { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("cant_carros", TypeName = "numeric(3, 0)")]
        public decimal? CantCarros { get; set; }
        [Column("numeroint_cliente")]
        [StringLength(15)]
        public string NumerointCliente { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("validacion")]
        [StringLength(1)]
        public string Validacion { get; set; }
        [Column("siglas_aaa")]
        [StringLength(10)]
        public string SiglasAaa { get; set; }
        [Column("empresa")]
        [StringLength(10)]
        public string Empresa { get; set; }
        [Column("tipo_op_mov")]
        [StringLength(2)]
        public string TipoOpMov { get; set; }
        [Column("firma")]
        [StringLength(200)]
        public string Firma { get; set; }
        [Column("ucon")]
        [StringLength(11)]
        public string Ucon { get; set; }
        [Column("medico", TypeName = "numeric(5, 0)")]
        public decimal? Medico { get; set; }
        [Column("presentacion")]
        [StringLength(1)]
        public string Presentacion { get; set; }
        [Column("cantidad_presen", TypeName = "numeric(4, 0)")]
        public decimal? CantidadPresen { get; set; }
        [Column("tipo_presen")]
        [StringLength(1)]
        public string TipoPresen { get; set; }
        [Column("referencia_consolidado")]
        [StringLength(10)]
        public string ReferenciaConsolidado { get; set; }
        [Column("id_usuario_gen")]
        [StringLength(6)]
        public string IdUsuarioGen { get; set; }
        [Column("id_usuario_ult_gen")]
        [StringLength(6)]
        public string IdUsuarioUltGen { get; set; }
        [Column("fecha_gen", TypeName = "datetime")]
        public DateTime? FechaGen { get; set; }
        [Column("fecha_ult_gen", TypeName = "datetime")]
        public DateTime? FechaUltGen { get; set; }
        [Column("ruta_archivo_sagar")]
        [StringLength(200)]
        public string RutaArchivoSagar { get; set; }
        [Column("tipo_modalidad")]
        [StringLength(2)]
        public string TipoModalidad { get; set; }
        [Column("folio_original")]
        [StringLength(16)]
        public string FolioOriginal { get; set; }
    }
}
