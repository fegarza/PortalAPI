using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faux_cuenta_cliente")]
    public partial class FauxCuentaCliente
    {
        [Key]
        [Column("id_aux_cuenta")]
        public int IdAuxCuenta { get; set; }
        [Required]
        [Column("cuenta_cliente")]
        [StringLength(30)]
        public string CuentaCliente { get; set; }
        [Required]
        [Column("cuenta_aduasis")]
        [StringLength(30)]
        public string CuentaAduasis { get; set; }
        [Column("tipo_factura")]
        public int TipoFactura { get; set; }
        [Required]
        [Column("naturaleza_cuenta")]
        [StringLength(1)]
        public string NaturalezaCuenta { get; set; }
    }
}
