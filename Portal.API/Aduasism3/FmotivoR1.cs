using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fmotivo_r1")]
    public partial class FmotivoR1
    {
        [Key]
        [Column("id_motivo")]
        [StringLength(6)]
        public string IdMotivo { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Column("usuario_req")]
        [StringLength(1)]
        public string UsuarioReq { get; set; }
    }
}
