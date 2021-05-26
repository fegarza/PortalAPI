using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fleyenda_calculo")]
    public partial class FleyendaCalculo
    {
        [Key]
        [Column("id_leyenda")]
        [StringLength(15)]
        public string IdLeyenda { get; set; }
        [Column("rfc_servicios")]
        [StringLength(13)]
        public string RfcServicios { get; set; }
        [Column("leyenda", TypeName = "text")]
        public string Leyenda { get; set; }
    }
}
