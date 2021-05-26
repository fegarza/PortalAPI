using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_tipo_caso")]
    [Index(nameof(Rowguid), Name = "index_1556916618", IsUnique = true)]
    public partial class FpedimentoTipoCaso
    {
        [Key]
        [Column("id_tipo_caso")]
        [StringLength(3)]
        public string IdTipoCaso { get; set; }
        [Column("descripcion", TypeName = "text")]
        public string Descripcion { get; set; }
        [Key]
        [Column("Ped_part")]
        [StringLength(1)]
        public string PedPart { get; set; }
        [Column("ident_caso", TypeName = "text")]
        public string IdentCaso { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
