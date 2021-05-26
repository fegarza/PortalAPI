using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_bod_producto")]
    public partial class FrelBodProducto
    {
        [Key]
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Key]
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Required]
        [Column("seccion")]
        [StringLength(8)]
        public string Seccion { get; set; }
        [Column("existencia", TypeName = "numeric(10, 4)")]
        public decimal Existencia { get; set; }
        [Column("costo_promedio", TypeName = "numeric(14, 4)")]
        public decimal CostoPromedio { get; set; }
        [Column("fecha_ult_costeo", TypeName = "datetime")]
        public DateTime FechaUltCosteo { get; set; }
        [Column("fecha_ult_inv_fisico", TypeName = "datetime")]
        public DateTime FechaUltInvFisico { get; set; }
        [Column("fecha_ult_entrada", TypeName = "datetime")]
        public DateTime FechaUltEntrada { get; set; }
        [Column("fecha_ult_salida", TypeName = "datetime")]
        public DateTime FechaUltSalida { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime FechaRegistro { get; set; }
        [Required]
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ult_modif", TypeName = "datetime")]
        public DateTime FechaUltModif { get; set; }
        [Required]
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
    }
}
