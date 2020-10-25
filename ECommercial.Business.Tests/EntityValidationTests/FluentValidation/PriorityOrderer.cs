using System.Collections.Generic;
using System.Linq;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace ECommercial.Business.Tests.EntityValidationTests.FluentValidation{
    public class PriorityOrderer : ITestCaseOrderer
    {
        public IEnumerable<TTestCase> OrderTestCases<TTestCase>(IEnumerable<TTestCase> testCases) where TTestCase : ITestCase
        {
            var testList = testCases.ToList();
            var priorityOrderedList = new SortedList<int,TTestCase>();
            for(int i=0;i<testList.Count;i++){
                var testCase=testList[i];
                var attributes= testCase.TestMethod.Method.GetCustomAttributes(typeof(TestPriorityAttribute));
                if(attributes==null)
                    continue;
                var attribute= attributes.FirstOrDefault();
                if(attribute==null)
                    continue;
                var arg= attribute.GetNamedArgument<int>("Priority");
                priorityOrderedList.Add(arg,testCase);
                testList.Remove(testCase);
                i--;
            }
            foreach(var keyValuePair in priorityOrderedList){
                yield return keyValuePair.Value;
            }
            foreach(TTestCase test in testList)
                yield return test;
            }
            
    }
}
