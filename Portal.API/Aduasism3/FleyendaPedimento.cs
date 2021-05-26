using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fleyenda_pedimento")]
    [Index(nameof(Rowguid), Name = "index_1637580872", IsUnique = true)]
    public partial class FleyendaPedimento
    {
        [Key]
        [Column("id_leyenda_pedimento")]
        [StringLength(25)]
        public string IdLeyendaPedimento { get; set; }
        [Column("leyenda", TypeName = "text")]
        public string Leyenda { get; set; }
        [Required]
        [Column("observaciones")]
        [StringLength(250)]
        public string Observaciones { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
