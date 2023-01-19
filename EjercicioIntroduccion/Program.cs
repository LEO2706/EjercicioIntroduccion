Console.WriteLine("***************************");
Console.WriteLine("Ejecicio #1");
Console.WriteLine("");
Console.Write("Mi Nombre es:");
string nombre = Console.ReadLine();

Console.WriteLine($"El nombre recibido es, {nombre}");

Console.WriteLine("");
Console.WriteLine("***************************");
Console.WriteLine("***************************");
Console.WriteLine("Ejecicio #2");
DateTime hora = DateTime.Now;
Console.WriteLine($"La Hora es: {hora.ToString("HH:mm:ss.ff")}");
