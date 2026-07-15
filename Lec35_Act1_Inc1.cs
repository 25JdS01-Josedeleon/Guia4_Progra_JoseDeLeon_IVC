internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nombre: Jose de Leon\n" +
            "Grado: IVC\n"+
            "Clave: 10\n"+
            "==Conversiones==");
        int pago;
        string producto;
        Console.WriteLine("Digite el nombre del producto");
        producto = Console.ReadLine();
        Console.WriteLine("Dame el precio del producto; ");
        int precio= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("digite el valor del bilete: ");
        pago = Convert.ToInt32(Console.ReadLine());
        int cambio = pago - precio;
        Console.WriteLine("Su cambio es: " + cambio);
    }
}