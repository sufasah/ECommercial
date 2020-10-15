using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Shop:IEntity
    {
        public enum FirmTypes{Private,Incorporated,SoleProprietorShip,OrdinaryPartnership,Foundation};
        public enum FirmProfiles{Distributor,Importer,MainDealer,Dealer,Producer};
        public long Iban { get; set; }
        public long AuthorizedPhone { get; set; }
        public long FırmOwnerPhone { get; set; }
        public FirmTypes FirmType { get; set; }
        public FirmProfiles FirmProfile { get; set; }
        public int SellingSubcategoryId { get; set; }
        public int CommercialRecordNumber { get; set; }
        public short TaxOfficeCıtyId { get; set; }
        public short TaxOfficeId { get; set; }
        public long TaxOrTrIdNumber { get; set; }
        public long MersisNumber { get; set; }
        public long FirmFixedPhone { get; set; }
        public short InvoiceCityId { get; set; }
        public short InvoiceDistrictId { get; set; }
        public short BankId { get; set; }
        public short BranchCode { get; set; }
        public long AccountNumber { get; set; }
        public int Id { get; set; }
        public bool AuthorizedGender { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ShopOwnerName { get; set; }
        public string AuthorizedName { get; set; }
        public string AuthorizedSurname { get; set; }
        public string InvoiceAddress { get; set; }
        public string AuthorizedPosition { get; set; }
        public string BankAccountOwner { get; set; }
        public string AuthorizedEmail { get; set; }
        public string FirmOwnerName { get; set; }
        public string FirmOwnerSurname{ get; set; }
        public string BranchBankName { get; set; }
        public string KepMail { get; set; }
        public string FirmWebsite{ get; set; }
        public string FirmEmail { get; set; }
        public string LegalFirmName { get; set; }
        public string InvoiceEmail { get; set; }
    }
}