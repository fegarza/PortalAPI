using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_status_movimiento")]
    public partial class OcStatusMovimiento
    {
        [Key]
        [Column("id_status_movimiento")]
        public short IdStatusMovimiento { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(50)]
        public string DescripcionEn { get; set; }
    }
}
