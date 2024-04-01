using System.Reflection.Metadata;

namespace ejercicio5rep
{
    class program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Que desea hacer");
            Console.WriteLine("1. Modificar");
            Console.WriteLine("2. Insertar");

            int seleccion = int.Parse(Console.ReadLine());

            Console.WriteLine("Numero de la linea: ");
            int linea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Posicion: ");
            int posicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Texto: ");
            string texto = Console.ReadLine();

            StreamWriter sw;
            if (File.Exists("fichero.txt"))
            {
                for (int i = 0; i < linea; i++)
                {
                    sw.WriteLine("");
                }
                for (int j = 0; j < posicion; j++)
                {
                    sw.Write(" ");
                }
                switch (seleccion)
                {
                    case 1:
                        sw.Write(texto);
                        sw.Close();
                        Console.WriteLine("Ingresado con exito");
                        break;
                    case 2:
                        sw.WriteLine(texto);
                        sw.Close();
                        Console.WriteLine("Ingresado con exito");
                        break;
                }
            }
            else
            {
                sw = File.CreateText("fichero.txt");
                for (int i = 0; i < linea; i++)
                {
                    sw.WriteLine("");
                }
                for (int j = 0; j < posicion; j++)
                {
                    sw.Write(" ");
                }
                switch (seleccion)
                {
                    case 1:
                        sw.Write(texto);
                        sw.Close();
                        Console.WriteLine("Ingresado con exito");
                        break;
                    case 2:
                        sw.WriteLine(texto);
                        sw.Close();
                        Console.WriteLine("Ingresado con exito");
                        break;
                }
            }




        }
    }
}