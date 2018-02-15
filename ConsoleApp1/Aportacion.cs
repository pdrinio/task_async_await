using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp1
{
    class Aportacion
    {
        public static async Task<bool> Ejecutar()
        {
            await Task.Delay(1500);
            Console.WriteLine("01: aportación");

            return true;
        }
    }
}