using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_esquema_factura_electronica")]
    public partial class FfgEsquemaFacturaElectronica
    {
        [Key]
        [Column("version")]
        [StringLength(50)]
        public string Version { get; set; }
        [Column("esquema")]
        [StringLength(255)]
        public string Esquema { get; set; }
        [Column("fecha_inicial_vigencia", TypeName = "datetime")]
        public DateTime FechaInicialVigencia { get; set; }
        [Column("fecha_final_vigencia", TypeName = "datetime")]
        public DateTime FechaFinalVigencia { get; set; }
        [Column("activo")]
        [StringLength(1)]
        public string Activo { get; set; }
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
    }
}
