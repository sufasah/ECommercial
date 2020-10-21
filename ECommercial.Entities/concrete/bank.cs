using ECommercial.Core.Entities;

namespace ECommercial.Entites.concrete
{
    public class Bank:IEntity
    {
        public Bank()
        {
        }

        public Bank(short ıd, string name, string address, string telephone, string fax, string web, string telex, string eft, string swift)
        {
            Id = ıd;
            Name = name;
            Address = address;
            Telephone = telephone;
            Fax = fax;
            Web = web;
            Telex = telex;
            Eft = eft;
            Swift = swift;
        }

        public virtual short Id { get; set; }

        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string Telephone { get; set; }
        public virtual string Fax { get; set; }
        public virtual string Web { get; set; }
        public virtual string Telex { get; set; }
        public virtual string Eft { get; set; }
        public virtual string Swift { get; set; }
    }
}