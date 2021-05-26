using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdespacho_listado_BL_sellos")]
    public partial class FdespachoListadoBlSello
    {
        [Key]
        [Column("clave_transportista")]
        [StringLength(4)]
        public string ClaveTransportista { get; set; }
        [Key]
        [Column("numero_bl")]
        [StringLength(25)]
        public string NumeroBl { get; set; }
        [Key]
        [Column("estado_BL")]
        [StringLength(2)]
        public string EstadoBl { get; set; }
        [Key]
        [Column("sello")]
        [StringLength(25)]
        public string Sello { get; set; }
    }
}
