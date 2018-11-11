using dotnet_code_challenge.Config;
using System;

namespace dotnet_code_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var horsedetails = UnityConfig.GetManager().GetHorses();

            foreach (var horsedetail in horsedetails)
            {
                Console.WriteLine($"HorseName: {horsedetail.Name} :: Price: {horsedetail.Price}");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
