using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcove")]
    public partial class Fcove
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("identificador", TypeName = "numeric(9, 0)")]
        public decimal Identificador { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal Consecutivo { get; set; }
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Column("rel_fac")]
        [StringLength(1)]
        public string RelFac { get; set; }
        [Column("subdivision")]
        [StringLength(1)]
        public string Subdivision { get; set; }
        [Column("tipo_identificador")]
        [StringLength(1)]
        public string TipoIdentificador { get; set; }
        [Column("fecha_expedicion", TypeName = "datetime")]
        public DateTime? FechaExpedicion { get; set; }
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
        [Column("certificado_origen", TypeName = "numeric(1, 0)")]
        public decimal? CertificadoOrigen { get; set; }
        [Column("num_export_confiable")]
        [StringLength(50)]
        public string NumExportConfiable { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Column("tax_id")]
        [StringLength(50)]
        public string TaxId { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("edocument")]
        [StringLength(13)]
        public string Edocument { get; set; }
        [Column("tipo_figura")]
        [StringLength(1)]
        public string TipoFigura { get; set; }
        [Column("curp_figura")]
        [StringLength(18)]
        public string CurpFigura { get; set; }
        [Column("firma_elec_ava", TypeName = "text")]
        public string FirmaElecAva { get; set; }
        [Column("numero_serie")]
        [StringLength(20)]
        public string NumeroSerie { get; set; }
        [Column("id_tipo_vehiculo")]
        [StringLength(2)]
        public string IdTipoVehiculo { get; set; }
        [Column("mensaje_transaccion")]
        [StringLength(100)]
        public string MensajeTransaccion { get; set; }
        [Column("numero_transaccion")]
        [StringLength(15)]
        public string NumeroTransaccion { get; set; }
        [Column("fecha_transaccion")]
        [StringLength(50)]
        public string FechaTransaccion { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime? FechaUltModif { get; set; }
        [Column("adenda")]
        [StringLength(13)]
        public string Adenda { get; set; }
        [Column("tipo_figura_cove")]
        [StringLength(1)]
        public string TipoFiguraCove { get; set; }
        [Column("id_apoderado")]
        [StringLength(6)]
        public string IdApoderado { get; set; }
        [Column("cadena_original")]
        public string CadenaOriginal { get; set; }
        [Column("rfc_consulta")]
        [StringLength(13)]
        public string RfcConsulta { get; set; }
        [Column("razon_social_consulta")]
        [StringLength(150)]
        public string RazonSocialConsulta { get; set; }
        [Column("certificado")]
        [StringLength(8000)]
        public string Certificado { get; set; }
        [Column("fecha_expedicion_remesa", TypeName = "datetime")]
        public DateTime? FechaExpedicionRemesa { get; set; }
    }
}
