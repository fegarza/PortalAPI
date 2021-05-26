using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fe_emisor_regimenfiscal")]
    public partial class FeEmisorRegimenfiscal
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("id_regimen")]
        public int IdRegimen { get; set; }
        [Column("regimen_fiscal", TypeName = "text")]
        public string RegimenFiscal { get; set; }
        [Column("c_RegimenFiscal")]
        [StringLength(3)]
        public string CRegimenFiscal { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
