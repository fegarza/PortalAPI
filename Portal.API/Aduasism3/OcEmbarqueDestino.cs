using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("oc_embarque_destino")]
    public partial class OcEmbarqueDestino
    {
        [Key]
        [Column("id_almacen")]
        [StringLength(8)]
        public string IdAlmacen { get; set; }
        [Key]
        [Column("id_embarque")]
        [StringLength(10)]
        public string IdEmbarque { get; set; }
        [Key]
        [Column("id_cliente")]
        [StringLength(6)]
        public string IdCliente { get; set; }
        [Key]
        [Column("id_destino")]
        [StringLength(4)]
        public string IdDestino { get; set; }
        [Required]
        [Column("id_linea_fletera")]
        [StringLength(4)]
        public string IdLineaFletera { get; set; }
        [Column("entregado_a")]
        [StringLength(30)]
        public string EntregadoA { get; set; }
        [Column("guia_flete")]
        [StringLength(20)]
        public string GuiaFlete { get; set; }
        [Column("tipo_flete")]
        [StringLength(1)]
        public string TipoFlete { get; set; }
        [Column("importe_flete", TypeName = "numeric(11, 2)")]
        public decimal ImporteFlete { get; set; }
        [Column("observaciones")]
        public string Observaciones { get; set; }
        [Column("calle")]
        [StringLength(120)]
        public string Calle { get; set; }
        [Column("numero")]
        [StringLength(10)]
        public string Numero { get; set; }
        [Column("colonia")]
        [StringLength(80)]
        public string Colonia { get; set; }
        [Column("codigo_postal")]
        [StringLength(10)]
        public string CodigoPostal { get; set; }
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
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
        [Column("tipo_factura")]
        [StringLength(1)]
        public string TipoFactura { get; set; }
        [Column("facturar_a")]
        public string FacturarA { get; set; }
        [Column("flete_x_cobrar")]
        public bool FleteXCobrar { get; set; }
        [Column("fecha_destino", TypeName = "datetime")]
        public DateTime? FechaDestino { get; set; }
        [Column("id_term")]
        public short? IdTerm { get; set; }
        [Column("pro_number")]
        [StringLength(35)]
        public string ProNumber { get; set; }
    }
}
