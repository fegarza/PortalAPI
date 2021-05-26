using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_guia")]
    public partial class OcGuium
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Key]
        [Column("secuencial_guia")]
        public short SecuencialGuia { get; set; }
        [Required]
        [Column("tipo_guia")]
        [StringLength(1)]
        public string TipoGuia { get; set; }
        [Required]
        [Column("numero_guia")]
        [StringLength(35)]
        public string NumeroGuia { get; set; }
        [Column("fecha_guia", TypeName = "date")]
        public DateTime FechaGuia { get; set; }
        [Column("bultos_guia")]
        public int BultosGuia { get; set; }
        [Column("bultos_registrados")]
        public int BultosRegistrados { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal PesoKilos { get; set; }
        [Column("descripcion_mercancia")]
        [StringLength(80)]
        public string DescripcionMercancia { get; set; }
        [Column("inconformidad")]
        public bool Inconformidad { get; set; }
        [Column("informe_incoformidad")]
        [StringLength(1000)]
        public string InformeIncoformidad { get; set; }
        [Column("localizacion_almacen")]
        [StringLength(15)]
        public string LocalizacionAlmacen { get; set; }
        [Column("tipo_flete")]
        public short TipoFlete { get; set; }
        [Column("importe_flete", TypeName = "decimal(10, 2)")]
        public decimal ImporteFlete { get; set; }
        [Required]
        [Column("moneda_flete")]
        [StringLength(4)]
        public string MonedaFlete { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuario_modifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fecha_modifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("status_operacion")]
        public short StatusOperacion { get; set; }
        [Column("previo_finalizado")]
        public bool PrevioFinalizado { get; set; }
        [Column("clase_material")]
        public short? ClaseMaterial { get; set; }
        [Column("me_number")]
        [StringLength(10)]
        public string MeNumber { get; set; }
    }
}
