using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftrafico_detalle_caso_aux")]
    public partial class FtraficoDetalleCasoAux
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("numero_secuencial", TypeName = "decimal(5, 0)")]
        public decimal NumeroSecuencial { get; set; }
        [Key]
        [Column("numero_identificador", TypeName = "numeric(4, 0)")]
        public decimal NumeroIdentificador { get; set; }
        [Key]
        [Column("tipo_caso")]
        [StringLength(3)]
        public string TipoCaso { get; set; }
        [Key]
        [Column("iden_caso")]
        [StringLength(20)]
        public string IdenCaso { get; set; }
        [Column("complemento2")]
        [StringLength(50)]
        public string Complemento2 { get; set; }
        [Column("complemento3")]
        [StringLength(40)]
        public string Complemento3 { get; set; }
    }
}
