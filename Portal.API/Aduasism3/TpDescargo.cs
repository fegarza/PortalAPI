using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("tp_descargo")]
    public partial class TpDescargo
    {
        [Key]
        [Column("id_pedimento")]
        public int IdPedimento { get; set; }
        [Key]
        [Column("id_descargo")]
        public short IdDescargo { get; set; }
        [Column("patente_original")]
        public int PatenteOriginal { get; set; }
        [Column("pedimento_original")]
        public int PedimentoOriginal { get; set; }
        [Column("aduana_original")]
        public int AduanaOriginal { get; set; }
        [Required]
        [Column("clave_documento_original")]
        [StringLength(2)]
        public string ClaveDocumentoOriginal { get; set; }
        [Column("fecha_pago_original", TypeName = "datetime")]
        public DateTime? FechaPagoOriginal { get; set; }
        [Column("fraccion_original")]
        [StringLength(8)]
        public string FraccionOriginal { get; set; }
        [Column("unidad_medida")]
        [StringLength(3)]
        public string UnidadMedida { get; set; }
        [Column("cantidad", TypeName = "decimal(10, 5)")]
        public decimal? Cantidad { get; set; }
    }
}
