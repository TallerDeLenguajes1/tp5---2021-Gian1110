using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio4();
            Console.ReadKey();
            
        }



        public static void Calculadora()
        {
            int Operacion = 0, Numero1 = 0;
            float Numero2 = 0, Resultado = 0;
            char OtraOperacion = 'y';
            while (OtraOperacion == 'y')
            {
                while (Operacion < 1 || Operacion >4)
                {
                    Console.WriteLine("Que operacion desea realizar ?\n1) Suma\n2) Resta\n3) Multiplicacion\n4) Division");
                    Operacion = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                Console.WriteLine("ingrese el primero numero:");
                Numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el segundo numero:");
                Numero2 = int.Parse(Console.ReadLine());
                Console.Write("el resultado de ");
                switch (Operacion)
                {
                    case 1:
                        Resultado = Numero1 + Numero2;
                        Console.WriteLine("la suma entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                        break;
                    case 2:
                        Resultado = Numero1 - Numero2;
                        Console.WriteLine("la resta entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                        break;
                    case 3:
                        Resultado = Numero1 * Numero2;
                        Console.WriteLine("la multiplicacion entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                        break;
                    default:
                        Resultado = Numero1 / Numero2;
                        Console.WriteLine("la division entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                        break;
                }
                
                do
                {
                    Console.WriteLine("quiere realizar otra operacion (y/n)");
                    OtraOperacion = char.Parse(Console.ReadLine());
                } while (OtraOperacion != 'n' && OtraOperacion != 'N' && OtraOperacion != 'y' && OtraOperacion != 'Y');
                if (OtraOperacion == 'y' || OtraOperacion == 'Y')
                {
                    Operacion = 0;
                }
            }
        }

        public static void CalculadoraMejorada()
        {
            int Operacion = 0;
            float Numero1 = 0;
            double Resultado = 0;
            char OtraOperacion = 'y';
            while (OtraOperacion == 'y')
            {
                while (Operacion < 1 || Operacion > 6)
                {
                    Console.WriteLine("Que operacion desea realizar ?\n1) Valor absoluto\n2) Cuadrado\n3) raiz cuadrada\n4) seno\n5) coseno\n6) parte entera");
                    Operacion = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                Console.WriteLine("ingrese el numero al que se le aplicara la operacion:");
                Numero1 = float.Parse(Console.ReadLine());
                Console.Write("el resultado de ");
                switch (Operacion)
                {
                    case 1:
                        Resultado = Math.Abs(Numero1);
                        Console.WriteLine("el valor absoluto de " + Numero1 + " es: " + Resultado);
                        break;
                    case 2:
                        Resultado = Math.Pow(Numero1, 2);
                        Console.WriteLine("el cuadrado de " + Numero1 + " es: " + Resultado);
                        break;
                    case 3:
                        Resultado = Math.Sqrt(Numero1);
                        Console.WriteLine("la raiz cuadrada de " + Numero1 + " es: " + Resultado);
                        break;
                    case 4:
                        Resultado = Math.Sin(Numero1);
                        Console.WriteLine("el seno de " + Numero1 + " es: " + Resultado);
                        break;
                    case 5:
                        Resultado = Math.Cos(Numero1);
                        Console.WriteLine("el coseno de " + Numero1 + " es: " + Resultado);
                        break;
                    default:
                        Resultado = Math.Truncate(Numero1);
                        Console.WriteLine("la parte entera de " + Numero1 + " es: " + Resultado);
                        break;
                }

                do
                {
                    Console.WriteLine("quiere realizar otra operacion (y/n)");
                    OtraOperacion = char.Parse(Console.ReadLine());
                } while (OtraOperacion != 'n' && OtraOperacion != 'N' && OtraOperacion != 'y' && OtraOperacion != 'Y');
                if (OtraOperacion == 'y' || OtraOperacion == 'Y')
                {
                    Operacion = 0;
                }
            }
        }

        public static void MaximoyMinimo()
        {
            int primerNumero, segundoNumero, aux;
            Console.WriteLine("ingrese el primero numero : ");
            primerNumero = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero : ");
            segundoNumero = int.Parse(Console.ReadLine());
            if (primerNumero<segundoNumero)
            {
                aux = primerNumero;
                primerNumero = segundoNumero;
                segundoNumero = aux;
            }
            Console.WriteLine("el numero maximo es " + primerNumero + "\n el numero minimo es " + segundoNumero);
        }

        public static void Ejercicio4()
        {   //declaracion e ingresar cadenas
            String Cadena1 = IngresarCadena();
            //String Cadena2 = IngresarCadena();
            //mostrar operaciones
            //letras
            /*Random rand = new Random();
            Console.WriteLine(Cadena1[0]);
            Console.WriteLine(Cadena1[rand.Next(Cadena1.Length)]);
            //longitud
            Console.WriteLine("el largo de la cadena es "+ Cadena1.Length);
            //concatenar
            String conca = string.Concat(Cadena1, Cadena2);
            Console.WriteLine(conca);
            //subcadena
            String[] subcadena = Cadena1.Split( );
            Console.WriteLine(subcadena[0]);

            foreach (char elemento in Cadena1)
            {
                Console.Write(elemento);
            }
            Console.WriteLine("ingrese la palabra a buscar ");
            String Cadena3 = IngresarCadena();
            if (Cadena1.Contains(Cadena3))
            {
                Console.WriteLine("la cadena esta");
            }
            else
            {
                Console.WriteLine("la cadena no esta");
            }
            Console.WriteLine("la cadena en mayuscula es: " + Cadena1.ToUpper());
            Console.WriteLine("la cadena en mayuscula es: " + Cadena1.ToLower());
            if (Cadena1.Equals(Cadena2))
            {
                Console.WriteLine("las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("las cadenas son diferentes");
            }*/

            int Operacion = 0;
            float Numero1 = 0, Numero2 = 0;
            double Resultado = 0;
            string[] separa= Cadena1.Split("+");
            Numero1 = float.Parse(separa[0]);
            Numero2 = float.Parse(separa[1]);
            while (Operacion < 1 || Operacion > 4)
            {
                Console.WriteLine("Que operacion desea realizar ?\n1) Suma\n2) Resta\n3) Multiplicacion\n4) Division");
                Operacion = int.Parse(Console.ReadLine());
                Console.Clear();
            }
       
            Console.Write("el resultado de ");
            switch (Operacion)
            {
                case 1:
                    Resultado = Numero1 + Numero2;
                    Console.WriteLine("la suma entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                    break;
                case 2:
                    Resultado = Numero1 - Numero2;
                    Console.WriteLine("la resta entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                    break;
                case 3:
                    Resultado = Numero1 * Numero2;
                    Console.WriteLine("la multiplicacion entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                    break;
                default:
                    Resultado = Numero1 / Numero2;
                    Console.WriteLine("la division entre " + Numero1 + " y " + Numero2 + " es: " + Resultado);
                    break;
            }

        }

        public static string IngresarCadena()
        {
            Console.WriteLine("ingrese una cadena: ");
            return Console.ReadLine();
        }
    }
}
