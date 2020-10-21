using System.Linq;
using Xunit;
using ECommercial.Core.DataAccess.EntitiyFramework;
using ECommercial.Entities.concrete;
using ECommercial.DataAccess.EntityFramework;
using System.Collections.Generic;

namespace ECommercial.DataAccess.Tests.EntityFramework.Integration
{
    public class RepositoryTests
    {
        // Prerequirements is these:
        // there must be get record and id is 1, update record and id is 2, delete records for delete tests 
        private EFIEntityRepositoryBase<Test,ECommercialContext> _repo = new EFIEntityRepositoryBase<Test,ECommercialContext>();
        private EFIQueryableRepositoryBase<Test> _queryablerepo = new EFIQueryableRepositoryBase<Test>(new ECommercialContext());
        [Fact]
        public void GetFunc(){
            Test value= new Test(1,null,"getitem delete will cause error in tests",null,null);

            Test result=_repo.Get(o=>o.Id==1);

            Assert.Equal(value,result);
        }
        [Fact]
        public void GetListFunc(){
            Test value= new Test(1,null,"getitem delete will cause error in tests",null,null);

            List<Test> result = _repo.GetList();
            Test foundval=result.Find(o=>o.Id==1);

            Assert.True(result.Count>1);
            Assert.Equal(foundval,value);
        }

        [Fact]
        public void GetListFuncFiltered(){
            Test value= new Test(1,null,"getitem delete will cause error in tests",null,null);

            Test result=_repo.GetList(o=>o.Id==1).First();

            Assert.Equal(value,result);
        }

        [Fact]
        public void InsertFunc(){
            Test value= new Test(0,null,"delete items",null,1);

            Test result=_repo.Add(value);

            Assert.Equal(value,result);
        }

        [Fact]
        public void UpdateFunc(){
            Test value= _repo.Get(o=>o.Id==2);

            if(value.Intgr is null)
                value.Intgr=1;
            else
                value.Intgr=null; 

            Test result=_repo.Update(value);

            Assert.True(result!=null);
        }

        [Fact]
        public void DeleteFunc(){

            Test value=_repo.GetList(o=>o.Varchr=="delete items").First();

            _repo.Delete(value);

        }

        [Fact]
        public void QueryableRepo_Get(){
            Assert.True(_queryablerepo.Table.Count()>1);
        }
    }
}