using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Shop:IEntity
    {
        public Shop()
        {
        }

        public Shop(string ıban, long? authorizedPhone, long? fırmOwnerPhone, FirmTypes? firmType, FirmProfiles? firmProfile, short? sellingSubcategoryId, int? commercialRecordNumber, short? taxOfficeCıtyId, short? taxOfficeId, long? taxOrTrIdNumber, long? mersisNumber, long? firmFixedPhone, short? ınvoiceCityId, short? ınvoiceDistrictId, short? bankId, short? branchCode, long? accountNumber, int? ıd, bool? authorizedGender, string username, string password, string shopOwnerName, string authorizedName, string authorizedSurname, string ınvoiceAddress, string authorizedPosition, string bankAccountOwner, string authorizedEmail, string firmOwnerName, string firmOwnerSurname, string branchBankName, string kepMail, string firmWebsite, string firmEmail, string legalFirmName, string ınvoiceEmail)
        {
            Iban = ıban;
            AuthorizedPhone = authorizedPhone;
            FırmOwnerPhone = fırmOwnerPhone;
            FirmType = firmType;
            FirmProfile = firmProfile;
            SellingSubcategoryId = sellingSubcategoryId;
            CommercialRecordNumber = commercialRecordNumber;
            TaxOfficeCityId = taxOfficeCıtyId;
            TaxOfficeId = taxOfficeId;
            TaxOrTrIdNumber = taxOrTrIdNumber;
            MersisNumber = mersisNumber;
            FirmFixedPhone = firmFixedPhone;
            InvoiceCityId = ınvoiceCityId;
            InvoiceDistrictId = ınvoiceDistrictId;
            BankId = bankId;
            BranchCode = branchCode;
            AccountNumber = accountNumber;
            Id = ıd;
            AuthorizedGender = authorizedGender;
            Username = username;
            Password = password;
            ShopOwnerName = shopOwnerName;
            AuthorizedName = authorizedName;
            AuthorizedSurname = authorizedSurname;
            InvoiceAddress = ınvoiceAddress;
            AuthorizedPosition = authorizedPosition;
            BankAccountOwner = bankAccountOwner;
            AuthorizedEmail = authorizedEmail;
            FirmOwnerName = firmOwnerName;
            FirmOwnerSurname = firmOwnerSurname;
            BranchBankName = branchBankName;
            KepMail = kepMail;
            FirmWebsite = firmWebsite;
            FirmEmail = firmEmail;
            LegalFirmName = legalFirmName;
            InvoiceEmail = ınvoiceEmail;
        }

        public enum FirmTypes{Private,Incorporated,SoleProprietorShip,OrdinaryPartnership,Foundation};
        public enum FirmProfiles{Distributor,Importer,MainDealer,Dealer,Producer};
        public virtual string Iban { get; set; }
        public virtual long? AuthorizedPhone { get; set; }
        public virtual long? FırmOwnerPhone { get; set; }
        public virtual FirmTypes? FirmType { get; set; }
        public virtual FirmProfiles? FirmProfile { get; set; }
        public virtual short? SellingSubcategoryId { get; set; }
        public virtual int? CommercialRecordNumber { get; set; }
        public virtual short? TaxOfficeCityId { get; set; }
        public virtual short? TaxOfficeId { get; set; }
        public virtual long? TaxOrTrIdNumber { get; set; }
        public virtual long? MersisNumber { get; set; }
        public virtual long? FirmFixedPhone { get; set; }
        public virtual short? InvoiceCityId { get; set; }
        public virtual short? InvoiceDistrictId { get; set; }
        public virtual short? BankId { get; set; }
        public virtual short? BranchCode { get; set; }
        public virtual long? AccountNumber { get; set; }
        public virtual int? Id { get; set; }
        public virtual bool? AuthorizedGender { get; set; }
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual string ShopOwnerName { get; set; }
        public virtual string AuthorizedName { get; set; }
        public virtual string AuthorizedSurname { get; set; }
        public virtual string InvoiceAddress { get; set; }
        public virtual string AuthorizedPosition { get; set; }
        public virtual string BankAccountOwner { get; set; }
        public virtual string AuthorizedEmail { get; set; }
        public virtual string FirmOwnerName { get; set; }
        public virtual string FirmOwnerSurname{ get; set; }
        public virtual string BranchBankName { get; set; }
        public virtual string KepMail { get; set; }
        public virtual string FirmWebsite{ get; set; }
        public virtual string FirmEmail { get; set; }
        public virtual string LegalFirmName { get; set; }
        public virtual string InvoiceEmail { get; set; }
    }
}