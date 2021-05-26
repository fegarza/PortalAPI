using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fproducto$")]
    public partial class Fproducto1
    {
        [Column("NUMPARTE")]
        [StringLength(30)]
        public string Numparte { get; set; }
        [Column("DESCESPANOL")]
        [StringLength(255)]
        public string Descespanol { get; set; }
        [Column("DESCINGLES")]
        [StringLength(255)]
        public string Descingles { get; set; }
        [Column("UNIMEDPARTE")]
        [StringLength(3)]
        public string Unimedparte { get; set; }
        [Column("PAIS_ORIGEN")]
        [StringLength(4)]
        public string PaisOrigen { get; set; }
        [Column("UNIMEDDESCARGA")]
        [StringLength(3)]
        public string Unimeddescarga { get; set; }
        [Column("FRACCIONIMPO")]
        [StringLength(8)]
        public string Fraccionimpo { get; set; }
        [Column("FRACCIONEXPO")]
        [StringLength(8)]
        public string Fraccionexpo { get; set; }
    }
}
