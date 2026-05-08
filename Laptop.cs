using System;
using System.Collections.Generic;
using System.Text;
using taller1.TallerPOO;

namespace taller1
{
    internal class laptop
    {
        public class Laptop : DispositivoElectronico
        {
            // Variables private
            private int ram;
            private string procesador;

            // GET Y SET DE RAM
            public int Ram
            {
                get
                {
                    return ram;
                }

                set
                {
                    ram = value;
                }
            }

            // GET Y SET DE PROCESADOR
            public string Procesador
            {
                get
                {
                    return procesador;
                }

                set
                {
                    procesador = value;
                }
            }

            // Constructor
            public Laptop(
                string marca,
                string modelo,
                double precio,
                int ram,
                string procesador
            ) : base(marca, modelo, precio)
            {
                Ram = ram;
                Procesador = procesador;
            }

            // Método propio
            public void Jugar()
            {
                Console.WriteLine("La laptop está ejecutando un juego");
            }
        }
    }
}