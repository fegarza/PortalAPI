using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faduasis_noms")]
    public partial class FaduasisNom
    {
        [Key]
        [Column("fraccion")]
        [StringLength(8)]
        public string Fraccion { get; set; }
        [Key]
        [Column("nom")]
        [StringLength(50)]
        public string Nom { get; set; }
        [Column("texto", TypeName = "text")]
        public string Texto { get; set; }
        [Column("publicado", TypeName = "datetime")]
        public DateTime? Publicado { get; set; }
        [Column("vigencia", TypeName = "datetime")]
        public DateTime? Vigencia { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Key]
        [Column("ident")]
        public int Ident { get; set; }
    }
}
