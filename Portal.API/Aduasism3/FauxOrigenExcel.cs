using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faux_origen_excel")]
    public partial class FauxOrigenExcel
    {
        [Key]
        [Column("pais_origen_archivo")]
        [StringLength(20)]
        public string PaisOrigenArchivo { get; set; }
        [Column("pais_origen_aduasis")]
        [StringLength(3)]
        public string PaisOrigenAduasis { get; set; }
    }
}
