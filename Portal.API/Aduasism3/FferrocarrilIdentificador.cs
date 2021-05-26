using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fferrocarril_identificador")]
    public partial class FferrocarrilIdentificador
    {
        [Key]
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(15)]
        public string IdFactura { get; set; }
        [Key]
        [Column("id_producto")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Key]
        [Column("secuencial", TypeName = "numeric(18, 0)")]
        public decimal Secuencial { get; set; }
        [Column("tipo_Caso")]
        [StringLength(3)]
        public string TipoCaso { get; set; }
        [Column("Compl_1")]
        [StringLength(20)]
        public string Compl1 { get; set; }
        [Column("Compl_2")]
        [StringLength(30)]
        public string Compl2 { get; set; }
        [Key]
        [Column("sec_fact", TypeName = "numeric(18, 0)")]
        public decimal SecFact { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
