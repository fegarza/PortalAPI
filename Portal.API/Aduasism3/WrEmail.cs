using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("wr_email")]
    public partial class WrEmail
    {
        [Key]
        [Column("id_aplicacion")]
        public short IdAplicacion { get; set; }
        [Key]
        [Column("id_email")]
        public int IdEmail { get; set; }
        [Required]
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [Column("activo")]
        public bool? Activo { get; set; }
        [Column("todos")]
        public bool Todos { get; set; }
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
    }
}
