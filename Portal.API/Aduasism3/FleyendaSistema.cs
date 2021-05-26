using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fleyenda_sistema")]
    [Index(nameof(Rowguid), Name = "index_1669580986", IsUnique = true)]
    public partial class FleyendaSistema
    {
        [Key]
        [Column("ferrocarril_aviso")]
        [StringLength(255)]
        public string FerrocarrilAviso { get; set; }
        [Column("carta_incrementa", TypeName = "text")]
        public string CartaIncrementa { get; set; }
        [Column("traduccion", TypeName = "text")]
        public string Traduccion { get; set; }
        [Column("calculo", TypeName = "text")]
        public string Calculo { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("carta_subdivision")]
        [StringLength(255)]
        public string CartaSubdivision { get; set; }
        [Column("orden_remision")]
        [StringLength(255)]
        public string OrdenRemision { get; set; }
        [Column("rtv_natural", TypeName = "text")]
        public string RtvNatural { get; set; }
        [Column("rtv_industrial", TypeName = "text")]
        public string RtvIndustrial { get; set; }
        [Column("notificacion_entrada", TypeName = "text")]
        public string NotificacionEntrada { get; set; }
        [Column("cotizacion", TypeName = "text")]
        public string Cotizacion { get; set; }
        [Column("certificado_origen", TypeName = "text")]
        public string CertificadoOrigen { get; set; }
        [Column("notificacion_pago_banco")]
        [StringLength(13)]
        public string NotificacionPagoBanco { get; set; }
        [Column("orden_remision_transportista")]
        [StringLength(500)]
        public string OrdenRemisionTransportista { get; set; }
        [Column("mensaje_articulos")]
        [StringLength(250)]
        public string MensajeArticulos { get; set; }
        [Column("mensaje_articulos2")]
        [StringLength(250)]
        public string MensajeArticulos2 { get; set; }
    }
}
