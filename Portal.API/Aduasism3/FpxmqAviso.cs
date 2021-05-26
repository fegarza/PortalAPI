using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpxmq_avisos")]
    public partial class FpxmqAviso
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("RFC")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("folio_aviso")]
        [StringLength(8)]
        public string FolioAviso { get; set; }
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("tipo_traslado")]
        [StringLength(1)]
        public string TipoTraslado { get; set; }
        [Column("tipo_programa")]
        [StringLength(4)]
        public string TipoPrograma { get; set; }
        [Column("numero_programa")]
        [StringLength(10)]
        public string NumeroPrograma { get; set; }
        [Column("planta_origen")]
        [StringLength(4)]
        public string PlantaOrigen { get; set; }
        [Column("rfc_destino")]
        [StringLength(13)]
        public string RfcDestino { get; set; }
        [Column("tipo_programa_destino")]
        [StringLength(2)]
        public string TipoProgramaDestino { get; set; }
        [Column("numero_programa_destino")]
        [StringLength(10)]
        public string NumeroProgramaDestino { get; set; }
        [Column("planta_destino")]
        [StringLength(4)]
        public string PlantaDestino { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Column("firma")]
        [StringLength(250)]
        public string Firma { get; set; }
        [Column("num_serie")]
        [StringLength(45)]
        public string NumSerie { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("curp")]
        [StringLength(18)]
        public string Curp { get; set; }
        [Column("acuse")]
        [StringLength(8)]
        public string Acuse { get; set; }
        [Column("movimiento")]
        [StringLength(2)]
        public string Movimiento { get; set; }
        [Column("id_cliente_trans")]
        [StringLength(6)]
        public string IdClienteTrans { get; set; }
        [Column("razon_social_trans")]
        [StringLength(120)]
        public string RazonSocialTrans { get; set; }
        [Column("id_cliente_rec")]
        [StringLength(6)]
        public string IdClienteRec { get; set; }
        [Column("razon_social_rec")]
        [StringLength(120)]
        public string RazonSocialRec { get; set; }
        [Required]
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_ult_modif")]
        [StringLength(6)]
        public string IdUsuarioUltModif { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
    }
}
