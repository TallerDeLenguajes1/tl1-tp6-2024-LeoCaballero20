
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

bool seguir = true;

Console.WriteLine("Bienvenido a la calculadora");
do {
    Console.WriteLine("Inserte el número de la operación deseada");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    string opcion = Console.ReadLine();
    Int32.TryParse(opcion, out int n);
    switch (n) {
        case 1: Console.WriteLine("Ingrese el primer sumando");
                string sum1 = Console.ReadLine();
                Int32.TryParse(sum1, out int x1);
                Console.WriteLine("Ingrese el segundo sumando");
                string sum2 = Console.ReadLine();
                Int32.TryParse(sum2, out int y1);
                Console.WriteLine("Resultado: " + (x1+y1));
        break;
        case 2: Console.WriteLine("Ingrese el minuendo");
                string min = Console.ReadLine();
                Int32.TryParse(min, out int x2);
                Console.WriteLine("Ingrese el sustraendo");
                string sus = Console.ReadLine();
                Int32.TryParse(sus, out int y2);
                Console.WriteLine("Resultado: " + (x2-y2));
        break;
        case 3: Console.WriteLine("Ingrese el primer factor");
                string fac1 = Console.ReadLine();
                Int32.TryParse(fac1, out int x3);
                Console.WriteLine("Ingrese el segundo factor");
                string fac2 = Console.ReadLine();
                Int32.TryParse(fac2, out int y3);
                Console.WriteLine("Resultado: " + (x3*y3));
        break;
        case 4: Console.WriteLine("Ingrese el dividendo");
                string div1 = Console.ReadLine();
                Int32.TryParse(div1, out int x4);
                Console.WriteLine("Ingrese el divisor");
                string div2 = Console.ReadLine();
                Int32.TryParse(div2, out int y4);
                if (y4==0) {
                    Console.WriteLine("No se puede dividir por 0");
                } else {
                    Console.WriteLine("Resultado: " + (x4/y4));
                }
        break;
        default: Console.WriteLine("Ingrese una opción valida");
        break;
    }
    Console.WriteLine("¿Desea realizar otra operación? 1.SI 2.NO");
    string elec = Console.ReadLine();
    Int32.TryParse(elec, out int e);
    if (e == 2) {
        seguir = false;
        Console.WriteLine("¡Hasta la próxima!");
    }
} while (seguir);


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
