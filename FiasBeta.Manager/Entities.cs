using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FiasBeta.Entities
{
    [Table("ActualStatuses")]
    public class ActualStatus
    {
        [Column("ACTSTATID"), Key]
        public int ActStatId { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
    }

    [Table("AddressObjects")]
    public class AddressObject
    {
        [Column("AOGUID")]
        public string AoGuid { get; set; }

        [Column("FORMALNAME")]
        public string FormalName { get; set; }

        [Column("REGIONCODE")]
        public string RegionCode { get; set; }

        [Column("AUTOCODE")]
        public string AutoCode { get; set; }

        [Column("AREACODE")]
        public string AreaCode { get; set; }

        [Column("CITYCODE")]
        public string CityCode { get; set; }

        [Column("CTARCODE")]
        public string CtarCode { get; set; }

        [Column("PLACECODE")]
        public string PlaceCode { get; set; }

        [Column("PLANCODE")]
        public string PlanCode { get; set; }

        [Column("STREETCODE")]
        public string StreetCode { get; set; }

        [Column("EXTRCODE")]
        public string ExtrCode { get; set; }

        [Column("SEXTCODE")]
        public string SextCode { get; set; }

        [Column("OFFNAME")]
        public string OffName { get; set; }

        [Column("POSTALCODE")]
        public string PostalCode { get; set; }

        //[Column("IFNSFL")]
        //public string IfnsFl { get; set; }

        //[Column("TERRIFNSFL")]
        //public string TerrIfnsFl { get; set; }

        //[Column("IFNSUL")]
        //public string IfnsUl { get; set; }

        //[Column("TERRIFNSUL")]
        //public string TerrIfnsUl { get; set; }

        //[Column("OKATO")]
        //public string Okato { get; set; }

        //[Column("OKTMO")]
        //public string Oktmo { get; set; }

        [Column("SHORTNAME")]
        public string ShortName { get; set; }

        [Column("PARENTGUID")]
        public string ParentGuid { get; set; }

        [Column("AOID"), Key]
        public string AoId { get; set; }

        [Column("PREVID")]
        public string PrevId { get; set; }

        [Column("NEXTID")]
        public string NextId { get; set; }

        [Column("CODE")]
        public string Code { get; set; }

        [Column("PLAINCODE")]
        public string PlainCode { get; set; }

    }

    [Table("CenterStatuses")]
    public class CenterStatus
    {
        [Column("CENTERSTID"), Key]
        public int CenterStId { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
    }

    [Table("CurrentStatuses")]
    public class CurrentStatus
    {
        [Column("CURENTSTID"), Key]
        public int CurentStId { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
    }

    [Table("EstateStatuses")]
    public class EstateStatus
    {
        [Column("ESTSTATID"), Key]
        public string EstStatId { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("SHORTNAME")]
        public string ShortName { get; set; }
    }

    [Table("FlatTypes")]
    public class FlatType
    {
        [Column("FLTYPEID"), Key]
        public int FltypeId { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("SHORTNAME")]
        public string ShortName { get; set; }
    }

    [Table("Houses")]
    public class House
    {
        [Column("POSTALCODE")]
        public string PostalCode { get; set; }

        [Column("REGIONCODE")]
        public string RegionCode { get; set; }

        [Column("IFNSFL")]
        public string IfnsFl { get; set; }

        [Column("TERRIFNSFL")]
        public string TerrIfnsFl { get; set; }

        [Column("IFNSUL")]
        public string IfnsUl { get; set; }

        [Column("TERRIFNSUL")]
        public string TerrIfnsUl { get; set; }

        [Column("OKATO")]
        public string Okato { get; set; }

        [Column("OKTMO")]
        public string Oktmo { get; set; }

        [Column("UPDATEDATE")]
        public DateTimeOffset UpdateDate { get; set; }

        [Column("HOUSENUM")]
        public string HouseNum { get; set; }

        [Column("ESTSTATUS")]
        public int EstStatus { get; set; }

        [Column("BUILDNUM")]
        public string BuildNum { get; set; }

        [Column("STRUCNUM")]
        public string StrucNum { get; set; }

        [Column("STRSTATUS")]
        public int StrStatus { get; set; }

        [Column("HOUSEID"), Key]
        public int HouseId { get; set; }

        [Column("HOUSEGUID")]
        public string HouseGuid { get; set; }

        [Column("AOGUID")]
        public string AoGuid { get; set; }

        [Column("STARTDATE")]
        public DateTimeOffset StartDate { get; set; }

        [Column("ENDDATE")]
        public DateTimeOffset EndDate { get; set; }

        [Column("STATSTATUS")]
        public int StatStatus { get; set; }

        [Column("NORMDOC")]
        public string NormDoc { get; set; }

        [Column("COUNTER")]
        public int Counter { get; set; }

        [Column("CADNUM")]
        public string CadNum { get; set; }

        [Column("DIVTYPE")]
        public int DivType { get; set; }
    }

    [Table("HouseStateStatuses")]
    public class HouseStateStatus
    {
        [Column("HOUSESTID")]
        public int HouseStId { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
    }

    [Table("NormativeDocumentTypes")]
    public class NormativeDocumentType
    {
        [Column("NDTYPEID"), Key]
        public int NDocType { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
    }

    [Table("NormativeDocumentes")]
    public class NormativeDocumente
    {
        [Column("NORMDOCID")]
        public string NormDocId { get; set; }

        [Column("DOCNAME")]
        public string DocName { get; set; }

        [Column("DOCDATE")]
        public DateTimeOffset DocDate { get; set; }

        [Column("DOCNUM")]
        public string DocNum { get; set; }

        [Column("DOCTYPE")]
        public int DocType { get; set; }

        [Column("DOCIMGID")]
        public string DocImgId { get; set; }
    }

    [Table("OperationStatuses")]
    public class OperationStatus
    {
        [Column("OPERSTATID"), Key]
        public int OperStatId { get; set; }

        [Column("NAME")]
        public string Name { get; set; }
    }

    [Table("AddressObjectTypes")]
    public class AddressObjectType
    {
        [Column("LEVEL")]
        public int Level { get; set; }

        [Column("SCNAME")]
        public string ScName { get; set; }

        [Column("SOCRNAME")]
        public string SocrName { get; set; }

        [Column("KOD_T_ST")]
        public string KodTSt { get; set; }
    }

    [Table("Steads")]
    public class Stead
    {
        [Column("STEADGUID")]
        public string SteadGuid { get; set; }

        [Column("NUMBER")]
        public string Number { get; set; }

        [Column("REGIONCODE")]
        public string RegionCode { get; set; }

        [Column("POSTALCODE")]
        public string PostalCode { get; set; }

        [Column("IFNSFL")]
        public string IfnsFl { get; set; }

        [Column("TERRIFNSFL")]
        public string TerrIfnsFl { get; set; }

        [Column("IFNSUL")]
        public string IfnsUl { get; set; }

        [Column("TERRIFNSUL")]
        public string TerrIfnsUl { get; set; }

        [Column("OKATO")]
        public string Okato { get; set; }

        [Column("OKTMO")]
        public string Oktmo { get; set; }

        [Column("UPDATEDATE")]
        public DateTimeOffset UpdateDate { get; set; }

        [Column("PARENTGUID")]
        public string ParentGuid { get; set; }

        [Column("STEADID"), Key]
        public string SteadId { get; set; }

        [Column("PREVID")]
        public string PrevId { get; set; }

        [Column("NEXTID")]
        public string NextId { get; set; }

        [Column("OPERSTATUS")]
        public int OperStatus { get; set; }

        [Column("STARTDATE")]
        public DateTimeOffset StartDate { get; set; }

        [Column("ENDDATE")]
        public DateTimeOffset EndDate { get; set; }

        [Column("NORMDOC")]
        public string NormDoc { get; set; }

        [Column("LIVESTATUS")]
        public bool LiveStatus { get; set; }

        [Column("CADNUM")]
        public string CadNum { get; set; }

        [Column("DIVTYPE")]
        public int DivType { get; set; }
    }

    [Table("StructureStatuses")]
    public class StructureStatus
    {
        [Column("STRSTATID")]
        public int StrStatId { get; set; }

        [Column("NAME")]
        public string Name { get; set; }

        [Column("SHORTNAME")]
        public string ShortName { get; set; }
    }
}