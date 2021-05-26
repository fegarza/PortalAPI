using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_detalle_error")]
    public partial class OcDetalleError
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
        [Column("orden_compra")]
        [StringLength(15)]
        public string OrdenCompra { get; set; }
        [Key]
        [Column("posicion")]
        public int Posicion { get; set; }
        [Key]
        [Column("nombre_archivo")]
        [StringLength(50)]
        public string NombreArchivo { get; set; }
        [Column("fecha_proceso", TypeName = "datetime")]
        public DateTime FechaProceso { get; set; }
        [Required]
        [Column("observaciones")]
        [StringLength(300)]
        public string Observaciones { get; set; }
    }
}
