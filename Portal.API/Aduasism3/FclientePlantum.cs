using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fcliente_planta")]
    [Index(nameof(Rowguid), Name = "index_373576369", IsUnique = true)]
    public partial class FclientePlantum
    {
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("num_planta", TypeName = "numeric(12, 0)")]
        public decimal NumPlanta { get; set; }
        [Column("flete_porc", TypeName = "numeric(5, 2)")]
        public decimal? FletePorc { get; set; }
        [Column("seguro_porc", TypeName = "numeric(5, 2)")]
        public decimal? SeguroPorc { get; set; }
        [Column("otros_gastos_porc", TypeName = "numeric(5, 2)")]
        public decimal? OtrosGastosPorc { get; set; }
        [Column("fecha_reg", TypeName = "datetime")]
        public DateTime? FechaReg { get; set; }
        [Column("id_usuario_registro")]
        [StringLength(6)]
        public string IdUsuarioRegistro { get; set; }
        [Column("fecha_ultmodif", TypeName = "datetime")]
        public DateTime? FechaUltmodif { get; set; }
        [Column("id_usuario_ultmodif")]
        [StringLength(6)]
        public string IdUsuarioUltmodif { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
    }
}
