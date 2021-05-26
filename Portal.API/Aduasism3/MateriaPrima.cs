using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("MateriaPrima$")]
    public partial class MateriaPrima
    {
        [StringLength(255)]
        public string NumParte1 { get; set; }
        [StringLength(255)]
        public string NumParte { get; set; }
        [StringLength(255)]
        public string Descripcion { get; set; }
        [StringLength(255)]
        public string DescripcionIngles { get; set; }
        [StringLength(5)]
        public string Unidad { get; set; }
        [Column(TypeName = "numeric(18, 0)")]
        public decimal? Fraccion { get; set; }
        [StringLength(3)]
        public string PaisOrigen { get; set; }
        [Column(TypeName = "numeric(18, 6)")]
        public decimal? Peso { get; set; }
        [Column(TypeName = "numeric(16, 7)")]
        public decimal? Precio { get; set; }
        [Column(TypeName = "numeric(6, 0)")]
        public decimal? TasaImpto { get; set; }
        [Column(TypeName = "numeric(6, 0)")]
        public decimal? TipoTasa { get; set; }
    }
}
