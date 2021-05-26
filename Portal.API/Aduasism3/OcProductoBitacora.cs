using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_producto_bitacora")]
    public partial class OcProductoBitacora
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Key]
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Key]
        [Column("fecha_cambio", TypeName = "datetime")]
        public DateTime FechaCambio { get; set; }
        [Required]
        [Column("usuario_cambio")]
        [StringLength(6)]
        public string UsuarioCambio { get; set; }
        [Required]
        [Column("observaciones")]
        [StringLength(650)]
        public string Observaciones { get; set; }
        [Column("anotaciones")]
        [StringLength(1000)]
        public string Anotaciones { get; set; }
    }
}
