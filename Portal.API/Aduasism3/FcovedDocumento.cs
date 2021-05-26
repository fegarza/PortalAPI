using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcoved_documento")]
    public partial class FcovedDocumento
    {
        [Key]
        [Column("id_digitalizacion")]
        [StringLength(15)]
        public string IdDigitalizacion { get; set; }
        [Required]
        [Column("tipo_documento")]
        [StringLength(5)]
        public string TipoDocumento { get; set; }
        [Column("ruta_documento")]
        [StringLength(250)]
        public string RutaDocumento { get; set; }
        [Column("nombre_documento")]
        [StringLength(50)]
        public string NombreDocumento { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion")]
        public int? IdRectificacion { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("numero_tramite")]
        [StringLength(30)]
        public string NumeroTramite { get; set; }
        [Column("mensaje_transaccion")]
        [StringLength(150)]
        public string MensajeTransaccion { get; set; }
        [Column("edocument")]
        [StringLength(13)]
        public string Edocument { get; set; }
        [Column("fecha_transaccion")]
        [StringLength(50)]
        public string FechaTransaccion { get; set; }
        [Column("rfc_firma")]
        [StringLength(13)]
        public string RfcFirma { get; set; }
        [Column("rfc_consulta")]
        [StringLength(13)]
        public string RfcConsulta { get; set; }
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
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("numero_transaccion")]
        [StringLength(50)]
        public string NumeroTransaccion { get; set; }
        [Column("cadena_original")]
        public string CadenaOriginal { get; set; }
        [Column("firma_elec_ava", TypeName = "text")]
        public string FirmaElecAva { get; set; }
    }
}
