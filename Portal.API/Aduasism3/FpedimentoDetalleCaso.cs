using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fpedimento_detalle_caso")]
    [Index(nameof(Rowguid), Name = "index_1645964940", IsUnique = true)]
    public partial class FpedimentoDetalleCaso
    {
        [Key]
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Key]
        [Column("id_rectificacion", TypeName = "numeric(1, 0)")]
        public decimal IdRectificacion { get; set; }
        [Key]
        [Column("numero_secuencial", TypeName = "numeric(5, 0)")]
        public decimal NumeroSecuencial { get; set; }
        [Key]
        [Column("numero_identificador", TypeName = "numeric(4, 0)")]
        public decimal NumeroIdentificador { get; set; }
        [Key]
        [Column("tipo_caso")]
        [StringLength(3)]
        public string TipoCaso { get; set; }
        [Column("iden_caso")]
        [StringLength(20)]
        public string IdenCaso { get; set; }
        [Column("complemento2")]
        [StringLength(50)]
        public string Complemento2 { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("complemento3")]
        [StringLength(40)]
        public string Complemento3 { get; set; }
    }
}
