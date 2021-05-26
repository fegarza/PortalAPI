using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_corresponsal_cliente")]
    [Index(nameof(Rowguid), Name = "index_2112778634", IsUnique = true)]
    public partial class FrelCorresponsalCliente
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_corresponsal")]
        [StringLength(6)]
        public string IdCorresponsal { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
