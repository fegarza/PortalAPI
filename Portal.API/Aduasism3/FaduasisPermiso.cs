using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faduasis_permiso")]
    public partial class FaduasisPermiso
    {
        [Key]
        [Column("fraccion")]
        [StringLength(8)]
        public string Fraccion { get; set; }
        [Key]
        [StringLength(50)]
        public string Dependencia { get; set; }
        [Column(TypeName = "text")]
        public string Observaciones { get; set; }
        [Required]
        [Column("permiso")]
        [StringLength(100)]
        public string Permiso { get; set; }
        [Column("publicado", TypeName = "datetime")]
        public DateTime? Publicado { get; set; }
        [Column("texto", TypeName = "text")]
        public string Texto { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Key]
        [Column("ident")]
        public int Ident { get; set; }
        [Key]
        [Column("clavem3")]
        [StringLength(2)]
        public string Clavem3 { get; set; }
    }
}
