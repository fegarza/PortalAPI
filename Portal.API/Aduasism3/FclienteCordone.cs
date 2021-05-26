using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_cordones")]
    public partial class FclienteCordone
    {
        [Key]
        [Column("id_Cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_ruta", TypeName = "numeric(18, 0)")]
        public decimal IdRuta { get; set; }
        [Column("cordon_norte")]
        [StringLength(2)]
        public string CordonNorte { get; set; }
        [Column("cordon_centro")]
        [StringLength(2)]
        public string CordonCentro { get; set; }
        [Column("cordon_sur")]
        [StringLength(2)]
        public string CordonSur { get; set; }
        [Column("cordon_istmo")]
        [StringLength(2)]
        public string CordonIstmo { get; set; }
        [Column("cordon_peninsular")]
        [StringLength(2)]
        public string CordonPeninsular { get; set; }
    }
}
