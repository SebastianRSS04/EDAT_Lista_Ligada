using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!, Listas Ligadas");

        Console.WriteLine("");

        var singleList = new SingleList<String>();

        singleList.Add("Jose");
        singleList.Add("Sebastian");
        singleList.Add("Rodriguez");
        singleList.Add("Salgado");
        singleList.Add("ISC");

        Console.WriteLine(singleList);


        Console.ReadKey();
    }
}