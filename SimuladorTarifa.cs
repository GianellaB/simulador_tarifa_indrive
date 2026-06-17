public class SimuladorTarifa
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("        InDrive - Simulador de Tarifa");
        Console.WriteLine("=====================================");

        Console.WriteLine("Nombre del Pasajero");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese distancia del viaje (Km): ");
        double distancia = double.Parse(Console.ReadLine());

        Console.WriteLine("Hora de salida (0 hrs - 23 hrs): ");
        int hora = int.Parse(Console.ReadLine());

        Console.WriteLine("\nTipo de vehiculos: ");
        Console.WriteLine("1. Economico ");
        Console.WriteLine("2. Confort ");
        Console.WriteLine("3. Premium ");
        Console.WriteLine("4. Moto ");
        Console.WriteLine("Ingrese la opcion:  ");
        int tipoVehiculo = int.Parse(Console.ReadLine());
        
    }
}