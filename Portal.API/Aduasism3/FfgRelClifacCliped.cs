using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("ffg_rel_clifac_cliped")]
    public partial class FfgRelClifacCliped
    {
        [Required]
        [Column("id_cliente_factura")]
        [StringLength(6)]
        public string IdClienteFactura { get; set; }
        [Required]
        [Column("id_cliente_pedimento")]
        [StringLength(6)]
        public string IdClientePedimento { get; set; }
        [Required]
        [Column("id_tabulador")]
        [StringLength(3)]
        public string IdTabulador { get; set; }
        [Column("numempresa")]
        public int? Numempresa { get; set; }
    }
}
