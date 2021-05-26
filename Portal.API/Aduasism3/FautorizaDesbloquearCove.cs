using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fautoriza_desbloquear_cove")]
    public partial class FautorizaDesbloquearCove
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion")]
        public int IdRectificacion { get; set; }
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Column("id_patente")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Column("fecha_autorizacion", TypeName = "datetime")]
        public DateTime? FechaAutorizacion { get; set; }
        [Column("id_usuario_autoriza")]
        [StringLength(6)]
        public string IdUsuarioAutoriza { get; set; }
    }
}
