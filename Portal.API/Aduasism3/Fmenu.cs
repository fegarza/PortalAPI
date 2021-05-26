using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fmenu")]
    public partial class Fmenu
    {
        [Key]
        [Column("id_proceso")]
        [StringLength(2)]
        public string IdProceso { get; set; }
        [Key]
        [Column("boton")]
        [StringLength(2)]
        public string Boton { get; set; }
        [Column("ruta")]
        [StringLength(150)]
        public string Ruta { get; set; }
        [Column("etiqueta")]
        [StringLength(100)]
        public string Etiqueta { get; set; }
        [Column("imagen")]
        [StringLength(150)]
        public string Imagen { get; set; }
        [Column("visible")]
        [StringLength(1)]
        public string Visible { get; set; }
        [Column("ejecucion")]
        public short? Ejecucion { get; set; }
        [Column("ventana")]
        [StringLength(150)]
        public string Ventana { get; set; }
        [Column("cant_par", TypeName = "numeric(1, 0)")]
        public decimal? CantPar { get; set; }
        [Column("par1")]
        [StringLength(100)]
        public string Par1 { get; set; }
        [Column("par2")]
        [StringLength(100)]
        public string Par2 { get; set; }
        [Column("par3")]
        [StringLength(100)]
        public string Par3 { get; set; }
    }
}
