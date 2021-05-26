using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_prefijos")]
    public partial class FclientePrefijo
    {
        [Key]
        [Column("id_cliente_prefijo")]
        public long IdClientePrefijo { get; set; }
        [Required]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("id_prefijo")]
        public int IdPrefijo { get; set; }
        [Column("folio_proforma")]
        public int? FolioProforma { get; set; }
        [Column("folio_factura")]
        public int? FolioFactura { get; set; }
    }
}
