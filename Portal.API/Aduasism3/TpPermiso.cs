using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_permiso")]
    public partial class TpPermiso
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("partida")]
        public int Partida { get; set; }
        [Key]
        [Column("numero_partida")]
        public int NumeroPartida { get; set; }
        [Key]
        [Column("secuencial_permiso")]
        public short SecuencialPermiso { get; set; }
        [Column("clave_permiso")]
        [StringLength(2)]
        public string ClavePermiso { get; set; }
        [Column("numero_permiso")]
        [StringLength(50)]
        public string NumeroPermiso { get; set; }
        [Column("firma_descargo")]
        [StringLength(17)]
        public string FirmaDescargo { get; set; }
        [Column("valor_comercial_dolares", TypeName = "decimal(12, 2)")]
        public decimal? ValorComercialDolares { get; set; }
        [Column("cantidad_UMT_UMC", TypeName = "decimal(9, 6)")]
        public decimal? CantidadUmtUmc { get; set; }
    }
}
