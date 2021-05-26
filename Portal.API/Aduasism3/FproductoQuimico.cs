using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fproducto_quimico")]
    [Index(nameof(Rowguid), Name = "index_826486023", IsUnique = true)]
    public partial class FproductoQuimico
    {
        [Key]
        [Column("identificador")]
        [StringLength(4)]
        public string Identificador { get; set; }
        [Key]
        [Column("guia")]
        [StringLength(4)]
        public string Guia { get; set; }
        [Key]
        [Column("clase_peligro")]
        [StringLength(3)]
        public string ClasePeligro { get; set; }
        [Key]
        [Column("descripcion")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("observaciones")]
        [StringLength(255)]
        public string Observaciones { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
