using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fnoelec_cliente")]
    [Index(nameof(Rowguid), Name = "index_1943730027", IsUnique = true)]
    public partial class FnoelecCliente
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Column("razon_social")]
        [StringLength(250)]
        public string RazonSocial { get; set; }
        [Column("rfc")]
        [StringLength(13)]
        public string Rfc { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
