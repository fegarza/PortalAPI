using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("faux_tipo_adval_excel")]
    public partial class FauxTipoAdvalExcel
    {
        [Key]
        [Column("tipo_adval_archivo")]
        [StringLength(30)]
        public string TipoAdvalArchivo { get; set; }
        [Key]
        [Column("tipo_adval_aduasis")]
        [StringLength(3)]
        public string TipoAdvalAduasis { get; set; }
        [Key]
        [Column("id_pais")]
        [StringLength(4)]
        public string IdPais { get; set; }
    }
}
