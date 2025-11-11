// Primero ejemplo de modificador de acceso en JS: PUBLIC
class PersonaPublica {
  constructor() {
    this.nombre = "Johan"; // Público por defecto
  }
}

const p1 = new PersonaPublica();
console.log("Public:", p1.nombre);

// Segundo ejemplo de modificador de acceso en JS: PRIVATE
class PersonaPrivada {
  #nombre = "Johan"; // Propiedad privada

  mostrarNombre() {
    console.log("Private:", this.#nombre);
  }
}
const p2 = new PersonaPrivada();
// No se puede acceder directamente
p2.mostrarNombre(); // Solo desde método interno

// Tercer ejemplo de modificador de acceso en JS: PROTECTED
// En JS no existe "protected", se usa convención con "_"
class PersonaProtegida {
  constructor() {
    this._nombre = "Johan"; // "_nombre" simula protegido
  }
}

class Estudiante extends PersonaProtegida {
  mostrar() {
    console.log("Protected:", this._nombre);
  }
}

const e1 = new Estudiante();
e1.mostrar();

// Quarto ejemplo de modificador de acceso en JS: DEFAULT (sin palabra clave)
class PersonaDefault {
  constructor() {
    this.nombre = "Johan"; // Público por defecto
  }
}

const p4 = new PersonaDefault();
console.log("Default:", p4.nombre);

// Quinto ejemplo de modificador de acceso en JS: COMBINADO
class PersonaCombinada {
  nombre = "Johan"; // público
  #edad = 18; // privado
  _ciudad = "Neiva"; // protegido (simulado)

  mostrar() {
    console.log(`Combinado: ${this.nombre}, ${this.#edad} años, vive en ${this._ciudad}`);
  }
}

const p5 = new PersonaCombinada();
p5.mostrar();
