using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
           var result = InsertNumberLib.InsertNumberClassLib.InsertNumber(8, 15, 3 ,5 );
            Console.WriteLine(result);
        }
    }
}
