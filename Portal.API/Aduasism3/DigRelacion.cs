using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("dig_relacion")]
    public partial class DigRelacion
    {
        [Key]
        [Column("id_aplicacion_master")]
        [StringLength(10)]
        public string IdAplicacionMaster { get; set; }
        [Key]
        [Column("id_modulo_master")]
        [StringLength(20)]
        public string IdModuloMaster { get; set; }
        [Key]
        [Column("id_referencia_master")]
        [StringLength(100)]
        public string IdReferenciaMaster { get; set; }
        [Key]
        [Column("id_aplicacion")]
        [StringLength(10)]
        public string IdAplicacion { get; set; }
        [Key]
        [Column("id_modulo")]
        [StringLength(20)]
        public string IdModulo { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(100)]
        public string IdReferencia { get; set; }
        [Required]
        [Column("referencia")]
        [StringLength(50)]
        public string Referencia { get; set; }
    }
}
