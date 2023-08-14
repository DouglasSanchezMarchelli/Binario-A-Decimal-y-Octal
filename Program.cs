using System;

namespace ConversionBinario
{
    class Program
    {
 static void Main(string[] args)
 {
 Console.WriteLine("Conversión de Número Binario a Decimal, Hexadecimal y Octal");
 Console.WriteLine("-------------------------------------------------------------");

 Console.Write("Ingrese un número binario (solo 0 y 1): ");
 string numeroBinario = Console.ReadLine();

 if (EsNumeroBinario(numeroBinario))
 {
 int numeroDecimal = ConvertirBinarioADecimal(numeroBinario);
 string numeroHexadecimal = ConvertirDecimalAHexadecimal(numeroDecimal);
 string numeroOctal = ConvertirDecimalAOctal(numeroDecimal);

 Console.WriteLine("Número Decimal: " +numeroDecimal);
 Console.WriteLine("Número Hexadecimal: " +numeroHexadecimal);
 Console.WriteLine("Número Octal:" +numeroOctal);
  }
  else
{
 Console.WriteLine("El número ingresado no es binario.");
}
 } static bool EsNumeroBinario(string numero)
 {
 foreach (char digito in numero)
  {
 if (digito != '0' && digito != '1')
   {
return false;
 }
 }
 return true;
 }

 static int ConvertirBinarioADecimal(string binario)
 {
  int decimalResultado = 0;
  int longitud = binario.Length;
  for (int i = 0; i < longitud; i++)
  {
   int digito = binario[i] - '0';
  decimalResultado += digito * (int)Math.Pow(2, longitud - i - 1);
  }
  return decimalResultado;
   }

 static string ConvertirDecimalAHexadecimal(int decimalNumero)
 {
  return decimalNumero.ToString("X");
  }

 static string ConvertirDecimalAOctal(int decimalNumero)
  {
  return Convert.ToString(decimalNumero, 8);
    }
 }
}