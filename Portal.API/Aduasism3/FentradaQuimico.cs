using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fentrada_quimico")]
    [Index(nameof(Rowguid), Name = "index_794485909", IsUnique = true)]
    public partial class FentradaQuimico
    {
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
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
        [Required]
        [Column("empaquetado")]
        [StringLength(1)]
        public string Empaquetado { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
