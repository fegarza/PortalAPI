using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faduasis_cuotac")]
    public partial class FaduasisCuotac
    {
        [Key]
        [Column("fraccion")]
        [StringLength(8)]
        public string Fraccion { get; set; }
        [Key]
        [Column("pais")]
        [StringLength(5)]
        public string Pais { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column("producto", TypeName = "text")]
        public string Producto { get; set; }
        [Column("empresa", TypeName = "text")]
        public string Empresa { get; set; }
        [Required]
        [Column("cuota", TypeName = "text")]
        public string Cuota { get; set; }
        [Key]
        [Column("cve_tipo_opn")]
        [StringLength(1)]
        public string CveTipoOpn { get; set; }
        [Key]
        [Column("ident")]
        public int Ident { get; set; }
        [Column("dof", TypeName = "datetime")]
        public DateTime? Dof { get; set; }
        [Column("modificado", TypeName = "datetime")]
        public DateTime? Modificado { get; set; }
        [Column("tasa", TypeName = "numeric(10, 5)")]
        public decimal? Tasa { get; set; }
    }
}
