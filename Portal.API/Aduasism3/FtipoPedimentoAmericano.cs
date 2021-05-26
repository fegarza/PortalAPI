using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("ftipo_pedimento_americano")]
    public partial class FtipoPedimentoAmericano
    {
        [Key]
        [Column("id_pedimento")]
        [StringLength(2)]
        public string IdPedimento { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Required]
        [Column("cve_tipo_operacion")]
        [StringLength(1)]
        public string CveTipoOperacion { get; set; }
    }
}
