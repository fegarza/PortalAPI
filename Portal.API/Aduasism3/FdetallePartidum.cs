using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fdetalle_partida")]
    public partial class FdetallePartidum
    {
        [Key]
        [Column("id_entrada")]
        [StringLength(10)]
        public string IdEntrada { get; set; }
        [Key]
        [Column("id_factura")]
        [StringLength(15)]
        public string IdFactura { get; set; }
        [Key]
        [Column("id_pack_list")]
        [StringLength(15)]
        public string IdPackList { get; set; }
        [Key]
        [Column("num_detalle", TypeName = "numeric(4, 0)")]
        public decimal NumDetalle { get; set; }
        [Key]
        [Column("id_proveedor")]
        [StringLength(6)]
        public string IdProveedor { get; set; }
        [Key]
        [Column("sec_subpartida", TypeName = "numeric(4, 0)")]
        public decimal SecSubpartida { get; set; }
        [Column("ent_subpartida")]
        [StringLength(10)]
        public string EntSubpartida { get; set; }
        [Column("num_serie")]
        [StringLength(30)]
        public string NumSerie { get; set; }
        [Column("id_pais_origen")]
        [StringLength(4)]
        public string IdPaisOrigen { get; set; }
        [Column("id_unidad_universal")]
        [StringLength(5)]
        public string IdUnidadUniversal { get; set; }
        [Column("precio_estimado")]
        [StringLength(1)]
        public string PrecioEstimado { get; set; }
        [Column("aviso_importacion")]
        [StringLength(1)]
        public string AvisoImportacion { get; set; }
        [Column("cuota_compensatoria")]
        [StringLength(1)]
        public string CuotaCompensatoria { get; set; }
        [Column("id_trafico")]
        [StringLength(10)]
        public string IdTrafico { get; set; }
    }
}
