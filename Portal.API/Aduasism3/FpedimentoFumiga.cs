using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_Fumiga")]
    public partial class FpedimentoFumiga
    {
        [Key]
        [Column("pedimento")]
        [StringLength(7)]
        public string Pedimento { get; set; }
        [Column("producto")]
        [StringLength(250)]
        public string Producto { get; set; }
        [Column("bultos", TypeName = "numeric(18, 0)")]
        public decimal? Bultos { get; set; }
        [Column("id_patente")]
        [StringLength(6)]
        public string IdPatente { get; set; }
        [Column("Pais_origen")]
        [StringLength(6)]
        public string PaisOrigen { get; set; }
        [Column("Pais_Proc")]
        [StringLength(6)]
        public string PaisProc { get; set; }
        [Required]
        [StringLength(250)]
        public string Vehiculos { get; set; }
        [StringLength(50)]
        public string Destino { get; set; }
        [StringLength(50)]
        public string Folio { get; set; }
        [Column("Tratamiento_Rec")]
        [StringLength(999)]
        public string TratamientoRec { get; set; }
        [Column("lugar")]
        [StringLength(250)]
        public string Lugar { get; set; }
        [StringLength(250)]
        public string Empresa { get; set; }
        [Column("Agente_Aduanal")]
        [StringLength(250)]
        public string AgenteAduanal { get; set; }
        [Column("RFC_AA")]
        [StringLength(20)]
        public string RfcAa { get; set; }
        [StringLength(250)]
        public string Apoderado { get; set; }
        [Column("RFC_Apo")]
        [StringLength(20)]
        public string RfcApo { get; set; }
        [Column("peso", TypeName = "decimal(14, 3)")]
        public decimal? Peso { get; set; }
        [Key]
        [Column("id_aduana")]
        [StringLength(2)]
        public string IdAduana { get; set; }
        [StringLength(250)]
        public string Cliente { get; set; }
    }
}
