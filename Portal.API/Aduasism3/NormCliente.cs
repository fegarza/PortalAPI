using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("norm_cliente")]
    public partial class NormCliente
    {
        [Column("id_cliente")]
        [StringLength(250)]
        public string IdCliente { get; set; }
        [Column("nuevo_id")]
        [StringLength(250)]
        public string NuevoId { get; set; }
    }
}
