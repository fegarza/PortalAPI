using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("cc_estado_cuenta")]
    public partial class CcEstadoCuentum
    {
        [Required]
        [Column("cliente")]
        [StringLength(6)]
        public string Cliente { get; set; }
        [Required]
        [Column("nombre_cliente")]
        [StringLength(50)]
        public string NombreCliente { get; set; }
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Column("fecha_informacion", TypeName = "datetime")]
        public DateTime FechaInformacion { get; set; }
        [Column("fecha_movimiento", TypeName = "datetime")]
        public DateTime FechaMovimiento { get; set; }
        [Column("fecha_factura", TypeName = "datetime")]
        public DateTime? FechaFactura { get; set; }
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Column("id_factura")]
        [StringLength(10)]
        public string IdFactura { get; set; }
        [Column("importe_factura", TypeName = "decimal(16, 2)")]
        public decimal ImporteFactura { get; set; }
        [Column("importe_anticipo_factura", TypeName = "decimal(16, 2)")]
        public decimal ImporteAnticipoFactura { get; set; }
        [Column("num_anticipo_recibido", TypeName = "decimal(6, 0)")]
        public decimal NumAnticipoRecibido { get; set; }
        [Column("importe_anticipo_recibido", TypeName = "decimal(16, 2)")]
        public decimal ImporteAnticipoRecibido { get; set; }
        [Column("num_pago_recibido", TypeName = "decimal(6, 0)")]
        public decimal NumPagoRecibido { get; set; }
        [Column("importe_pago_recibido", TypeName = "decimal(16, 2)")]
        public decimal ImportePagoRecibido { get; set; }
        [Column("importe_anticipo_aplicado", TypeName = "decimal(16, 2)")]
        public decimal ImporteAnticipoAplicado { get; set; }
        [Column("importe_pago_aplicado", TypeName = "decimal(16, 2)")]
        public decimal ImportePagoAplicado { get; set; }
        [Column("num_devolucion", TypeName = "decimal(6, 0)")]
        public decimal NumDevolucion { get; set; }
        [Column("importe_devolucion", TypeName = "decimal(16, 2)")]
        public decimal ImporteDevolucion { get; set; }
        [Column("cheque_devolucion", TypeName = "decimal(10, 0)")]
        public decimal ChequeDevolucion { get; set; }
    }
}
