public class Persona {
    String nombre;
    int edad;

    public void saludar() {
        System.out.println("Hola, soy " + nombre);
    }
}

public class Animal {
    String especie;
    boolean domestico;

    public void sonido() {
        System.out.println("Hace un sonido");
    }
}

public class Vehiculo {
    String marca;
    int velocidad;

    public void acelerar() {
        velocidad += 10;
    }
}

public class Libro {
    String titulo;
    String autor;

    public void leer() {
        System.out.println("Leyendo " + titulo);
    }
}

public class Estudiante {
    String nombre;
    double promedio;

    public void estudiar() {
        System.out.println(nombre + " está estudiando");
    }
}