package main

import (
	"encoding/base64"
	"encoding/json"
	"fmt"
)

type Persona struct {
	Nombre string
	Edad   int
}

func main() {
	// Primer ejemplo, Numérico
	var edad int = 22
	var salario float64 = 1800.75
	fmt.Println("Edad:", edad, "Salario:", salario)

	// Segundo ejemplo, Texto
	nombre := "Johan"
	fmt.Println("Nombre:", nombre)

	// Tercer ejemplo, Booleano
	aprobado := true
	fmt.Println("¿Aprobado?:", aprobado)

	// Cuarto ejemplo, JSON
	persona := Persona{"Johan", 22}
	jsonData, _ := json.Marshal(persona)
	fmt.Println("JSON:", string(jsonData))

	// Quinto ejemplo, Binario
	texto := []byte("Hola mundo")
	binario := base64.StdEncoding.EncodeToString(texto)
	fmt.Println("Datos binarios (Base64):", binario)
}