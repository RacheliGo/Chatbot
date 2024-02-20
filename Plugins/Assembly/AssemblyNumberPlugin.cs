using BasePlugin.Interfaces;
using BasePlugin.Records;
using System;
using System.IO;

namespace Assembly
{
    public class AssemblyNumberPlugin : IPlugin
    {
        public static string _Id => "assenblyNumber";
        public string Id => _Id;

        public PluginOutput Execute(PluginInput input)
        {
            Console.WriteLine("Please enter number");
            int number = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 2; i<=number; i++)
            {
                sum *= i;
            }

            return new PluginOutput(sum.ToString());
        }
    }
}