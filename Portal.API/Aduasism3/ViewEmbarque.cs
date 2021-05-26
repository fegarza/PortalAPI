using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Keyless]
    public partial class ViewEmbarque
    {
        [Column("almacen")]
        [StringLength(8)]
        public string Almacen { get; set; }
        [Required]
        [Column("almacenNombre")]
        [StringLength(40)]
        public string AlmacenNombre { get; set; }
        [Required]
        [Column("embarque")]
        [StringLength(10)]
        public string Embarque { get; set; }
        [Required]
        [Column("tipoOperacion")]
        [StringLength(1)]
        public string TipoOperacion { get; set; }
        [Required]
        [Column("operacion")]
        [StringLength(11)]
        public string Operacion { get; set; }
        [Column("aduana")]
        [StringLength(2)]
        public string Aduana { get; set; }
        [Column("seccion")]
        [StringLength(1)]
        public string Seccion { get; set; }
        [Column("aduanaSeccion")]
        [StringLength(3)]
        public string AduanaSeccion { get; set; }
        [Required]
        [Column("tipoEmbarque")]
        [StringLength(1)]
        public string TipoEmbarque { get; set; }
        [Required]
        [Column("tipoEmbarqueNombre")]
        [StringLength(13)]
        public string TipoEmbarqueNombre { get; set; }
        [Column("patente")]
        [StringLength(4)]
        public string Patente { get; set; }
        [Column("apoderado")]
        [StringLength(6)]
        public string Apoderado { get; set; }
        [Column("apoderadoNombre")]
        [StringLength(82)]
        public string ApoderadoNombre { get; set; }
        [Column("fechaEmbarque", TypeName = "datetime")]
        public DateTime? FechaEmbarque { get; set; }
        [Column("fechaCruce", TypeName = "datetime")]
        public DateTime? FechaCruce { get; set; }
        [Required]
        [Column("entradaAduana")]
        [StringLength(8)]
        public string EntradaAduana { get; set; }
        [Column("tipoPedimento")]
        [StringLength(2)]
        public string TipoPedimento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Fecha2doReconocimiento { get; set; }
        [Required]
        [StringLength(8)]
        public string SegundoReconocimiento { get; set; }
        [Column("fechaSalidaAduana", TypeName = "datetime")]
        public DateTime? FechaSalidaAduana { get; set; }
        [Column("observacionesEmbarque")]
        [StringLength(4000)]
        public string ObservacionesEmbarque { get; set; }
        [Column("fechaEntradaAduana", TypeName = "datetime")]
        public DateTime? FechaEntradaAduana { get; set; }
        [Column("secuencial", TypeName = "numeric(5, 0)")]
        public decimal Secuencial { get; set; }
        [Column("fechaSalidaBodega", TypeName = "datetime")]
        public DateTime? FechaSalidaBodega { get; set; }
        [Column("fechaGaritaInterior", TypeName = "datetime")]
        public DateTime? FechaGaritaInterior { get; set; }
        [Column("fechaEntregaCarrier", TypeName = "datetime")]
        public DateTime? FechaEntregaCarrier { get; set; }
        [Column("fechaSalidaOrigen", TypeName = "datetime")]
        public DateTime? FechaSalidaOrigen { get; set; }
        [Column("fechaLlegadaNvoLdo", TypeName = "datetime")]
        public DateTime? FechaLlegadaNvoLdo { get; set; }
        [Required]
        [Column("sello1")]
        [StringLength(12)]
        public string Sello1 { get; set; }
        [Required]
        [Column("sello2")]
        [StringLength(12)]
        public string Sello2 { get; set; }
        [Column("statusEmbarque")]
        public short? StatusEmbarque { get; set; }
        [StringLength(1)]
        public string Urgente { get; set; }
        [Column("usuarioIngreso")]
        [StringLength(6)]
        public string UsuarioIngreso { get; set; }
        [Column("fechaIngreso", TypeName = "datetime")]
        public DateTime? FechaIngreso { get; set; }
        [Column("usuarioModifica")]
        [StringLength(6)]
        public string UsuarioModifica { get; set; }
        [Column("fechaModifica", TypeName = "datetime")]
        public DateTime? FechaModifica { get; set; }
        [Column("no_secuencial", TypeName = "numeric(3, 0)")]
        public decimal NoSecuencial { get; set; }
        [Required]
        [Column("transfer")]
        [StringLength(4)]
        public string Transfer { get; set; }
        [Required]
        [Column("transferNombre")]
        [StringLength(40)]
        public string TransferNombre { get; set; }
        [Required]
        [Column("tipoVehiculo")]
        [StringLength(2)]
        public string TipoVehiculo { get; set; }
        [Column("tipoVehiculoNombre")]
        [StringLength(30)]
        public string TipoVehiculoNombre { get; set; }
        [Required]
        [Column("vehiculo")]
        [StringLength(20)]
        public string Vehiculo { get; set; }
        [Required]
        [Column("choferNombre")]
        [StringLength(30)]
        public string ChoferNombre { get; set; }
        [Required]
        [Column("capacidadArribo")]
        [StringLength(8)]
        public string CapacidadArribo { get; set; }
        [Required]
        [Column("capacidadSalida")]
        [StringLength(8)]
        public string CapacidadSalida { get; set; }
        [Required]
        [Column("tipoCaja")]
        [StringLength(12)]
        public string TipoCaja { get; set; }
        [Required]
        [Column("categoria")]
        [StringLength(23)]
        public string Categoria { get; set; }
        [Required]
        [Column("motivo")]
        [StringLength(23)]
        public string Motivo { get; set; }
        [Column("fecha", TypeName = "datetime")]
        public DateTime? Fecha { get; set; }
        [Required]
        [Column("cliente")]
        [StringLength(6)]
        public string Cliente { get; set; }
        [Required]
        [Column("clienteNombre")]
        [StringLength(120)]
        public string ClienteNombre { get; set; }
        [Required]
        [Column("destino")]
        [StringLength(3)]
        public string Destino { get; set; }
        [Column("direccionDestino")]
        [StringLength(695)]
        public string DireccionDestino { get; set; }
        [Column("tipoOrganizacion")]
        [StringLength(2)]
        public string TipoOrganizacion { get; set; }
        [StringLength(8)]
        public string Organizacion { get; set; }
        [Required]
        [Column("nombreOrganizacion")]
        [StringLength(120)]
        public string NombreOrganizacion { get; set; }
        [Required]
        [Column("lineaFletera")]
        [StringLength(4)]
        public string LineaFletera { get; set; }
        [Required]
        [Column("lineaNombre")]
        [StringLength(40)]
        public string LineaNombre { get; set; }
        [Required]
        [Column("entrego")]
        [StringLength(48)]
        public string Entrego { get; set; }
        [Required]
        [Column("guiaTalon")]
        [StringLength(20)]
        public string GuiaTalon { get; set; }
        [Required]
        [Column("recibio")]
        [StringLength(30)]
        public string Recibio { get; set; }
        [Column("fecha_hora", TypeName = "datetime")]
        public DateTime? FechaHora { get; set; }
        [Column("dobleOperador")]
        [StringLength(1)]
        public string DobleOperador { get; set; }
        [Column("fleteCobrar")]
        [StringLength(1)]
        public string FleteCobrar { get; set; }
        [Column("importeFlete", TypeName = "numeric(11, 2)")]
        public decimal ImporteFlete { get; set; }
        [Required]
        [Column("observaciones")]
        [StringLength(5000)]
        public string Observaciones { get; set; }
        [Required]
        [Column("observacionFacturar")]
        [StringLength(5000)]
        public string ObservacionFacturar { get; set; }
        [Required]
        [Column("observacionDestino")]
        [StringLength(5000)]
        public string ObservacionDestino { get; set; }
        [Required]
        [Column("trafico")]
        [StringLength(10)]
        public string Trafico { get; set; }
    }
}
