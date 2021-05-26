using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_serie")]
    public partial class OcSerie
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
        [Column("serie_orden_compra")]
        [StringLength(2)]
        public string SerieOrdenCompra { get; set; }
        [Key]
        [Column("compania")]
        [StringLength(4)]
        public string Compania { get; set; }
        [Required]
        [Column("division")]
        [StringLength(2)]
        public string Division { get; set; }
        [Required]
        [Column("unidad_negocio")]
        [StringLength(4)]
        public string UnidadNegocio { get; set; }
        [Required]
        [Column("grupo_producto")]
        [StringLength(15)]
        public string GrupoProducto { get; set; }
        [Column("status_serie")]
        public short StatusSerie { get; set; }
    }
}
