using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fautoriza_referencia_pago")]
    public partial class FautorizaReferenciaPago
    {
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal? IdRectificacion { get; set; }
        [Column("id_banco")]
        [StringLength(4)]
        public string IdBanco { get; set; }
        [Column("identificador")]
        [StringLength(5)]
        public string Identificador { get; set; }
        [Column("id_usuario")]
        [StringLength(6)]
        public string IdUsuario { get; set; }
        [Column("fecha_autorizacion", TypeName = "datetime")]
        public DateTime? FechaAutorizacion { get; set; }
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
    }
}
