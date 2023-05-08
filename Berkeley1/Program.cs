using Berkeley1.Service.Interfaces;
using Ninject;
using System;
using System.Reflection;

namespace Berkeley1
{
    internal class Program
    {
        /// <summary>
        /// This method will reverse each string in the args array and write the results to the console output.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                Console.WriteLine($@"Usage {Assembly.GetExecutingAssembly().GetName().Name} ""string1"" ""string2"" ""etc""");
            }
            IKernel _Kernal = new StandardKernel();
            _Kernal.Load(Assembly.GetExecutingAssembly());
            var stringService = _Kernal.Get<IStringService>();
            foreach(string s in args)
            {
                Console.WriteLine($"{s} reversed is {stringService.ReverseString(s)}");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
