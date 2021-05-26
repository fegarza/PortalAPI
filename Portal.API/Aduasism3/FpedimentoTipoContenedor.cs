using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_tipo_contenedor")]
    [Index(nameof(Rowguid), Name = "index_1572916675", IsUnique = true)]
    public partial class FpedimentoTipoContenedor
    {
        [Key]
        [Column("id_tipo_contenedor")]
        public short IdTipoContenedor { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
