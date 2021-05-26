using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("wr_email_aduana")]
    public partial class WrEmailAduana
    {
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Column("id_email")]
        public int IdEmail { get; set; }
        [Required]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [Required]
        [Column("seccion_aduana")]
        [StringLength(1)]
        public string SeccionAduana { get; set; }

        [ForeignKey("IdAduana,SeccionAduana")]
        public virtual Faduana Faduana { get; set; }
    }
}
