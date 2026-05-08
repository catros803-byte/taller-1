using System;
using System.Collections.Generic;
using System.Text;

namespace taller1
{
   
   
        
namespace TallerPOO
    {
        public class Smartphone : DispositivoElectronico
        {
            // Variables private
            private int camara;
            private string operador;

            // GET Y SET DE CAMARA
            public int Camara
            {
                get
                {
                    return camara;
                }

                set
                {
                    camara = value;
                }
            }

            // GET Y SET DE OPERADOR
            public string Operador
            {
                get
                {
                    return operador;
                }

                set
                {
                    operador = value;
                }
            }

            // Constructor
            public Smartphone(
                string marca,
                string modelo,
                double precio,
                int camara,
                string operador
            ) : base(marca, modelo, precio)
            {
                Camara = camara;
                Operador = operador;
            }

            // Método propio
            public void Llamar()
            {
                Console.WriteLine("El celular está haciendo una llamada");
            }
        }
    }
}