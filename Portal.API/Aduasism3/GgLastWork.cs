using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("gg_last_work")]
    public partial class GgLastWork
    {
        [Key]
        [Column("usr_id")]
        [StringLength(8)]
        public string UsrId { get; set; }
        [Key]
        [Column("tipo_opc")]
        public int TipoOpc { get; set; }
        [Key]
        [Column("dato")]
        [StringLength(20)]
        public string Dato { get; set; }
        [Required]
        [Column("etiqueta")]
        [StringLength(100)]
        public string Etiqueta { get; set; }
        [Required]
        [Column("proy_relacion")]
        [StringLength(20)]
        public string ProyRelacion { get; set; }
    }
}
