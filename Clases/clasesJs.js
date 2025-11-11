// Primer ejemplo de clase en JavaScript
class Persona {
  constructor(nombre, edad) {
    this.nombre = nombre;
    this.edad = edad;
  }
  saludar() {
    console.log("Hola, soy " + this.nombre);
  }
}

// Segundo ejemplo de clase en JavaScript
class Animal {
  constructor(tipo) {
    this.tipo = tipo;
  }
  sonido() {
    console.log("El animal hace un sonido");
  }
}

// Tercer ejemplo de clase en JavaScript
class Auto {
  constructor(marca) {
    this.marca = marca;
  }
  arrancar() {
    console.log("El auto " + this.marca + " ha arrancado");
  }
}

// Cuarto ejemplo de clase en JavaScript
class Libro {
  constructor(titulo) {
    this.titulo = titulo;
  }
  leer() {
    console.log("Leyendo " + this.titulo);
  }
}

// Quinto ejemplo de clase en JavaScript
class Estudiante {
  constructor(nombre, grado) {
    this.nombre = nombre;
    this.grado = grado;
  }
  estudiar() {
    console.log(this.nombre + " está estudiando");
  }
}
