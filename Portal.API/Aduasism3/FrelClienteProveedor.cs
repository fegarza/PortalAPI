using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("frel_cliente_proveedor")]
    public partial class FrelClienteProveedor
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(Fcliente.FrelClienteProveedors))]
        public virtual Fcliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdProveedor))]
        [InverseProperty(nameof(Fproveedor.FrelClienteProveedors))]
        public virtual Fproveedor IdProveedorNavigation { get; set; }
    }
}
