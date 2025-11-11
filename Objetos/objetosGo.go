package main
import "fmt"
// Primer ejemplo de objetos en Go
type Persona struct {
	Nombre string
	Edad   int
}
func (p Persona) Saludar() {
	fmt.Println("Hola, soy", p.Nombre)
}
// Segundo ejemplo de objetos en Go
type Carro struct {
	Marca string
}
func (c Carro) Encender() {
	fmt.Println("El carro", c.Marca, "está encendido")
}
// Tercer ejemplo de objetos en Go
type Perro struct {
	Nombre string
}
func (p Perro) Ladrar() {
	fmt.Println(p.Nombre, "dice: Guau guau")
}
// Cuarto ejemplo de objetos en Go
type Libro struct {
	Titulo string
}
func (l Libro) Mostrar() {
	fmt.Println("Libro:", l.Titulo)
}
// Quinto ejemplo de objetos en Go
type Celular struct {
	Marca string
}
func (c Celular) Encender() {
	fmt.Println("Encendiendo", c.Marca)
}
// Función principal
func main() {
	p1 := Persona{"Luis", 19}
	p1.Saludar()

	c1 := Carro{"Chevrolet"}
	c1.Encender()

	perro1 := Perro{"Rocky"}
	perro1.Ladrar()

	libro1 := Libro{"It"}
	libro1.Mostrar()

	cel1 := Celular{"Xiaomi"}
	cel1.Encender()
}