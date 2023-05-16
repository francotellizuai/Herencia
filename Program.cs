namespace Herencia
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Pasajero estudiante = new Estudiante("Franco", "Telliz", 23, 123, "UAI");
            Estudiante estudiante2 = new Estudiante("Fernando", "Telliz", 26, 124, "UAI");
            //Estudiante estudiante2 = (Estudiante)estudiante;

            Colectivo colectivo = new Colectivo();

            colectivo.VenderBoleto(estudiante);
            colectivo.VenderBoleto(estudiante2);

 
            Console.WriteLine("Cantidad de pasajeron en el colectivo: " + colectivo.GetCantidadPasajeros());
        }
    }
}


