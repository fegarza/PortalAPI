using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frelacion_documentos_full")]
    public partial class FrelacionDocumentosFull
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("fecha_emision", TypeName = "datetime")]
        public DateTime? FechaEmision { get; set; }
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("CAAT")]
        [StringLength(6)]
        public string Caat { get; set; }
        [Required]
        [Column("contenedor1")]
        [StringLength(20)]
        public string Contenedor1 { get; set; }
        [Required]
        [Column("contenedor2")]
        [StringLength(20)]
        public string Contenedor2 { get; set; }
        [Required]
        [Column("contenedor3")]
        [StringLength(20)]
        public string Contenedor3 { get; set; }
        [Required]
        [Column("contenedor4")]
        [StringLength(20)]
        public string Contenedor4 { get; set; }
        [Column("contenedor1_tipo")]
        public short? Contenedor1Tipo { get; set; }
        [Column("contenedor2_tipo")]
        public short? Contenedor2Tipo { get; set; }
        [Column("contenedor3_tipo")]
        public short? Contenedor3Tipo { get; set; }
        [Column("contenedor4_tipo")]
        public short? Contenedor4Tipo { get; set; }
    }
}
