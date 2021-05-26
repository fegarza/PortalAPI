using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdigital_nombre")]
    public partial class FdigitalNombre
    {
        [Key]
        [Column("documento")]
        [StringLength(50)]
        public string Documento { get; set; }
        [Column("prefijo")]
        [StringLength(3)]
        public string Prefijo { get; set; }
        [Column("cliente")]
        [StringLength(1)]
        public string Cliente { get; set; }
        [Column("referencia")]
        [StringLength(1)]
        public string Referencia { get; set; }
        [Column("numero")]
        [StringLength(1)]
        public string Numero { get; set; }
        [Column("aduana")]
        [StringLength(1)]
        public string Aduana { get; set; }
        [Column("patente")]
        [StringLength(1)]
        public string Patente { get; set; }
        [Column("dia")]
        [StringLength(1)]
        public string Dia { get; set; }
        [Column("hora")]
        [StringLength(1)]
        public string Hora { get; set; }
        [Column("usuario")]
        [StringLength(1)]
        public string Usuario { get; set; }
        [Key]
        [Column("extencion")]
        [StringLength(3)]
        public string Extencion { get; set; }
        [Column("ruta_almacen")]
        [StringLength(200)]
        public string RutaAlmacen { get; set; }
    }
}
