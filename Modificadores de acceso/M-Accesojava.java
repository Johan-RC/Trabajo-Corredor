// Primer ejemplo de modificador de acceso en Java en: PUBLIC
class EjemploPublic {
    public String nombre = "Johan";
}

class Main1 {
    public static void main(String[] args) {
        EjemploPublic persona = new EjemploPublic();
        System.out.println("Public: " + persona.nombre);
    }
}

// Segundo ejemplo de modificador de acceso en Java: PRIVATE
class EjemploPrivate {
    private String nombre = "Johan";

    public void mostrarNombre() {
        System.out.println("Private: " + nombre);
    }
}

class Main2 {
    public static void main(String[] args) {
        EjemploPrivate persona = new EjemploPrivate();
        persona.mostrarNombre(); // Acceso mediante método público
    }
}

// Tercer ejemplo de modificador de acceso en Java: PROTECTED
class PersonaBase {
    protected String nombre = "Johan";
}

class Estudiante extends PersonaBase {
    public void mostrar() {
        System.out.println("Protected: " + nombre);
    }
}

class Main3 {
    public static void main(String[] args) {
        Estudiante est = new Estudiante();
        est.mostrar();
    }
}

// Cuarto ejemplo de modificador de acceso en Java: DEFAULT (o paquete)
class EjemploDefault {
    String nombre = "Johan"; // Sin modificador
}

class Main4 {
    public static void main(String[] args) {
        EjemploDefault persona = new EjemploDefault();
        System.out.println("Default: " + persona.nombre);
    }
}

// Quinto ejemplo combinando modificadores de acceso
class EjemploCombinado {
    public String nombre = "Johan";
    private int edad = 18;
    protected String ciudad = "Neiva";

    public void mostrar() {
        System.out.println("Combinado: " + nombre + ", " + edad + " años, vive en " + ciudad);
    }
}

class Main5 {
    public static void main(String[] args) {
        EjemploCombinado persona = new EjemploCombinado();
        persona.mostrar();
    }
}
