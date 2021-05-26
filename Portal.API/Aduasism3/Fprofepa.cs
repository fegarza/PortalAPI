using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fprofepa")]
    [Index(nameof(Rowguid), Name = "index_461296753", IsUnique = true)]
    public partial class Fprofepa
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(5, 0)")]
        public decimal IdRectificacion { get; set; }
        [Required]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("consecutivo", TypeName = "numeric(5, 0)")]
        public decimal? Consecutivo { get; set; }
        [Required]
        [Column("inspectoria")]
        [StringLength(2)]
        public string Inspectoria { get; set; }
        [Required]
        [Column("delegacion")]
        [StringLength(2)]
        public string Delegacion { get; set; }
        [Column("transporte")]
        [StringLength(1)]
        public string Transporte { get; set; }
        [Column("cve_pago_der")]
        [StringLength(6)]
        public string CvePagoDer { get; set; }
        [Column("fra_pago_der")]
        [StringLength(3)]
        public string FraPagoDer { get; set; }
        [Column("monto_pago_der", TypeName = "decimal(14, 2)")]
        public decimal? MontoPagoDer { get; set; }
        [Column("fecha_pago_der", TypeName = "datetime")]
        public DateTime? FechaPagoDer { get; set; }
        [Required]
        [Column("tipo_rtv")]
        [StringLength(1)]
        public string TipoRtv { get; set; }
        [Column("cve_punto_insp")]
        [StringLength(6)]
        public string CvePuntoInsp { get; set; }
        [Column("objetivo_merc")]
        [StringLength(1)]
        public string ObjetivoMerc { get; set; }
        [Required]
        [Column("id_destinatario")]
        [StringLength(6)]
        public string IdDestinatario { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(120)]
        public string Nombre { get; set; }
        [Required]
        [Column("calle")]
        [StringLength(40)]
        public string Calle { get; set; }
        [Column("numero_ext")]
        [StringLength(10)]
        public string NumeroExt { get; set; }
        [Column("numero_int")]
        [StringLength(10)]
        public string NumeroInt { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(6)]
        public string IdMunicipio { get; set; }
        [Required]
        [Column("cve_pais")]
        [StringLength(3)]
        public string CvePais { get; set; }
        [Required]
        [Column("entidad")]
        [StringLength(3)]
        public string Entidad { get; set; }
        [Required]
        [Column("codigo_postal")]
        [StringLength(6)]
        public string CodigoPostal { get; set; }
        [Column("fecha_tramite", TypeName = "datetime")]
        public DateTime? FechaTramite { get; set; }
        [Column("folio")]
        [StringLength(8)]
        public string Folio { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
        [Column("descripcion_transporte")]
        [StringLength(30)]
        public string DescripcionTransporte { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("comprobante_tratamiento")]
        [StringLength(20)]
        public string ComprobanteTratamiento { get; set; }
        [Column("fecha_comprobante_tratamiento", TypeName = "datetime")]
        public DateTime? FechaComprobanteTratamiento { get; set; }
        [Column("certificado_origen")]
        [StringLength(20)]
        public string CertificadoOrigen { get; set; }
        [Column("fecha_certificado_origen", TypeName = "datetime")]
        public DateTime? FechaCertificadoOrigen { get; set; }
        [Column("no_identificacion")]
        [StringLength(20)]
        public string NoIdentificacion { get; set; }
        [Column("no_economico")]
        [StringLength(20)]
        public string NoEconomico { get; set; }
        [Column("placa")]
        [StringLength(20)]
        public string Placa { get; set; }
        [Column("firma")]
        [StringLength(20)]
        public string Firma { get; set; }
        [Column("colonia")]
        [StringLength(60)]
        public string Colonia { get; set; }
        [Column("dictamen_tecnico")]
        [StringLength(50)]
        public string DictamenTecnico { get; set; }
    }
}
