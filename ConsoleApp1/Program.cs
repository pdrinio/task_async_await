using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine($"{ DateTime.Now}: lanzando");
            Task<bool> t1 =  Aportacion.Ejecutar();
            Task t2 = Descarga.Ejecutar();

            Console.WriteLine($"{ DateTime.Now}: antes de los awaits");

            
            //01
            await t2;
            bool resultado = await t1;

            //02
            //await Task.WhenAll(t1, t2);

            Task t3 = Task.Run(async () =>
            {
                Console.WriteLine("Entra en 03");
                await Task.Delay(1000);
                Console.WriteLine("Acaba 03");
            });
            
            Console.WriteLine($"{ DateTime.Now}: finalizado");

            Console.ReadLine();


        }
    }
}
