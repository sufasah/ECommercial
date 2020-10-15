using System;
using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Shop:IEntity
    {
        public enum FirmTypes{Private,Incorporated,SoleProprietorShip,OrdinaryPartnership,Foundation};
        public enum FirmProfiles{Distributor,Importer,MainDealer,Dealer,Producer};
        public virtual long Iban { get; set; }
        public virtual long AuthorizedPhone { get; set; }
        public virtual long FırmOwnerPhone { get; set; }
        public virtual FirmTypes FirmType { get; set; }
        public virtual FirmProfiles FirmProfile { get; set; }
        public virtual int SellingSubcategoryId { get; set; }
        public virtual int CommercialRecordNumber { get; set; }
        public virtual short TaxOfficeCıtyId { get; set; }
        public virtual short TaxOfficeId { get; set; }
        public virtual long TaxOrTrIdNumber { get; set; }
        public virtual long MersisNumber { get; set; }
        public virtual long FirmFixedPhone { get; set; }
        public virtual short InvoiceCityId { get; set; }
        public virtual short InvoiceDistrictId { get; set; }
        public virtual short BankId { get; set; }
        public virtual short BranchCode { get; set; }
        public virtual long AccountNumber { get; set; }
        public virtual int Id { get; set; }
        public virtual bool AuthorizedGender { get; set; }
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