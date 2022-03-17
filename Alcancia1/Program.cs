namespace Alcancia
{
    public static class Program
    {
        static void Main(string[] args)
        {
            int opcionDigitada = 0;
            int x;

            Acciones accion = new Acciones();

            while (opcionDigitada != 4)
            {
                Console.WriteLine("1. Ingresar moneda");
                Console.WriteLine("2. Cantidad de monedas por denominacón");
                Console.WriteLine("3. Valor por denominacón");
                Console.WriteLine("4. Salir");
                Console.WriteLine("___________________________");
                Console.WriteLine("Ingrese una opcion: ");

                string opcionDigitada2 = Console.ReadLine();

                if (int.TryParse(opcionDigitada2, out x))
                {
                    opcionDigitada = int.Parse(opcionDigitada2);

                    switch (opcionDigitada)
                    {
                        case 1:
                            accion.Ingresar();
                            break;

                        case 2:
                            accion.Listar();
                            break;

                        case 3:

                            break;

                        case 4:

                            break;

                        default:
                            Console.WriteLine("La opcion seleccionada no se encuentra disponible.");
                            break;
                    }
                }
                else
                {
                    opcionDigitada = 0;
                    Console.WriteLine("La opcion seleccionada no se encuentra disponible.");
                }
            }

        }

        public class Moneda
        {

            public Moneda()
            {
                int denominacion = 0;

            }

            public Moneda(int pdenominacion)
            {
                denominacion = pdenominacion;
            }

            public int denominacion { get; set; }
        }

        public class DatosMoneda
        {
            public static List<Moneda> MonedaList = new List<Moneda>();
        }
            
        public class Acciones
        {
            public void Ingresar()
            {
                int pregunta = 0;
                do
                {
                    Console.WriteLine("Ingrese la denominacion");
                    Console.WriteLine("Valores: 50 , 100, 200, 500, 1000");
                    int denominacion = int.Parse(Console.ReadLine());

                    if (denominacion == 50 || denominacion == 100 || denominacion == 200 || denominacion == 500 || denominacion == 1000)
                    {
                        Moneda moneda = new Moneda();
                        moneda.denominacion = denominacion;

                        DatosMoneda.MonedaList.Add(moneda);

                        System.Console.WriteLine("¿Quiere ingresar una moneda?");
                        pregunta = System.Convert.ToInt32(Console.ReadLine());

                        int suma = DatosMoneda.MonedaList.Sum(item => item.denominacion);

                        Console.WriteLine("___________________________");
                        Console.WriteLine("Cantidad total: " + suma);
                        Console.WriteLine("___________________________");
                    }
                } while (pregunta == 1);

            }

            public void Listar()
            {
                List<Moneda> lista = DatosMoneda.MonedaList.ToList();

                int opcion = 0;
                int x;

                int i = 0;

                while (opcion != 6)
                {
                    Console.WriteLine("___________________________");
                    Console.WriteLine("1. Mostrar de 50");
                    Console.WriteLine("2. Mostrar de 100");
                    Console.WriteLine("3. Mostrar de 200");
                    Console.WriteLine("4. Mostrar de 500");
                    Console.WriteLine("5. Mostrar de 1000");
                    Console.WriteLine("___________________________");
                    Console.WriteLine("Ingrese una opcion: ");

                    string opcion2 = Console.ReadLine();

                    if (int.TryParse(opcion2, out x))
                    {
                        opcion = int.Parse(opcion2);

                        switch (opcion)
                        {
                            case 1:
                                foreach (Moneda item in lista)
                                {

                                    if (item.denominacion == 50)
                                    {
                                        Console.WriteLine("Cantidad: " + lista.Count);
                                    }
                                }
                                break;

                            case 2:
                                foreach (Moneda item in lista)
                                {

                                    if (item.denominacion == 100)
                                    {
                                        Console.WriteLine("Cantidad: " + lista.Count);
                                    }
                                }
                                break;

                            case 3:
                                foreach (Moneda item in lista)
                                {

                                    if (item.denominacion == 200)
                                    {
                                        Console.WriteLine("Cantidad: " + lista.Count);
                                    }
                                }
                                break;

                            case 4:
                                foreach (Moneda item in lista)
                                {

                                    if (item.denominacion == 500)
                                    {
                                        Console.WriteLine("Cantidad: " + lista.Count);
                                    }
                                }
                                break;

                            case 5:
                                foreach (Moneda item in lista)
                                {

                                    if (item.denominacion == 1000)
                                    {
                                        Console.WriteLine("Cantidad: " + lista.Count);
                                    }
                                }
                                break;

                            default:
                                Console.WriteLine("La opcion seleccionada no se encuentra disponible.");
                                break;
                        }
                    }
                    else
                    {
                        opcion = 0;
                        Console.WriteLine("La opcion seleccionada no se encuentra disponible.");
                    }
                }
            }
        }
    }
}
