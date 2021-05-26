using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("Nom_Bancos")]
    public partial class NomBanco
    {
        [Key]
        [Column("numempresa")]
        public int Numempresa { get; set; }
        [Key]
        [Column("id_banco")]
        public int IdBanco { get; set; }
        [Column("nombreCorto")]
        [StringLength(40)]
        public string NombreCorto { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(150)]
        public string Descripcion { get; set; }
        [Column("CLABE")]
        public long Clabe { get; set; }
        [Column("clave_banco_SAT")]
        [StringLength(3)]
        public string ClaveBancoSat { get; set; }
        [Column("RFC")]
        [StringLength(13)]
        public string Rfc { get; set; }
    }
}
