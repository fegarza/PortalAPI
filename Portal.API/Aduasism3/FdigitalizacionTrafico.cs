using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdigitalizacion_trafico")]
    public partial class FdigitalizacionTrafico
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("id_bodega")]
        [StringLength(8)]
        public string IdBodega { get; set; }
        [Key]
        [Column("documento")]
        public int Documento { get; set; }
        [Required]
        [Column("archivoWeb")]
        [StringLength(250)]
        public string ArchivoWeb { get; set; }
    }
}
