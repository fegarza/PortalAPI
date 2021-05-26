using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_status_recibo")]
    public partial class OcStatusRecibo
    {
        [Key]
        [Column("status_recibo")]
        public short StatusRecibo { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(30)]
        public string Descripcion { get; set; }
        [Required]
        [Column("descripcion_en")]
        [StringLength(30)]
        public string DescripcionEn { get; set; }
        [Column("afecta_inventario")]
        public bool AfectaInventario { get; set; }
    }
}
