using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fotos_entrada")]
    public partial class FotosEntradum
    {
        [Key]
        [Column("id_foto", TypeName = "numeric(18, 0)")]
        public decimal IdFoto { get; set; }
        [Key]
        [Column("entrada")]
        [StringLength(10)]
        public string Entrada { get; set; }
        [Column("ruta_foto")]
        [StringLength(200)]
        public string RutaFoto { get; set; }
        [Column("foto", TypeName = "image")]
        public byte[] Foto { get; set; }
    }
}
