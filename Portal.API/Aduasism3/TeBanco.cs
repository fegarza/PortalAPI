using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("te_banco")]
    public partial class TeBanco
    {
        [Key]
        [Column("num_banco", TypeName = "numeric(2, 0)")]
        public decimal NumBanco { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(60)]
        public string Nombre { get; set; }
        [Column("cve_sucursal", TypeName = "numeric(8, 0)")]
        public decimal? CveSucursal { get; set; }
        [Column("nombre_sucursal")]
        [StringLength(40)]
        public string NombreSucursal { get; set; }
        [Column("direccion")]
        [StringLength(60)]
        public string Direccion { get; set; }
        [Column("cp", TypeName = "decimal(7, 0)")]
        public decimal? Cp { get; set; }
        [Column("telefono1")]
        [StringLength(16)]
        public string Telefono1 { get; set; }
        [Column("telefono2")]
        [StringLength(16)]
        public string Telefono2 { get; set; }
        [Column("nombre_representante")]
        [StringLength(40)]
        public string NombreRepresentante { get; set; }
        [Required]
        [Column("rfc")]
        [StringLength(14)]
        public string Rfc { get; set; }
        [Column("tipo_banco")]
        public int? TipoBanco { get; set; }
        [Column("forma_cheque")]
        [StringLength(60)]
        public string FormaCheque { get; set; }
        [Column("clave_banco_SAT")]
        [StringLength(3)]
        public string ClaveBancoSat { get; set; }
    }
}
