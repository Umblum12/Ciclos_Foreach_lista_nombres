// See https://aka.ms/new-console-template for more information
List<string> nombres = new List<string>();
nombres.Add("Juan");
nombres.Add("Lupita");
nombres.Add("Martha");
nombres.Add("Rafael");
nombres.Add("Alberto");
nombres.Add("Dolores");
foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}
Console.ReadKey(true);