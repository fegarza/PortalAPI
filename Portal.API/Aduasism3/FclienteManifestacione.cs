using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_manifestaciones")]
    public partial class FclienteManifestacione
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("leyenda_articulo_65")]
        [StringLength(500)]
        public string LeyendaArticulo65 { get; set; }
    }
}
