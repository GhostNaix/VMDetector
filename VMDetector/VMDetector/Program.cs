using System;
namespace VMDetector
{
    class Program
    {
        private static string s = "null";
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            Run();
        }

        private static void Run()
        {
            VirtualMachineDetector VMD = new VirtualMachineDetector();
            bool VMHypervisor = VMD.Assert(out s);
            Console.WriteLine($"DETECTED {s}!");
            Console.WriteLine($"Press any key to proceed");
            Console.ReadKey();
        }
    }
}