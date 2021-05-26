using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fped_prueba_comple")]
    [Index(nameof(Rowguid), Name = "index_331200280", IsUnique = true)]
    public partial class FpedPruebaComple
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "decimal(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("pais_destino")]
        [StringLength(3)]
        public string PaisDestino { get; set; }
        [Key]
        [Column("pedimento_ec")]
        [StringLength(14)]
        public string PedimentoEc { get; set; }
        [Column("prueba")]
        [StringLength(1)]
        public string Prueba { get; set; }
        [Column("fecha_doc", TypeName = "datetime")]
        public DateTime? FechaDoc { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
