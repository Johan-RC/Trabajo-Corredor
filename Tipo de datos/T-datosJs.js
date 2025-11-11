// Primer ejemplo, Numérico
let edad = 18;
let salario = 1200.5;
console.log("Edad:", edad, "Salario:", salario);

// Segundo ejemplo, Texto
let nombre = "Johan";
console.log("Nombre:", nombre);

// Tercer ejemplo, Booleano
let aprobado = true;
console.log("¿Aprobado?:", aprobado);

// Cuarto ejemplo, JSON
let persona = { nombre: "Johan", edad: 18 };
let json = JSON.stringify(persona);
console.log("JSON:", json);

// Quinto ejemplo, Binario
let texto = "Hola mundo";
let buffer = new TextEncoder().encode(texto);
console.log("Datos binarios (Uint8Array):", buffer);
