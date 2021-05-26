using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_metodo_pago")]
    public partial class FfgMetodoPago
    {
        [Key]
        [Column("id_metodo_pago")]
        public int IdMetodoPago { get; set; }
        [Required]
        [Column("descripcion_metpago")]
        [StringLength(100)]
        public string DescripcionMetpago { get; set; }
        [Column("clave_SAT_metodo_pago")]
        [StringLength(2)]
        public string ClaveSatMetodoPago { get; set; }
    }
}
