using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fproductos_tlc")]
    public partial class FproductosTlc
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(10)]
        public string IdCliente { get; set; }
        [Column("tipo_doc")]
        [StringLength(1)]
        public string TipoDoc { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Key]
        [Column("no_parte")]
        [StringLength(50)]
        public string NoParte { get; set; }
        [Column("fraccion")]
        [StringLength(8)]
        public string Fraccion { get; set; }
        [Column("fecha_venc", TypeName = "datetime")]
        public DateTime? FechaVenc { get; set; }
    }
}
