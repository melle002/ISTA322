
//Program.cs------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Calculator calculator = new Calculator())
            {
                Console.WriteLine($"120 / 0 = {calculator.Divide(120, 0)}");
            }

            Console.WriteLine("Program finishing");
        }
    }
}
// Calculator.cs------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        private bool disposed = false;
        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }

        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }

        public int Divide(int first, int second)
        {
            return first / second;
        }

        public void Dispose()
        {
            if (!this.disposed)
            {
                Console.WriteLine("Calculator being disposed");
            }

            this.disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
