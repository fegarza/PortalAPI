using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fvinculacion_cliente_proveedor")]
    [Index(nameof(Rowguid), Name = "index_1266819575", IsUnique = true)]
    public partial class FvinculacionClienteProveedor
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("uso_edo_mercancia")]
        [StringLength(1)]
        public string UsoEdoMercancia { get; set; }
        [Required]
        [Column("id_vinculacion")]
        [StringLength(1)]
        public string IdVinculacion { get; set; }
        [Required]
        [Column("valoracion")]
        [StringLength(1)]
        public string Valoracion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Key]
        [Column("id_regimen")]
        [StringLength(2)]
        public string IdRegimen { get; set; }
    }
}
