using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ffg_cliente_metodo_forma_pago")]
    public partial class FfgClienteMetodoFormaPago
    {
        [Key]
        [Column("num_detalle")]
        public int NumDetalle { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("tipo_moneda")]
        [StringLength(1)]
        public string TipoMoneda { get; set; }
        [Column("forma_pago")]
        public int FormaPago { get; set; }
        [Column("metodo_pago")]
        public int? MetodoPago { get; set; }
        [Column("num_cuenta_pago")]
        [StringLength(14)]
        public string NumCuentaPago { get; set; }
        [Required]
        [Column("defaultt")]
        [StringLength(1)]
        public string Defaultt { get; set; }
        [Column("clave_SAT_metodo_pago")]
        [StringLength(2)]
        public string ClaveSatMetodoPago { get; set; }
    }
}
