using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fseries")]
    public partial class Fseries
    {
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Autonumber { get; set; }
        [Required]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("num_secuencial", TypeName = "decimal(5, 4)")]
        public decimal NumSecuencial { get; set; }
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Required]
        [Column("serie")]
        [StringLength(20)]
        public string Serie { get; set; }
        [Column("id_pais_origen")]
        [StringLength(4)]
        public string IdPaisOrigen { get; set; }
    }
}
