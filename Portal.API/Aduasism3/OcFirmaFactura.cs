using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_firma_factura")]
    public partial class OcFirmaFactura
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_referencia")]
        [StringLength(20)]
        public string IdReferencia { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
    }
}
