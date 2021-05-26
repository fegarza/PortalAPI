using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faux_proveedor")]
    public partial class FauxProveedor
    {
        [Key]
        [Column("id_proveedor")]
        [StringLength(10)]
        public string IdProveedor { get; set; }
        [Required]
        [Column("id_proveedor_sis")]
        [StringLength(6)]
        public string IdProveedorSis { get; set; }
        [Key]
        [Column("cve_cliente")]
        [StringLength(10)]
        public string CveCliente { get; set; }
    }
}
