using System.Transactions;
using System;
using PostSharp.Aspects;

namespace ECommercial.Core.Aspects.PostSharp.TransactionAspects
{
    [Serializable]
    public class TransactionScopeAspect:OnMethodBoundaryAspect
    {
        private TransactionScopeOption _transactionScopeOption;
        public TransactionScopeAspect(TransactionScopeOption option)
        {
            _transactionScopeOption=option;
        }
        public TransactionScopeAspect()
        {
            
        }

        public override void OnEntry(MethodExecutionArgs args)
        {
            args.MethodExecutionTag = new TransactionScope(_transactionScopeOption);
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Complete();
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            ((TransactionScope)args.MethodExecutionTag).Dispose();
        }

    }
}