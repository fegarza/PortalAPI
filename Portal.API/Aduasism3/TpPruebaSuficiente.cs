using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_prueba_suficiente")]
    public partial class TpPruebaSuficiente
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_prueba")]
        public short IdPrueba { get; set; }
        [Column("pais_destino")]
        [StringLength(3)]
        public string PaisDestino { get; set; }
        [Column("numero_pedimento_eu_canada")]
        [StringLength(14)]
        public string NumeroPedimentoEuCanada { get; set; }
        [Required]
        [Column("prueba_suficiente")]
        [StringLength(250)]
        public string PruebaSuficiente { get; set; }
        [Column("fecha_documento", TypeName = "datetime")]
        public DateTime? FechaDocumento { get; set; }
    }
}
