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
        public Calculator()
        {
        
        }

        public IList<IOperation> GetOperations()
        {
            IList<IOperation> operations = new List<IOperation>();

            Type type = typeof(IOperation);

            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes();

            IOperation createdOperation;

            IEnumerable<Type> typesOfOperations = types.Where(t => t.GetInterfaces().Contains(type)).ToList();

            foreach (var operation in typesOfOperations)
            {    
                createdOperation = Activator.CreateInstance(operation) as IOperation;

                operations.Add(createdOperation);
            }

            return operations;
        }
    }
}
