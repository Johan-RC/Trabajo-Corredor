// Primer ejemplo de objetos en JavaScript
let persona = { nombre: "Ana", edad: 18, saludar() { console.log("Hola, soy " + this.nombre); } };
persona.saludar();

// Segundo ejemplo de objetos en JavaScript
let carro = { marca: "Mazda", arrancar() { console.log("El carro está encendido"); } };
carro.arrancar();

// Tercer ejemplo de objetos en JavaScript
let perro = { nombre: "Bobby", ladrar() { console.log("Guau guau"); } };
perro.ladrar();

// Cuarto ejemplo de objetos en JavaScript
let libro = { titulo: "Don Quijote", mostrar() { console.log("Libro: " + this.titulo); } };
libro.mostrar();

// Quinto ejemplo de objetos en JavaScript
let celular = { marca: "iPhone", encender() { console.log("Encendiendo " + this.marca); } };
celular.encender();
