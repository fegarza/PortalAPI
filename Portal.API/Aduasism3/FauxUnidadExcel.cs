using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faux_unidad_excel")]
    public partial class FauxUnidadExcel
    {
        [Key]
        [Column("unidad_archivo")]
        [StringLength(20)]
        public string UnidadArchivo { get; set; }
        [Column("unidad_aduasis")]
        [StringLength(3)]
        public string UnidadAduasis { get; set; }
    }
}
