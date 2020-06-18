using Calculator.Enum;
using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;

namespace Calculator
{
    public class Calculator
    {
        private IOperation _operation;

        public Calculator()
        {
        
        }

        public IList<IOperation> GetOperations()
        {
            IList<IOperation> operations = new List<IOperation>();

            Type type = typeof(IOperation);

            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes();

            IEnumerable<Type> typeOfOperation = types.Where(t => t.GetInterfaces().Contains(type));

            

            var instantiatedOperation = Activator.CreateInstance(type) as IOperation;

            operations.Add(instantiatedOperation);

            return operations;
        }
    }
}
