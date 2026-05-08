using System;
using taller1.TallerPOO;
using static taller1.laptop;

namespace TallerPOO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Laptop laptop1 = new Laptop(
                    "NovaTech",
                    "FireX 15",
                    4200000,
                    16,
                    "Intel i7"
                );

                Console.WriteLine("----- LAPTOP -----");

                laptop1.Encender();
                laptop1.MostrarInformacion();
                laptop1.Jugar();

                Console.WriteLine();

                Smartphone celular1 = new Smartphone(
                    "SkyMobile",
                    "Ultra Z",
                    3100000,
                    108,
                    "Movistar"
                );

                Console.WriteLine("----- SMARTPHONE -----");

                celular1.Encender();
                celular1.MostrarInformacion();
                celular1.Llamar();

                Console.WriteLine();

                Smartphone error = new Smartphone(
                    "",
                    "XPhone",
                    -100,
                    50,
                    "Claro"
                );
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}