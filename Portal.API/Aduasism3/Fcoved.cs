using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcoved")]
    public partial class Fcoved
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(9, 0)")]
        public decimal Secuencial { get; set; }
        [Key]
        [Column("tipo_documento")]
        [StringLength(5)]
        public string TipoDocumento { get; set; }
        [Column("ruta_nombre_archivo")]
        [StringLength(250)]
        public string RutaNombreArchivo { get; set; }
        [Column("numero_transaccion")]
        [StringLength(50)]
        public string NumeroTransaccion { get; set; }
        [Column("fecha_transaccion")]
        [StringLength(50)]
        public string FechaTransaccion { get; set; }
        [Column("mensaje_transaccion")]
        [StringLength(150)]
        public string MensajeTransaccion { get; set; }
        [Column("edocument")]
        [StringLength(13)]
        public string Edocument { get; set; }
        [Column("nombre_documento")]
        [StringLength(50)]
        public string NombreDocumento { get; set; }
        [Column("numero_tramite")]
        [StringLength(30)]
        public string NumeroTramite { get; set; }
        [Column("rfc_firma")]
        [StringLength(13)]
        public string RfcFirma { get; set; }
        [Column("rfc_consulta")]
        [StringLength(13)]
        public string RfcConsulta { get; set; }
        [Column("cadena_original")]
        public string CadenaOriginal { get; set; }
        [Column("firma_elec_ava")]
        public string FirmaElecAva { get; set; }
        [Column("consecutivo_control")]
        public int? ConsecutivoControl { get; set; }
        [Column("digitalizado_control")]
        [StringLength(1)]
        public string DigitalizadoControl { get; set; }
        [Column("consecutivo_xml_control")]
        public int? ConsecutivoXmlControl { get; set; }
        [Column("id_apoderado")]
        [StringLength(1)]
        public string IdApoderado { get; set; }
        [Column("ruta_edocuments")]
        [StringLength(250)]
        public string RutaEdocuments { get; set; }
    }
}
