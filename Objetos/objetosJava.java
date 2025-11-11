package Objetos;
// Clase sencilla para el primer ejemplo
class Persona {
    String nombre;
    Persona(String nombre) { this.nombre = nombre; }
    void saludar() { System.out.println("Hola, soy " + nombre); }
}
// Clase sencilla para el segundo ejemplo
class Carro {
    String marca;
    Carro(String marca) { this.marca = marca; }
    void encender() { System.out.println("El carro " + marca + " está encendido"); }
}
// Clase sencilla para el tercer ejemplo
class Perro {
    String nombre;
    Perro(String nombre) { this.nombre = nombre; }
    void ladrar() { System.out.println(nombre + " dice guau guau"); }
}
// Clase sencilla para el cuarto ejemplo
class Libro {
    String titulo;
    Libro(String titulo) { this.titulo = titulo; }
    void mostrar() { System.out.println("Leyendo " + titulo); }
}
// Clase sencilla para el quinto ejemplo
class Computador {
    String marca;
    Computador(String marca) { this.marca = marca; }
    void prender() { System.out.println("Encendiendo " + marca); }
}

// Objetos 

// Clase principal con main
class EjemplosObjetos {
    public static void main(String[] args) {
        //Primer ejemplo de objetos en Java
        Persona p1 = new Persona("Laura");
        p1.saludar();
        //Segundo ejemplo de objetos en Java
        Carro c1 = new Carro("Toyota");
        c1.encender();
        //Tercer ejemplo de objetos en Java
        Perro perro1 = new Perro("Rocky");
        perro1.ladrar();
        //Cuarto ejemplo de objetos en Java
        Libro libro1 = new Libro("El Principito");
        libro1.mostrar();
        //Quinto ejemplo de objetos en Java
        Computador pc1 = new Computador("HP");
        pc1.prender();
    }
}
