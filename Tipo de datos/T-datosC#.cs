using System;
using System.Text.Json; // Para manejar JSON
using System.Text;      // Para manejar datos binarios

class TiposDeDatos
{
    static void Main()
    {
        // Primer ejemplo, Numérico
        int edad = 20;
        double sueldo = 1500.50;
        Console.WriteLine("Edad: " + edad + ", Sueldo: " + sueldo);

        // Seundo ejemplo, Texto
        string nombre = "Johan";
        Console.WriteLine("Nombre: " + nombre);

        // Tercer ejemplo, Booleano
        bool aprobado = true;
        Console.WriteLine("¿Aprobado?: " + aprobado);

        // Cuarto ejemplo, JSON
        var persona = new { Nombre = "Johan", Edad = 20 };
        string json = JsonSerializer.Serialize(persona);
        Console.WriteLine("JSON: " + json);

        // Quinto ejemplo, Binario
        byte[] datos = Encoding.UTF8.GetBytes("Hola mundo");
        Console.WriteLine("Datos binarios: " + BitConverter.ToString(datos));
    }
}
