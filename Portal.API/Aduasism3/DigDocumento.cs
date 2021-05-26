using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("dig_documento")]
    public partial class DigDocumento
    {
        [Key]
        [Column("id_aplicacion")]
        [StringLength(10)]
        public string IdAplicacion { get; set; }
        [Key]
        [Column("id_documento")]
        public short IdDocumento { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(50)]
        public string DescripcionEn { get; set; }
        [Column("extension")]
        [StringLength(4)]
        public string Extension { get; set; }
        [Column("observaciones")]
        [StringLength(1000)]
        public string Observaciones { get; set; }
        [Column("interno")]
        public bool Interno { get; set; }
    }
}
