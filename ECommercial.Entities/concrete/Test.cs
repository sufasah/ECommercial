using System.Linq;
using System;
using System.Diagnostics.CodeAnalysis;
using ECommercial.Core.Entities;

namespace ECommercial.Entities.concrete
{
    public class Test:IEntity,IEquatable<Test>
    {
        public Test()
        {
        }

        public Test(int ıd, char? chr, string varchr, string[] varchrArray, int? intgr)
        {
            Id = ıd;
            Chr = chr;
            Varchr = varchr;
            VarchrArray = varchrArray;
            Intgr = intgr;
        }

        public virtual int Id { get; set; }

        public virtual char? Chr { get; set; }

        public virtual string Varchr { get; set; }

        public virtual string[] VarchrArray { get; set; }
        public virtual int? Intgr { get; set; }

        public bool Equals([AllowNull] Test other)
        {
            bool res= Id==other.Id&&
             Chr==other.Chr&&
             Varchr==other.Varchr&&
             Intgr==other.Intgr;

            if(!res)
                return false;
            if((VarchrArray is null||VarchrArray.Length==0) && (other.VarchrArray is null || other.VarchrArray.Length==0))
                return true;
            if(VarchrArray!=null)
                return VarchrArray.SequenceEqual(other.VarchrArray??new string[]{});
            else
                return false;
        }
    }
}