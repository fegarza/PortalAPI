using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_packing_detalle_bitacora")]
    public partial class OcPackingDetalleBitacora
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Key]
        [Column("id_packing")]
        [StringLength(15)]
        public string IdPacking { get; set; }
        [Key]
        [Column("secuencial_packing")]
        public int SecuencialPacking { get; set; }
        [Key]
        [Column("fecha_cambio", TypeName = "datetime")]
        public DateTime FechaCambio { get; set; }
        [Required]
        [Column("usuario_cambio")]
        [StringLength(6)]
        public string UsuarioCambio { get; set; }
        [Required]
        [Column("observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
    }
}
