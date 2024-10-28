using ListaLigada.Logica;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!, Listas Ligadas");

        Console.WriteLine("");

        var singleList = new SingleList<String>();

        int opcion = 0;
        do

        {
            opcion = Menu();

            switch (opcion) 
            {
                case 1: AgregarElemento();
                    break;
                case 2: MostrarLista(); break;

                case 3: break;

                default: Console.WriteLine("Esta opcion no exite"); 
                    break;
            
            }
        }
        while (opcion != 0);

        Console.WriteLine(singleList);

        //Metodo agregar

        void AgregarElemento()
        {
            Console.WriteLine("\n ----------------------- \n");
            Console.WriteLine("Escribe el nombre del nodo \n");
            var data = Console.ReadLine();
            singleList.Add(data);
        }

        void MostrarLista() 
        { 
            Console.WriteLine("La lista es: \n");
            Console.WriteLine(singleList);    
        
        }



        Console.ReadKey();
    }

    

    private static int Menu()
    {
        Console.WriteLine("\n ----------------------- \n");
        Console.WriteLine("Menu \n");
        Console.WriteLine("1. Agregar elemento \n");
        Console.WriteLine("2. Monstrar la Lista \n");
        Console.WriteLine("0. Salir \n");

        bool esValido = false;

        int opcion = 0;

        do
        {
            Console.WriteLine("Elije una opcion del menu: \n");
            var opcionCapturada = Console.ReadLine();

            if (!int.TryParse(opcionCapturada, out opcion) || opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Dijite una opcion valida.");
                esValido = false;
            }
            else 
            { 
                esValido = true;    
            }
        }
        while (esValido == false);

        return opcion; 
    } 
}