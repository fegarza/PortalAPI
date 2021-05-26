using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fnoelec_cliente_aduana")]
    [Index(nameof(Rowguid), Name = "index_548404152", IsUnique = true)]
    public partial class FnoelecClienteAduana
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Required]
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
