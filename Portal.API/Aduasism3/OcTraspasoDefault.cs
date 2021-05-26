using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_traspaso_default")]
    public partial class OcTraspasoDefault
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Required]
        [Column("usuario")]
        [StringLength(6)]
        public string Usuario { get; set; }
        [Required]
        [Column("clasificado")]
        [StringLength(1)]
        public string Clasificado { get; set; }
        [Required]
        [Column("tipo_status")]
        [StringLength(1)]
        public string TipoStatus { get; set; }
        [Required]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Column("marca_mcia")]
        [StringLength(20)]
        public string MarcaMcia { get; set; }
    }
}
