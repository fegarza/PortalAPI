using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Portal.API.TodasLastablas
{
    [Table("shipper_generales")]
    public partial class ShipperGenerale
    {
        [Key]
        [Column("SHIPPER_GENERALES_ID")]
        public int ShipperGeneralesId { get; set; }
        [Column("FILER_ID", TypeName = "numeric(18, 0)")]
        public decimal FilerId { get; set; }
        [Required]
        [Column("FILER_ID_TYPE")]
        [StringLength(1)]
        public string FilerIdType { get; set; }
        [Required]
        [Column("APPLICATION_IDENTIFIER")]
        [StringLength(2)]
        public string ApplicationIdentifier { get; set; }
        [Column("COUNTRY_ULTIMATE_DEST")]
        [StringLength(2)]
        public string CountryUltimateDest { get; set; }
        [Column("PORT_EXPORTATION_CODE")]
        [StringLength(4)]
        public string PortExportationCode { get; set; }
        [Column("BATCH_CONTROL_NUMBER", TypeName = "numeric(10, 0)")]
        public decimal? BatchControlNumber { get; set; }
        [Required]
        [Column("USPPI_ID_TYPE")]
        [StringLength(1)]
        public string UsppiIdType { get; set; }
        [Column("PARTY_ID_TYPE")]
        [StringLength(1)]
        public string PartyIdType { get; set; }
        [Required]
        [Column("PARTY_TYPE")]
        [StringLength(1)]
        public string PartyType { get; set; }
        [Column("CONTACT_FIRST_NAME")]
        [StringLength(13)]
        public string ContactFirstName { get; set; }
        [Column("CONTACT_LAST_NAME")]
        [StringLength(20)]
        public string ContactLastName { get; set; }
        [Column("EXP_INFORMATION_CODE")]
        [StringLength(2)]
        public string ExpInformationCode { get; set; }
        [Column("FOREIGN_DOMESTIC_ORIGIN")]
        [StringLength(1)]
        public string ForeignDomesticOrigin { get; set; }
        [Column("INBOND_CODE")]
        [StringLength(2)]
        public string InbondCode { get; set; }
        [Required]
        [Column("ROUTED_EXP_TRANSACT_IND")]
        [StringLength(1)]
        public string RoutedExpTransactInd { get; set; }
        [Column("FILING_OPTION_INDICATOR")]
        [StringLength(1)]
        public string FilingOptionIndicator { get; set; }
        [Column("FILES_PATH")]
        [StringLength(255)]
        public string FilesPath { get; set; }
        [Column("AES_FILE_PATH")]
        [StringLength(255)]
        public string AesFilePath { get; set; }
        [Required]
        [Column("ID_PATENTE")]
        [StringLength(4)]
        public string IdPatente { get; set; }
        [Required]
        [Column("XTN_PART")]
        [StringLength(20)]
        public string XtnPart { get; set; }
    }
}
