using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    [Table("fgenerales_cove")]
    public partial class FgeneralesCove
    {
        [Column("cove")]
        [StringLength(1)]
        public string Cove { get; set; }
        [Column("ruta_digitalizacion")]
        [StringLength(250)]
        public string RutaDigitalizacion { get; set; }
        [Column("ruta_reporte_cove")]
        [StringLength(200)]
        public string RutaReporteCove { get; set; }
        [Column("remesa_factura")]
        [StringLength(1)]
        public string RemesaFactura { get; set; }
        [Column("observaciones_cove")]
        [StringLength(1)]
        public string ObservacionesCove { get; set; }
        [Column("mover_archivos")]
        [StringLength(1)]
        public string MoverArchivos { get; set; }
        [Column("ruta_in_cove")]
        [StringLength(200)]
        public string RutaInCove { get; set; }
        [Column("ruta_out_cove")]
        [StringLength(200)]
        public string RutaOutCove { get; set; }
        [Column("renombrar_pdf")]
        [StringLength(1)]
        public string RenombrarPdf { get; set; }
        [Column("dig_prefijo")]
        [StringLength(3)]
        public string DigPrefijo { get; set; }
        [Column("dig_secuencial", TypeName = "numeric(12, 0)")]
        public decimal? DigSecuencial { get; set; }
        [Column("cove_prefijo")]
        [StringLength(3)]
        public string CovePrefijo { get; set; }
        [Column("cove_secuencial", TypeName = "numeric(7, 0)")]
        public decimal? CoveSecuencial { get; set; }
        [Column("descripcion_mercancia")]
        [StringLength(1)]
        public string DescripcionMercancia { get; set; }
        [Column("proteger_campos")]
        [StringLength(1)]
        public string ProtegerCampos { get; set; }
        [Column("observaciones_destinatario")]
        [StringLength(1)]
        public string ObservacionesDestinatario { get; set; }
        [Column("password_eliminar")]
        [StringLength(20)]
        public string PasswordEliminar { get; set; }
        [Required]
        [Column("declaracion_observaciones")]
        [StringLength(1)]
        public string DeclaracionObservaciones { get; set; }
        [Column("declaracion_observaciones_leyenda")]
        [StringLength(400)]
        public string DeclaracionObservacionesLeyenda { get; set; }
        [Required]
        [Column("rectificacion_remesa_factura")]
        [StringLength(1)]
        public string RectificacionRemesaFactura { get; set; }
        [Column("ruta_xml_generales")]
        [StringLength(1)]
        public string RutaXmlGenerales { get; set; }
        [Column("ruta_xml")]
        [StringLength(300)]
        public string RutaXml { get; set; }
        [Column("activar_expediente_digital")]
        [StringLength(1)]
        public string ActivarExpedienteDigital { get; set; }
        [Column("monitoreo_vucem")]
        [StringLength(250)]
        public string MonitoreoVucem { get; set; }
        [Column("monitoreo_claa")]
        [StringLength(250)]
        public string MonitoreoClaa { get; set; }
        [Column("msxml6")]
        [StringLength(1)]
        public string Msxml6 { get; set; }
        [Column("firmar_aa_virtual")]
        [StringLength(1)]
        public string FirmarAaVirtual { get; set; }
        [Required]
        [Column("proxy")]
        [StringLength(1)]
        public string Proxy { get; set; }
        [Column("proxy_url")]
        [StringLength(50)]
        public string ProxyUrl { get; set; }
        [Column("proxy_port")]
        [StringLength(5)]
        public string ProxyPort { get; set; }
        [Required]
        [Column("proxy_user")]
        [StringLength(20)]
        public string ProxyUser { get; set; }
        [Required]
        [Column("proxy_password")]
        [StringLength(20)]
        public string ProxyPassword { get; set; }
        [Column("ruta_archivos_xml_cove")]
        [StringLength(400)]
        public string RutaArchivosXmlCove { get; set; }
        [Column("ruta_edocuments")]
        [StringLength(250)]
        public string RutaEdocuments { get; set; }
        [Column("ruta_archivos_pdf_coved")]
        [StringLength(200)]
        public string RutaArchivosPdfCoved { get; set; }
        [Column("ftp_server")]
        [StringLength(30)]
        public string FtpServer { get; set; }
        [Column("ftp_folder")]
        [StringLength(30)]
        public string FtpFolder { get; set; }
        [Column("ftp_user")]
        [StringLength(20)]
        public string FtpUser { get; set; }
        [Column("ftp_password")]
        [StringLength(20)]
        public string FtpPassword { get; set; }
        [Column("ruta_respaldo_xml_cove")]
        [StringLength(500)]
        public string RutaRespaldoXmlCove { get; set; }
        [Column("validar_caracteres_automatico")]
        [StringLength(1)]
        public string ValidarCaracteresAutomatico { get; set; }
        [Column("porcentaje_error", TypeName = "decimal(4, 2)")]
        public decimal? PorcentajeError { get; set; }
        [Column("ruta_regeneracion_xml_cove")]
        [StringLength(500)]
        public string RutaRegeneracionXmlCove { get; set; }
        [Column("coves_no_pedimento")]
        [StringLength(1)]
        public string CovesNoPedimento { get; set; }
        [Column("prod_mercancia_cove")]
        [StringLength(2)]
        public string ProdMercanciaCove { get; set; }
    }
}
