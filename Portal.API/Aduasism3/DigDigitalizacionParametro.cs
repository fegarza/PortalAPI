using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("dig_digitalizacion_parametro")]
    public partial class DigDigitalizacionParametro
    {
        [Key]
        [Column("id_aplicacion")]
        [StringLength(10)]
        public string IdAplicacion { get; set; }
        [Key]
        [Column("id_documento")]
        public short IdDocumento { get; set; }
        [Key]
        [Column("id_digitalizacion")]
        [StringLength(20)]
        public string IdDigitalizacion { get; set; }
        [Key]
        [Column("id_parametro")]
        [StringLength(20)]
        public string IdParametro { get; set; }
        [Column("orden")]
        public short Orden { get; set; }
        [Column("separador")]
        [StringLength(1)]
        public string Separador { get; set; }
        [Column("valor")]
        [StringLength(50)]
        public string Valor { get; set; }
    }
}
