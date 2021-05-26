using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_cuenta_aduanera")]
    public partial class TpCuentaAduanera
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_cuenta")]
        public short IdCuenta { get; set; }
        [Column("institucion_emisora")]
        public int? InstitucionEmisora { get; set; }
        [Required]
        [Column("numero_cuenta")]
        [StringLength(17)]
        public string NumeroCuenta { get; set; }
        [Column("folio_constancia")]
        [StringLength(17)]
        public string FolioConstancia { get; set; }
        [Column("fecha_constancia", TypeName = "datetime")]
        public DateTime? FechaConstancia { get; set; }
        [Column("tipo_cuenta")]
        [StringLength(250)]
        public string TipoCuenta { get; set; }
        [Column("tipo_garantia")]
        [StringLength(250)]
        public string TipoGarantia { get; set; }
        [Column("total_garantia", TypeName = "decimal(12, 2)")]
        public decimal? TotalGarantia { get; set; }
        [Column("cantidad_umc", TypeName = "decimal(12, 2)")]
        public decimal? CantidadUmc { get; set; }
    }
}
