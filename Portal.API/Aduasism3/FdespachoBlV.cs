using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdespacho_bl_v")]
    public partial class FdespachoBlV
    {
        [Key]
        [Column("num_control")]
        [StringLength(30)]
        public string NumControl { get; set; }
        [Key]
        [Column("consecutivo", TypeName = "numeric(9, 0)")]
        public decimal Consecutivo { get; set; }
        [Key]
        [Column("numero_bl")]
        [StringLength(25)]
        public string NumeroBl { get; set; }
        [Column("codigo_respuesta")]
        [StringLength(4)]
        public string CodigoRespuesta { get; set; }
        [Column("numero_operacion")]
        [StringLength(14)]
        public string NumeroOperacion { get; set; }
        [Column("eDespacho")]
        [StringLength(25)]
        public string EDespacho { get; set; }
        [Column("mensaje_transaccion")]
        [StringLength(2500)]
        public string MensajeTransaccion { get; set; }
    }
}
