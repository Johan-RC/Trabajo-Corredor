using System;

/// <summary>
/// Representa una persona con nombre y edad
/// </summary>
public class Persona {
    private string nombre;
    private int edad;

    public string Nombre {
        get => nombre;
        set => nombre = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("El nombre no puede estar vacío");
    }

    public int Edad {
        get => edad;
        set => edad = value >= 0 ? value : throw new ArgumentException("La edad debe ser positiva");
    }

    public Persona(string nombre, int edad) {
        Nombre = nombre;
        Edad = edad;
    }

    public void Saludar() {
        Console.WriteLine($"¡Hola! Me llamo {Nombre} y tengo {Edad} años");
    }
}

/// <summary>
/// Representa un animal con su especie y si es doméstico
/// </summary>
public class Animal {
    public string Especie { get; set; }
    public bool EsDomestico { get; set; }

    public Animal(string especie, bool esDomestico) {
        Especie = especie;
        EsDomestico = esDomestico;
    }

    public void HacerSonido() {
        Console.WriteLine($"El {Especie} hace su sonido característico");
    }
}

/// <summary>
/// Representa un vehículo con marca y velocidad
/// </summary>
public class Vehiculo {
    private int velocidad;
    public string Marca { get; set; }
    public int Velocidad {
        get => velocidad;
        private set => velocidad = Math.Max(0, value);
    }

    public Vehiculo(string marca) {
        Marca = marca;
        Velocidad = 0;
    }

    public void Acelerar(int incremento = 10) {
        Velocidad += incremento;
        Console.WriteLine($"Velocidad actual: {Velocidad} km/h");
    }

    public void Frenar(int decremento = 10) {
        Velocidad -= decremento;
        Console.WriteLine($"Velocidad actual: {Velocidad} km/h");
    }
}

/// <summary>
/// Representa un libro con título y autor
/// </summary>
public class Libro {
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public Libro(string titulo, string autor) {
        Titulo = titulo;
        Autor = autor;
    }

    public void MostrarInfo() {
        Console.WriteLine($"'{Titulo}' escrito por {Autor}");
    }

    public void Leer() {
        Console.WriteLine($"Leyendo '{Titulo}'...");
    }
}

/// <summary>
/// Representa un estudiante con nombre y promedio
/// </summary>
public class Estudiante {
    private double promedio;
    public string Nombre { get; set; }
    public double Promedio {
        get => promedio;
        set => promedio = value >= 0 && value <= 10 ? value : throw new ArgumentException("El promedio debe estar entre 0 y 10");
    }

    public Estudiante(string nombre, double promedio = 0) {
        Nombre = nombre;
        Promedio = promedio;
    }

    public void Estudiar() {
        Console.WriteLine($"{Nombre} está estudiando para mejorar su promedio de {Promedio:F2}");
    }
}