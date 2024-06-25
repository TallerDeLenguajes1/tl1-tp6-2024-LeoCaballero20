Console.WriteLine("Ingrese un número entero mayor a 0");
string numIngresado = Console.ReadLine();
if (Int32.TryParse(numIngresado, out int num) && num>0) {
    char[] cadena = numIngresado.ToCharArray();
    Array.Reverse(cadena);
    Console.WriteLine(cadena);
} else {
    Console.WriteLine("Número ingresado inválido");
}
