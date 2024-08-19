namespace HolaMundo
{
    internal class Ejemplo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Michael, Ramirez");
           
            // Tipo de datos primitivos
            int edad = 19;
            Console.WriteLine($"Tu edad es: {edad} ");
            string nombre = "Michael Ramirez";
            Console.WriteLine($"Tu nombre completo es: {nombre}");
            Console.WriteLine($"Tu nombre completo es: {nombre.ToUpper()}");
            Console.WriteLine($"Tu nombre completo es: {nombre.ToLower()}");
            Console.WriteLine($"Tu nombre completo tiene: {nombre.Length} letras");

            // Variables con doble precision

            double precio = 30.7;
            Console.WriteLine($"El precio es de: {precio}");
            Console.WriteLine($"El precio es de: {precio++}");
            Console.WriteLine($"El precio es de: {++precio}");

            /* Valores logicos*/
            Boolean issingle = true;
            Console.WriteLine($"Tu eres soltero: {issingle}");
            Console.WriteLine($"Tu eres soltero: {!issingle}");
        }
    }
}