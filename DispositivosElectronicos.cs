namespace taller1
{
    using System;

    namespace TallerPOO
    {
        public abstract class DispositivoElectronico
        {
            protected string? marca;
            protected string? modelo;
            protected double precio;

            public string Marca
            {
                get
                {
                    return marca;
                }

                set
                {
                    if (value.Length == 0)
                    {
                        throw new Exception("La marca no puede estar vacía");
                    }

                    marca = value;
                }
            }

            public string Modelo
            {
                get
                {
                    return modelo;
                }

                set
                {
                    if (value.Length == 0)
                    {
                        throw new Exception("El modelo no puede estar vacío");
                    }

                    modelo = value;
                }
            }

            public double Precio
            {
                get
                {
                    return precio;
                }

                set
                {
                    if (value <= 0 || value > 50000000)
                    {
                        throw new Exception("Precio inválido");
                    }

                    precio = value;
                }
            }

            public DispositivoElectronico(string marca, string modelo, double precio)
            {
                Marca = marca;
                Modelo = modelo;
                Precio = precio;
            }

            public void Encender()
            {
                Console.WriteLine("El dispositivo se encendió");
            }

            public void MostrarInformacion()
            {
                Console.WriteLine("Marca: " + Marca);
                Console.WriteLine("Modelo: " + Modelo);
                Console.WriteLine("Precio: " + Precio);
            }
        }
    }
}

