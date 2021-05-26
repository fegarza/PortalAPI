using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdespacho")]
    public partial class Fdespacho
    {
        [Key]
        [Column("num_control")]
        [StringLength(30)]
        public string NumControl { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Column("tipo_movimiento")]
        [StringLength(1)]
        public string TipoMovimiento { get; set; }
        [Required]
        [Column("clave_transportista")]
        [StringLength(4)]
        public string ClaveTransportista { get; set; }
        [Column("medio_transporte", TypeName = "numeric(2, 0)")]
        public decimal? MedioTransporte { get; set; }
        [Column("numero_gafete", TypeName = "numeric(8, 0)")]
        public decimal? NumeroGafete { get; set; }
        [Column("numero_tarjeta_fast")]
        [StringLength(50)]
        public string NumeroTarjetaFast { get; set; }
        [Column("numero_oitn")]
        [StringLength(50)]
        public string NumeroOitn { get; set; }
        [Column("calificador_itn")]
        [StringLength(50)]
        public string CalificadorItn { get; set; }
        [Column("cadena_original", TypeName = "text")]
        public string CadenaOriginal { get; set; }
        [Column("firma_electronica", TypeName = "text")]
        public string FirmaElectronica { get; set; }
        [Column("codigo_respuesta")]
        [StringLength(4)]
        public string CodigoRespuesta { get; set; }
        [Column("numero_operacion")]
        [StringLength(14)]
        public string NumeroOperacion { get; set; }
        [Column("eDespacho")]
        [StringLength(25)]
        public string EDespacho { get; set; }
        [Column("descripcion_error")]
        [StringLength(100)]
        public string DescripcionError { get; set; }
        [Column("dato_erroneo")]
        [StringLength(100)]
        public string DatoErroneo { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
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
        [Column("id_tipo_pedimento")]
        [StringLength(2)]
        public string IdTipoPedimento { get; set; }
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
    }
}
