using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcarta_subdivision")]
    public partial class FcartaSubdivision
    {
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(36)]
        public string IdFactura { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(18, 0)")]
        public decimal Secuencial { get; set; }
        [Column("subdivision")]
        [StringLength(255)]
        public string Subdivision { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("id_apoderado")]
        [StringLength(6)]
        public string IdApoderado { get; set; }
        [Column("importe", TypeName = "decimal(14, 2)")]
        public decimal? Importe { get; set; }
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("cantidad", TypeName = "decimal(15, 3)")]
        public decimal? Cantidad { get; set; }
        [Column("importe_fletes", TypeName = "decimal(15, 2)")]
        public decimal? ImporteFletes { get; set; }
        [Column("importe_otros", TypeName = "decimal(15, 2)")]
        public decimal? ImporteOtros { get; set; }
    }
}
