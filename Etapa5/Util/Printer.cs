using static System.Console;
namespace CoreEscuela.Util
{
	public static class Printer
	{
		public static void DibujarLinea(int tam = 10)
		{
			Console.WriteLine("".PadLeft(tam,'='));
		}

        public static void WriteTitle(string title = "Título por defecto")
        {
            title = $"| {title} |";
            DibujarLinea(title.Length);
            WriteLine(title);
            DibujarLinea(title.Length);
        }

        public static void Beep (int hz = 2000, int tiempo = 500, int cantidad = 1)
        {
            while (cantidad-- > 0)
            {
                Console.Beep(hz, tiempo);
            }
        }
    }
}
