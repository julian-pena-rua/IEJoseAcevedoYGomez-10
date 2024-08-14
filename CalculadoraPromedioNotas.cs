/******************************************************************************

Autor:          Julián A. Peña
Fecha:          14 Agosto de 2024
Descripción:    calculadora de promedio notas
Aplicando estructuras de decisión anidadas cumplir las siguientes reglas:
    - Recibe máximo 3 notas
    - Mostrar mensaje “Pierde” si promedio menor que 3
    - Mostrar mensaje “Aceptable” si promedio mayor que 3
    - Mostrar mensaje “Excelente” si promedio mayor a 4.5
    - Debe de sólo mostrar un mensaje
    Formula: 
            Promedio = (nota1 + nota2 + nota3)
                        ______________________
                                3
*******************************************************************************/
// librerias
using System;

// nombre de la clase u objeto
class PromedioNotas {
    
    /*  @Método principal: es el que permite que el código se ejecute. 
        Todas las intrucciones deben ir dentro de este bloque.
    */
  static void Main() {
    
    // Imagen ASCII, a través de caracteres como letras, símbolos y números se genera una imagen o efecto
    
    // Calculadora
    Console.WriteLine("Imagen de: Jeremy J. Olson");
    Console.WriteLine(" _____________________");
    Console.WriteLine("|  _________________  |");
    Console.WriteLine("| | JO           0. | |");
    Console.WriteLine("| |_________________| |");
    Console.WriteLine("|  ___ ___ ___   ___  |");
    Console.WriteLine("| | 7 | 8 | 9 | | + | |");
    Console.WriteLine("| |___|___|___| |___| |");
    Console.WriteLine("| | 4 | 5 | 6 | | - | |");
    Console.WriteLine("| |___|___|___| |___| |");
    Console.WriteLine("| | 1 | 2 | 3 | | x | |");
    Console.WriteLine("| |___|___|___| |___| |");
    Console.WriteLine("| | . | 0 | = | | / | |");
    Console.WriteLine("| |___|___|___| |___| |");
    Console.WriteLine("|_____________________|\n\n");
    
    // Texto con efecto en llamas
    Console.WriteLine(" (                                    ");
    Console.WriteLine(" )\\ )                    (            ");
    Console.WriteLine("(()/((          )     (  )\\ ) (       ");
    Console.WriteLine(" /(_))(   (    (     ))\\(()/( )\\  (   ");
    Console.WriteLine("(_))(()\\  )\\   )\\  '/((_)((_)|(_) )\\  ");
    Console.WriteLine("| _ \\((_)((_)_((_))(_))  _| | (_)((_) ");
    Console.WriteLine("|  _/ '_/ _ \\ '  \\() -_) _` | | / _ \\ ");
    Console.WriteLine("|_| |_| \\___/_|_|_|\\___\\__,_| |_\\___/ ");
    
    // Mensaje de bienvenida al usuario
    Console.WriteLine("__________________________________"
                   +"\n|Bienvenido a la calculadora para |" 
                   +"\n|promediar las notas actuales     |"
                   +"\n|_________________________________|\n");
                   
    // Menú principal 
    Console.WriteLine("MENU PRINCIPAL");    
    Console.WriteLine("1. Calcular promedio");
    Console.WriteLine("2. Ver créditos");
    Console.WriteLine("3. Salir");
    Console.Write("Elegir número de opción: ");
    
    // se convierte el valor string a un int (entero) 
    int opcion = Int32.Parse(Console.ReadLine());
    
    // Opción calcular promedio
    if(opcion == 1){
        Console.WriteLine("Has elegido calcular promedio...");
        Console.WriteLine("Cargando.");
        double nota1, nota2, nota3,promedio;
        Console.WriteLine("Cargando..");
        Console.WriteLine("Cargando...");
        Console.WriteLine("Escribir nota 1: ");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escribir nota 2: ");
        nota2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Escribir nota 3: ");
        nota3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Cargando..");
        Console.WriteLine("Cargando.");
        promedio = (nota1+nota2+nota3)/3;
        Console.WriteLine("Su promedio es: " + promedio);
    }
    
    // Opción Créditos
    if(opcion == 2){
        Console.WriteLine("CALCULADORA PROMEDIO DE NOTAS");    
        Console.WriteLine("Administración:  Julián Andrés Peña Rúa");
        Console.WriteLine("Proyecto: \t Julián Andrés Peña Rúa");
        Console.WriteLine("Diseño: \t Julián Andrés Peña Rúa");
        Console.WriteLine("Desarrollo: \t Julián Andrés Peña Rúa");
        Console.WriteLine("Pruebas: \t Julián Andrés Peña Rúa");
        Console.WriteLine("Gestión: \t Julián Andrés Peña Rúa");
        Console.WriteLine("Mercadeo: \t Julián Andrés Peña Rúa");
    }
    
    // Opción Salir
    if(opcion == 3){
        Console.WriteLine("Vuelve pronto...");
    }
    
    // Control para valores incorrectos
    if(opcion>3){
        Console.WriteLine("Valor incorrecto, volver a intentar...");
    }
  }
}
