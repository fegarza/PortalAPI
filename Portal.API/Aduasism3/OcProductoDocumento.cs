using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_producto_documento")]
    public partial class OcProductoDocumento
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
        [Column("documento")]
        public int Documento { get; set; }
        [Key]
        [Column("secuencial")]
        public int Secuencial { get; set; }
        [Required]
        [Column("archivoWeb")]
        [StringLength(250)]
        public string ArchivoWeb { get; set; }
    }
}
