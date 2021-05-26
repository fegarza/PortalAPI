using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("faduasis_complemento1$")]
    public partial class FaduasisComplemento11
    {
        [Column("id_comp")]
        [StringLength(255)]
        public string IdComp { get; set; }
        public string Texto { get; set; }
        [Column("ident")]
        [StringLength(255)]
        public string Ident { get; set; }
        [Column("secuencial")]
        public double? Secuencial { get; set; }
    }
}
