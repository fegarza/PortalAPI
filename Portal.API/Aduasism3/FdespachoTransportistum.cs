using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdespacho_transportista")]
    public partial class FdespachoTransportistum
    {
        [Key]
        [Column("id_transportista")]
        [StringLength(4)]
        public string IdTransportista { get; set; }
        [Column("descripcion")]
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}
