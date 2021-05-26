using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdetalle")]
    public partial class Fdetalle
    {
        [Key]
        [Column("factura")]
        [StringLength(15)]
        public string Factura { get; set; }
        [Key]
        [Column("producto")]
        [StringLength(50)]
        public string Producto { get; set; }
        [Key]
        [Column("descripcion")]
        [StringLength(50)]
        public string Descripcion { get; set; }
        [Key]
        [Column("unidad")]
        [StringLength(3)]
        public string Unidad { get; set; }
        [Column("oficio")]
        [StringLength(10)]
        public string Oficio { get; set; }
        [Key]
        [Column("cantidad", TypeName = "decimal(12, 2)")]
        public decimal Cantidad { get; set; }
        [Key]
        [Column("precio_unitario", TypeName = "decimal(16, 4)")]
        public decimal PrecioUnitario { get; set; }
        [Key]
        [Column("importe", TypeName = "decimal(12, 2)")]
        public decimal Importe { get; set; }
        [Column("fraccion")]
        [StringLength(10)]
        public string Fraccion { get; set; }
        [Column("tasa", TypeName = "decimal(12, 2)")]
        public decimal? Tasa { get; set; }
        [Column("marca")]
        [StringLength(50)]
        public string Marca { get; set; }
        [Column("modelo")]
        [StringLength(50)]
        public string Modelo { get; set; }
        [Column("serie")]
        [StringLength(50)]
        public string Serie { get; set; }
        [Required]
        [Column("pais_origen")]
        [StringLength(3)]
        public string PaisOrigen { get; set; }
        [Column("pais_procedencia")]
        [StringLength(3)]
        public string PaisProcedencia { get; set; }
        [Column("vinculacion")]
        [StringLength(3)]
        public string Vinculacion { get; set; }
        [Column("valoracion")]
        [StringLength(3)]
        public string Valoracion { get; set; }
        [Column("forma_pago")]
        [StringLength(3)]
        public string FormaPago { get; set; }
        [Column("cuota", TypeName = "decimal(12, 2)")]
        public decimal? Cuota { get; set; }
        [Column("preferencia")]
        [StringLength(20)]
        public string Preferencia { get; set; }
        [Key]
        [Column("secuencial", TypeName = "decimal(12, 0)")]
        public decimal Secuencial { get; set; }
    }
}
