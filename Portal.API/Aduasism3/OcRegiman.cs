using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_regimen")]
    public partial class OcRegiman
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
        [Column("clave_documento")]
        [StringLength(4)]
        public string ClaveDocumento { get; set; }
        [Required]
        [Column("tipo_importacion")]
        [StringLength(1)]
        public string TipoImportacion { get; set; }
        [Required]
        [Column("clave_pedimento")]
        [StringLength(4)]
        public string ClavePedimento { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("remesa")]
        public bool Remesa { get; set; }
        [Required]
        [Column("series_proveedores")]
        [StringLength(50)]
        public string SeriesProveedores { get; set; }
        [Required]
        [Column("claves_relacionadas")]
        [StringLength(50)]
        public string ClavesRelacionadas { get; set; }
    }
}
