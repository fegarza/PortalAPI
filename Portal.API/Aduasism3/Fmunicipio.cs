using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("fmunicipio")]
    [Index(nameof(Rowguid), Name = "index_65435307", IsUnique = true)]
    public partial class Fmunicipio
    {
        public Fmunicipio()
        {
            Faduanas = new HashSet<Faduana>();
            FagAdAmes = new HashSet<FagAdAme>();
            FagAdMices = new HashSet<FagAdMex>();
            FagenciaAduanals = new HashSet<FagenciaAduanal>();
            Fapoderados = new HashSet<Fapoderado>();
            Fbancos = new HashSet<Fbanco>();
            FclienteEscapes = new HashSet<FclienteEscape>();
            Fconsignatarios = new HashSet<Fconsignatario>();
            Fcorresponsals = new HashSet<Fcorresponsal>();
            Fescapes = new HashSet<Fescape>();
            Fforwardings = new HashSet<Fforwarding>();
            FlineaFleteras = new HashSet<FlineaFletera>();
            FproveedorInternos = new HashSet<FproveedorInterno>();
            Fproveedors = new HashSet<Fproveedor>();
            Fusuarios = new HashSet<Fusuario>();
        }

        [Key]
        [Column("id_municipio")]
        [StringLength(4)]
        public string IdMunicipio { get; set; }
        [Required]
        [Column("id_estado")]
        [StringLength(4)]
        public string IdEstado { get; set; }
        [Required]
        [Column("descripcion")]
        [StringLength(80)]
        public string Descripcion { get; set; }
        [Column("desc_breve")]
        [StringLength(10)]
        public string DescBreve { get; set; }
        [Column("cve_municipio")]
        [StringLength(5)]
        public string CveMunicipio { get; set; }
        [Column("rowguid")]
        public Guid Rowguid { get; set; }
        [Column("inactivo")]
        [StringLength(1)]
        public string Inactivo { get; set; }

        [ForeignKey(nameof(IdEstado))]
        [InverseProperty(nameof(Festado.Fmunicipios))]
        public virtual Festado IdEstadoNavigation { get; set; }
        [InverseProperty(nameof(Faduana.IdMunicipioNavigation))]
        public virtual ICollection<Faduana> Faduanas { get; set; }
        [InverseProperty(nameof(FagAdAme.IdMunicipioNavigation))]
        public virtual ICollection<FagAdAme> FagAdAmes { get; set; }
        [InverseProperty(nameof(FagAdMex.IdMunicipioNavigation))]
        public virtual ICollection<FagAdMex> FagAdMices { get; set; }
        [InverseProperty(nameof(FagenciaAduanal.IdMunicipioNavigation))]
        public virtual ICollection<FagenciaAduanal> FagenciaAduanals { get; set; }
        [InverseProperty(nameof(Fapoderado.IdMunicipioNavigation))]
        public virtual ICollection<Fapoderado> Fapoderados { get; set; }
        [InverseProperty(nameof(Fbanco.IdMunicipioNavigation))]
        public virtual ICollection<Fbanco> Fbancos { get; set; }
        [InverseProperty(nameof(FclienteEscape.IdMunicipioNavigation))]
        public virtual ICollection<FclienteEscape> FclienteEscapes { get; set; }
        [InverseProperty(nameof(Fconsignatario.IdMunicipioNavigation))]
        public virtual ICollection<Fconsignatario> Fconsignatarios { get; set; }
        [InverseProperty(nameof(Fcorresponsal.IdMunicipioNavigation))]
        public virtual ICollection<Fcorresponsal> Fcorresponsals { get; set; }
        [InverseProperty(nameof(Fescape.IdMunicipioNavigation))]
        public virtual ICollection<Fescape> Fescapes { get; set; }
        [InverseProperty(nameof(Fforwarding.IdMunicipioNavigation))]
        public virtual ICollection<Fforwarding> Fforwardings { get; set; }
        [InverseProperty(nameof(FlineaFletera.IdMunicipioNavigation))]
        public virtual ICollection<FlineaFletera> FlineaFleteras { get; set; }
        [InverseProperty(nameof(FproveedorInterno.MunicipioNavigation))]
        public virtual ICollection<FproveedorInterno> FproveedorInternos { get; set; }
        [InverseProperty(nameof(Fproveedor.IdMunicipioNavigation))]
        public virtual ICollection<Fproveedor> Fproveedors { get; set; }
        [InverseProperty(nameof(Fusuario.IdMunicipioNavigation))]
        public virtual ICollection<Fusuario> Fusuarios { get; set; }
    }
}
