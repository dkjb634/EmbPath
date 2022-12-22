using System;
using System.Reflection;

namespace GenericConsole
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var allResources = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            foreach (var s in allResources)
            {
                Console.WriteLine(s);
            }
        }
    }
}
