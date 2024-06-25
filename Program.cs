
Console.WriteLine("Ingrese un número entero mayor a 0");
string numIngresado = Console.ReadLine();
if (Int32.TryParse(numIngresado, out int num) && num>0) {
    char[] cadena = numIngresado.ToCharArray();
    Array.Reverse(cadena);
    Console.WriteLine("Número invertido:");
    Console.WriteLine(cadena);
} else {
    Console.WriteLine("Número ingresado inválido");
}

Console.WriteLine("Bienvenido a la calculadora 2.0");
Console.WriteLine("Ingrese un número entero mayor a 0");
string numCalc = Console.ReadLine();
if (float.TryParse(numCalc, out float numC)) {
    Console.WriteLine("El valor absoluto es: " + Math.Abs(numC));
    Console.WriteLine("El cuadrado es: " + Math.Pow(numC, 2));
    Console.WriteLine("La raíz cuadrada es es: " + Math.Sqrt(numC));
    Console.WriteLine("El seno es: " + Math.Sin(numC));
    Console.WriteLine("El coseno es: " + Math.Cos(numC));
    Console.WriteLine("La parte entera es: " + Math.Truncate(numC));
} else {
    Console.WriteLine("Número ingresado inválido");
}
Console.WriteLine("Ahora ingrese otro dos números");
Console.WriteLine("Ingrese el primero:");
string ingresado1 = Console.ReadLine();
float.TryParse(ingresado1, out float num1);
Console.WriteLine("Ingrese el segundo");
string ingresado2 = Console.ReadLine();
float.TryParse(ingresado2, out float num2);
if (num1>num2) {
    Console.WriteLine("El mayor es " + num1 + " y el menor es " + num2);
} else if (num2>num1) {
    Console.WriteLine("El mayor es " + num2 + " y el menor es " + num1);   
} else {
    Console.WriteLine("Los números son iguales");   
}
