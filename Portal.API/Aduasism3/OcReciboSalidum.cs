using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_recibo_salida")]
    public partial class OcReciboSalidum
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_recibo")]
        [StringLength(10)]
        public string IdRecibo { get; set; }
        [Column("linea_fletera")]
        [StringLength(4)]
        public string LineaFletera { get; set; }
        [Column("numero_vehiculo")]
        [StringLength(20)]
        public string NumeroVehiculo { get; set; }
        [Column("guia")]
        [StringLength(35)]
        public string Guia { get; set; }
        [Column("referencia")]
        [StringLength(50)]
        public string Referencia { get; set; }
        [Column("referencia_aux")]
        [StringLength(50)]
        public string ReferenciaAux { get; set; }
        [Column("observaciones")]
        [StringLength(1000)]
        public string Observaciones { get; set; }
        [Column("usuario_ingreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fecha_ingreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("fecha_salida", TypeName = "datetime")]
        public DateTime? FechaSalida { get; set; }
        [Column("pro_number")]
        [StringLength(35)]
        public string ProNumber { get; set; }
        [Column("id_term")]
        public short? IdTerm { get; set; }
    }
}
