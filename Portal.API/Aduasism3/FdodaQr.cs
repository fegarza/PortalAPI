using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdoda_qr")]
    public partial class FdodaQr
    {
        [Key]
        [Column("num_control")]
        [StringLength(10)]
        public string NumControl { get; set; }
        [Required]
        [Column("tipo_movimiento")]
        [StringLength(1)]
        public string TipoMovimiento { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("caat")]
        [StringLength(30)]
        public string Caat { get; set; }
        [Column("id_Transporte")]
        [StringLength(20)]
        public string IdTransporte { get; set; }
        [Column("fast_ID")]
        [StringLength(20)]
        public string FastId { get; set; }
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("certificado")]
        [StringLength(500)]
        public string Certificado { get; set; }
        [Column("cadena_original")]
        public string CadenaOriginal { get; set; }
        [Column("firma_electronica")]
        [StringLength(500)]
        public string FirmaElectronica { get; set; }
        [Column("numero_serie")]
        [StringLength(20)]
        public string NumeroSerie { get; set; }
        [Column("usuario")]
        [StringLength(13)]
        public string Usuario { get; set; }
        [Column("usuario_registro")]
        [StringLength(6)]
        public string UsuarioRegistro { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }
        [Column("usuario_ult_modif")]
        [StringLength(6)]
        public string UsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime? FechaUltModif { get; set; }
        [Column("fecha_registro_doda")]
        [StringLength(20)]
        public string FechaRegistroDoda { get; set; }
        [Column("mensaje")]
        [StringLength(500)]
        public string Mensaje { get; set; }
        [Column("numTransaccion")]
        [StringLength(50)]
        public string NumTransaccion { get; set; }
        [Column("fecha_resultado_doda")]
        [StringLength(20)]
        public string FechaResultadoDoda { get; set; }
        [Column("firmaElecSist")]
        [StringLength(500)]
        public string FirmaElecSist { get; set; }
        [Column("numIntegracion")]
        [StringLength(50)]
        public string NumIntegracion { get; set; }
        [Column("resultado")]
        [StringLength(500)]
        public string Resultado { get; set; }
        [Column("rfc_resultado")]
        [StringLength(13)]
        public string RfcResultado { get; set; }
        [Column("estatus")]
        [StringLength(20)]
        public string Estatus { get; set; }
        [Column("cadena_original_Sat")]
        public string CadenaOriginalSat { get; set; }
        [Column("sellado_sat")]
        public string SelladoSat { get; set; }
        [Column("numero_serie_sat")]
        public string NumeroSerieSat { get; set; }
        [Required]
        [Column("Tipo_figura")]
        [StringLength(1)]
        public string TipoFigura { get; set; }
        [Column("Id_apoderado")]
        [StringLength(6)]
        public string IdApoderado { get; set; }
        [Column("Id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("gafete_unico")]
        [StringLength(15)]
        public string GafeteUnico { get; set; }
        [Column("despacho_aduanero")]
        [StringLength(1)]
        public string DespachoAduanero { get; set; }
        [Column("buscado_MSA")]
        public bool? BuscadoMsa { get; set; }
        [Column("fecha_MSA", TypeName = "datetime")]
        public DateTime? FechaMsa { get; set; }
        [Column("fecha_buscado_MSA", TypeName = "datetime")]
        public DateTime? FechaBuscadoMsa { get; set; }
    }
}
