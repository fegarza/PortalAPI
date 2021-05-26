using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_autorizacion")]
    public partial class FpedimentoAutorizacion
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Column("pedimento_original")]
        [StringLength(7)]
        public string PedimentoOriginal { get; set; }
        [Column("pedimento_nuevo")]
        [StringLength(7)]
        public string PedimentoNuevo { get; set; }
        [Column("id_usuario_autoriza")]
        [StringLength(6)]
        public string IdUsuarioAutoriza { get; set; }
        [Column("id_usuario_registra")]
        [StringLength(6)]
        public string IdUsuarioRegistra { get; set; }
        [Key]
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime FechaReg { get; set; }
    }
}
