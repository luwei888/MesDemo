using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesDemo.Common
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Md5.GetMD5String("a"));
            Console.WriteLine(Md5.GetMD5String("b"));
        }
    }
}
