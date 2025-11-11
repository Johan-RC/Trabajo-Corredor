package main

import "fmt"

// Primero ejemplo de modificador de acceso en Go: PUBLIC
type PersonaPublica struct {
	Nombre string // Público (Mayúscula)
}

func ejemploPublic() {
	p := PersonaPublica{"Johan"}
	fmt.Println("Public:", p.Nombre)
}

// Segundo ejemplo de modificador de acceso en Go: PRIVATE
type personaPrivada struct { // minúscula = privada
	nombre string
}

func ejemploPrivate() {
	p := personaPrivada{"Johan"}
	fmt.Println("Private:", p.nombre)
}

// Tercer ejemplo de modificador de acceso en Go: PROTECTED (simulado porque Go no tiene protected)
type personaProtegida struct {
	nombre string
}

type estudiante struct {
	personaProtegida
}

func (e estudiante) mostrar() {
	fmt.Println("Protected (simulado):", e.nombre)
}

func ejemploProtected() {
	e := estudiante{personaProtegida{"Johan"}}
	e.mostrar()
}

/* Cuarto ejemplo de modificador de acceso en Go: DEFAULT (sin palabra clave) 
funciona igual que private porque Go no tiene default pero es el comportamiento por defecto
*/
// En Go, lo "privado" es el default si empieza con minúscula
type personaDefault struct {
	nombre string
}

func ejemploDefault() {
	p := personaDefault{"Johan"}
	fmt.Println("Default:", p.nombre)
}

// Quinto ejemplo de modificador de acceso en Go: COMBINADO
type PersonaCombinada struct {
	Nombre string  // Público
	edad   int     // Privado
	ciudad string  // Privado
}

func (p PersonaCombinada) Mostrar() {
	fmt.Printf("Combinado: %s, %d años, vive en %s\n", p.Nombre, p.edad, p.ciudad)
}

func ejemploCombinado() {
	p := PersonaCombinada{"Johan", 18, "Neiva"}
	p.Mostrar()
}

// Función principal
func main() {
	ejemploPublic()
	ejemploPrivate()
	ejemploProtected()
	ejemploDefault()
	ejemploCombinado()
}
