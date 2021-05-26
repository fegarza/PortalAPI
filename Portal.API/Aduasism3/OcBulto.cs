using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_bultos")]
    public partial class OcBulto
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
        [Key]
        [Column("secuencial_bulto")]
        public short SecuencialBulto { get; set; }
        [Required]
        [Column("numeros")]
        [StringLength(15)]
        public string Numeros { get; set; }
        [Column("cantidad_bultos")]
        public int CantidadBultos { get; set; }
        [Required]
        [Column("tipo_bulto")]
        [StringLength(5)]
        public string TipoBulto { get; set; }
        [Column("cantidad_desglose")]
        public int CantidadDesglose { get; set; }
        [Required]
        [Column("tipo_bulto_desglose")]
        [StringLength(5)]
        public string TipoBultoDesglose { get; set; }
        [Column("danado")]
        public bool Danado { get; set; }
        [Column("cantidad_danado")]
        public int CantidadDanado { get; set; }
        [Column("nivel_dano")]
        public short? NivelDano { get; set; }
        [Column("localizacion_almacen")]
        [StringLength(15)]
        public string LocalizacionAlmacen { get; set; }
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
        [Column("clase_material")]
        public short? ClaseMaterial { get; set; }
        [Column("no_pallet")]
        public int? NoPallet { get; set; }
        [Column("guia")]
        [StringLength(35)]
        public string Guia { get; set; }
        [Column("peso_libras", TypeName = "decimal(14, 3)")]
        public decimal PesoLibras { get; set; }
        [Column("peso_kilos", TypeName = "decimal(14, 3)")]
        public decimal PesoKilos { get; set; }
        [Column("previo_finalizado")]
        public bool PrevioFinalizado { get; set; }
        [Column("cantidad_distribucion")]
        public int CantidadDistribucion { get; set; }
        [Column("fecha_salida", TypeName = "datetime")]
        public DateTime? FechaSalida { get; set; }
        [Column("folio_agrupacion")]
        [StringLength(15)]
        public string FolioAgrupacion { get; set; }
        [Column("fecha_agrupacion", TypeName = "datetime")]
        public DateTime? FechaAgrupacion { get; set; }
        [Column("subnivel_dano")]
        public short? SubnivelDano { get; set; }
        [Column("cantidad_operada")]
        public int CantidadOperada { get; set; }
    }
}
