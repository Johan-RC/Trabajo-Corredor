public class TiposDeDatos {
    public static void main(String[] args) {
        // Primer ejemplo, Numérico
        int edad = 25;
        double salario = 2500.75;
        System.out.println("Edad: " + edad + ", Salario: " + salario);

        // Segundo ejemplo, Texto
        String nombre = "Johan";
        System.out.println("Nombre: " + nombre);

        // Tercer ejemplo, Booleano
        boolean aprobado = true;
        System.out.println("¿Aprobado?: " + aprobado);

        // Cuarto ejemplo, JSON (simulado como texto)
        String json = "{ \"nombre\": \"Johan\", \"edad\": 25 }";
        System.out.println("JSON: " + json);

        // Quinto ejemplo, Binario
        byte[] datos = "Hola mundo".getBytes();
        String binario = java.util.Base64.getEncoder().encodeToString(datos);
        System.out.println("Datos binarios (Base64): " + binario);
    }
}
