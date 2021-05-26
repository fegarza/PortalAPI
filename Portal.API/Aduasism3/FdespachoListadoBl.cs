using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdespacho_listado_BL")]
    public partial class FdespachoListadoBl
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
        [Column("iniciales_equipo")]
        [StringLength(10)]
        public string InicialesEquipo { get; set; }
        [Column("numero_equipo")]
        [StringLength(10)]
        public string NumeroEquipo { get; set; }
        [Column("tipo_operacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("fecha_guia")]
        [StringLength(20)]
        public string FechaGuia { get; set; }
        [Column("id_referencia")]
        [StringLength(10)]
        public string IdReferencia { get; set; }
        [Column("id_rectificacion")]
        public int? IdRectificacion { get; set; }
        [Column("fecha_guia_DT", TypeName = "datetime")]
        public DateTime? FechaGuiaDt { get; set; }
        [Column("num_control")]
        [StringLength(30)]
        public string NumControl { get; set; }
    }
}
