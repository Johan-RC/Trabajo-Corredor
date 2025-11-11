using System;

// Primer ejemplo de modificador de acceso en C#: PUBLIC
class EjemploPublic {
    public string Nombre = "Johan";
}

class Main1 {
    public static void Main() {
        EjemploPublic persona = new EjemploPublic();
        Console.WriteLine("Public: " + persona.Nombre);
    }
}

// Segundo ejemplo de modificador de acceso en C#: PRIVATE
class EjemploPrivate {
    private string Nombre = "Johan";

    public void MostrarNombre() {
        Console.WriteLine("Private: " + Nombre);
    }
}

class Main2 {
    public static void Main() {
        EjemploPrivate persona = new EjemploPrivate();
        persona.MostrarNombre(); // ✅ Solo acceso mediante método público
    }
}

// Tercer ejemplo de modificador de acceso en C#: PROTECTED
class PersonaBase {
    protected string Nombre = "Johan";
}

class Estudiante : PersonaBase {
    public void Mostrar() {
        Console.WriteLine("Protected: " + Nombre);
    }
}

class Main3 {
    public static void Main() {
        Estudiante e = new Estudiante();
        e.Mostrar();
    }
}

// Cuarto ejemplo de modificador de acceso en C#: INTERNAL (Internal: acceso dentro del mismo ensamblado)
internal class EjemploInternal {
    internal string Nombre = "Johan";
}

class Main4 {
    public static void Main() {
        EjemploInternal persona = new EjemploInternal();
        Console.WriteLine("Internal: " + persona.Nombre);
    }
}

// Quinto ejemplo de modificador de acceso en C#: COMBINADO
class EjemploCombinado {
    public string Nombre = "Johan";
    private int Edad = 18;
    protected string Ciudad = "Neiva";

    public void Mostrar() {
        Console.WriteLine($"Combinado: {Nombre}, {Edad} años, vive en {Ciudad}");
    }
}

class Main5 {
    public static void Main() {
        EjemploCombinado persona = new EjemploCombinado();
        persona.Mostrar();
    }
}
