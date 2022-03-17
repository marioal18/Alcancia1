using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5;
            int menu;
            int cantidad = 0;

            int moneda1 = 0;
            int moneda2 = 0;
            int moneda3 = 0;
            int moneda4 = 0;
            int moneda5 = 0;

            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;
            int total5 = 0;
            int totalT = 0;

            Ahorro m = new Ahorro();
            List<Ahorro> lista = new List<Ahorro>(total);
            List<Ahorro> listaMoneda1 = new List<Ahorro>(total);
            List<Ahorro> listaMoneda2 = new List<Ahorro>(total);
            List<Ahorro> listaMoneda3 = new List<Ahorro>(total);
            List<Ahorro> listaMoneda4 = new List<Ahorro>(total);
            List<Ahorro> listaMoneda5 = new List<Ahorro>(total);

            do
            {
                Console.WriteLine("\n 1. Insertar monedas \n 2. Total de monedas \n 3. Dinero total \n 4. cantidad de moneda por denominacion \n 5. Cantidad de dinero  por denominacion \n 6. Salir");

                menu = System.Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (menu >= 1 || menu <= 6)
                {
                    Console.WriteLine("ERROR");
                }

                Console.Clear();


                switch (menu)
                {
                    case 1:
                        Console.WriteLine("\n Insertar moneda");
                        m.moneda = int.Parse(Console.ReadLine());
                        if (m.moneda == 50 || m.moneda == 100 || m.moneda == 200 || m.moneda == 500 || m.moneda == 1000)
                        {
                            Console.WriteLine("GUARDADO");
                            lista.Add(new Ahorro(m.moneda));
                            cantidad = 0;
                            cantidad++;
                        }
                        else
                        {
                            Console.WriteLine("Ingrese una moneda valida");
                        }

                        if (m.moneda == 50)
                        {
                            listaMoneda1.Add(new Ahorro(m.moneda));
                            moneda1 = 0;
                            moneda1++;
                            total1 = listaMoneda1.Count * 50;
                        }
                        else if (m.moneda == 100)
                        {
                            listaMoneda2.Add(new Ahorro(m.moneda));
                            moneda2 = 0;
                            moneda2++;
                            total2 = listaMoneda2.Count * 100;
                        }
                        else if (m.moneda == 200)
                        {
                            listaMoneda3.Add(new Ahorro(m.moneda));
                            moneda3 = 0;
                            moneda3++;
                            total3 = listaMoneda3.Count * 200;
                        }
                        else if (m.moneda == 500)
                        {
                            listaMoneda4.Add(new Ahorro(m.moneda));
                            moneda4 = 0;
                            moneda4++;
                            total4 = listaMoneda4.Count * 500;
                        }
                        else if (m.moneda == 1000)
                        {
                            listaMoneda5.Add(new Ahorro(m.moneda));
                            moneda5 = 0;
                            moneda5++;
                            total5 = listaMoneda5.Count * 500;
                        }
                        break;

                    case 2:
                        Console.WriteLine($"Se han registrado  " + lista.Count + $" monedas.");
                        break;

                    case 3:
                        totalT = total1 + total2 + total3 + total4 + total5;
                        Console.WriteLine($"Cantidad de dinero " + totalT);
                        break;

                    case 4:
                        Console.WriteLine($"Cantidad de monedas por denominacion de 50 es: " + listaMoneda1.Count + $" monedas.");
                        Console.WriteLine($"Cantidad de monedas por denominacion de 100 es: " + listaMoneda2.Count + $" monedas.");
                        Console.WriteLine($"Cantidad de monedas por denominacion de 200 es: " + listaMoneda3.Count + $" monedas.");
                        Console.WriteLine($"Cantidad de monedas por denominacion de 500 es: " + listaMoneda4.Count + $" monedas.");
                        Console.WriteLine($"Cantidad de monedas por denominacion de 1000 es: " + listaMoneda5.Count + $" monedas.");
                        break;

                    case 5:
                        total1 = 50 * listaMoneda1.Count;
                        total2 = 100 * listaMoneda2.Count;
                        total3 = 200 * listaMoneda3.Count;
                        total4 = 500 * listaMoneda4.Count;
                        total5 = 1000 * listaMoneda5.Count;
                        Console.WriteLine($"Cantidad de dinero por denominacion de 50 es: " + total1);
                        Console.WriteLine($"Cantidad de dinero por denominacion de 100 es: " + total2);
                        Console.WriteLine($"Cantidad de dinero por denominacion de 200 es: " + total3);
                        Console.WriteLine($"Cantidad de dinero por denominacion de 500 es: " + total4);
                        Console.WriteLine($"Cantidad de dinero por denominacion de 1000 es: " + total5);
                        break;

                    case 6:
                        Console.WriteLine("Saliendo...");
                        break;
                }
            }
            while (menu != 6);
            Console.Clear();
        }
    }

    public class Ahorro : Alcancia
    {
        public override int moneda { get; set; }
        public Ahorro(int moneda)
        {
            this.moneda = moneda;
        }
        public Ahorro()
        {
        }
    }

    public abstract class Alcancia
    {
        public abstract int moneda { get; set; }
    }
}
