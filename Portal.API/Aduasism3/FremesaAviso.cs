using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fremesa_aviso")]
    public partial class FremesaAviso
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(5, 0)")]
        public decimal Consecutivo { get; set; }
        [Column("tipo_aviso")]
        [StringLength(4)]
        public string TipoAviso { get; set; }
        [Column("movimiento")]
        [StringLength(2)]
        public string Movimiento { get; set; }
        [Column("acuse_validacion")]
        [StringLength(8)]
        public string AcuseValidacion { get; set; }
        [Column("rfc_transportista")]
        [StringLength(13)]
        public string RfcTransportista { get; set; }
        [Column("placas")]
        [StringLength(10)]
        public string Placas { get; set; }
        [Column("NIU")]
        [StringLength(13)]
        public string Niu { get; set; }
        [Column("identificador_guia")]
        [StringLength(1)]
        public string IdentificadorGuia { get; set; }
        [Column("numero_economico")]
        [StringLength(15)]
        public string NumeroEconomico { get; set; }
        [Required]
        [Column("firma_electronica")]
        [StringLength(300)]
        public string FirmaElectronica { get; set; }
        [Required]
        [Column("nombre_archivo")]
        [StringLength(12)]
        public string NombreArchivo { get; set; }
        [Column("fecha_firma", TypeName = "datetime")]
        public DateTime? FechaFirma { get; set; }
        [Column("unidad_medida")]
        [StringLength(3)]
        public string UnidadMedida { get; set; }
        [Column("cantidad", TypeName = "decimal(15, 3)")]
        public decimal? Cantidad { get; set; }
        [Column("seciit")]
        [StringLength(1)]
        public string Seciit { get; set; }
    }
}
