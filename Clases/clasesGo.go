// Primer ejemplo de clase en Go
type Persona struct {
    Nombre string
    Edad   int
}
func (p Persona) Saludar() {
    fmt.Println("Hola, soy", p.Nombre)
}

// Segunda ejemplo de clase en Go
type Animal struct {
    Tipo string
}
func (a Animal) Sonido() {
    fmt.Println("El animal hace un sonido")
}

// Tercer ejemplo de clase en Go
type Auto struct {
    Marca string
}
func (a Auto) Arrancar() {
    fmt.Println("El auto", a.Marca, "ha arrancado")
}

// Cuarto ejemplo de clase en Go
type Libro struct {
    Titulo string
}
func (l Libro) Leer() {
    fmt.Println("Leyendo", l.Titulo)
}

// Quinto ejemplo de clase en Go
type Estudiante struct {
    Nombre string
    Grado  int
}
func (e Estudiante) Estudiar() {
    fmt.Println(e.Nombre, "está estudiando")
}
