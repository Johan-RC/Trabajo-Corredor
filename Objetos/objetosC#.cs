using System;

// Función principal
class Program
{
    static void Main()
    {
        // Primer ejemplo de objetos en C#
        Persona p1 = new Persona();
        p1.Nombre = "Carlos";
        p1.Saludar();

        // Segundo ejemplo de objetos en C#
        Carro c1 = new Carro();
        c1.Marca = "Nissan";
        c1.Encender();

        // Tercer ejemplo de objetos en C#
        Perro perro1 = new Perro();
        perro1.Nombre = "Max";
        perro1.Ladrar();

        // Cuarto ejemplo de objetos en C#
        Libro l1 = new Libro();
        l1.Titulo = "Cien años de soledad";
        l1.Mostrar();

        // Quinto ejemplo de objetos en C#
        Celular cel1 = new Celular();
        cel1.Marca = "Samsung";
        cel1.Prender();
    }
}

// Clases sencillas para los objetos

//Clase para el primer ejemplo
class Persona
{
    public string Nombre;
    public void Saludar()
    {
        Console.WriteLine("Hola, soy " + Nombre);
    }
}
// Clase para el segundo ejemplo
class Carro
{
    public string Marca;
    public void Encender()
    {
        Console.WriteLine("El carro " + Marca + " está encendido");
    }
}
// Clase para el tercer ejemplo
class Perro
{
    public string Nombre;
    public void Ladrar()
    {
        Console.WriteLine(Nombre + " dice guau guau");
    }
}
// Clase para el cuarto ejemplo
class Libro
{
    public string Titulo;
    public void Mostrar()
    {
        Console.WriteLine("Leyendo " + Titulo);
    }
}
// Clase para el quinto ejemplo
class Celular
{
    public string Marca;
    public void Prender()
    {
        Console.WriteLine("Encendiendo " + Marca);
    }
}
