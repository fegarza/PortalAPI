using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_configuracion_parametro")]
    public partial class WrConfiguracionParametro
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_configuracion")]
        public int IdConfiguracion { get; set; }
        [Key]
        [Column("parametro")]
        [StringLength(50)]
        public string Parametro { get; set; }
        [Column("valor")]
        [StringLength(255)]
        public string Valor { get; set; }
        [Column("requerido")]
        public bool Requerido { get; set; }
    }
}
