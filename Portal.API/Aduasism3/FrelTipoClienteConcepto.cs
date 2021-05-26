using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_tipo_cliente_conceptos")]
    public partial class FrelTipoClienteConcepto
    {
        [Key]
        [Column("id_tipo_cliente")]
        [StringLength(3)]
        public string IdTipoCliente { get; set; }
        [Key]
        [Column("id_concepto")]
        [StringLength(6)]
        public string IdConcepto { get; set; }
    }
}
