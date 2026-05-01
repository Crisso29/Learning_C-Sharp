/* Declara una variable precioUnitario (decimal), 
una cantidad (int) y una tasaImpuesto (double, ej: 0.18 para 18%). 
Calcula e imprime:
Subtotal
Monto del impuesto
Total final*/

using System;
decimal precioUnitario;
int cantidad;
double tasaImpuesto;

Console.Write("Ingresa el precio unitario del producto: ");
precioUnitario=decimal.Parse(Console.ReadLine());
Console.Write("Ingresa la cantidad de productos: ");
cantidad=int.Parse(Console.ReadLine());
Console.Write("Ingresa la tasa de impuesto de tu región: ");
tasaImpuesto=double.Parse(Console.ReadLine());


decimal subTotal= precioUnitario*(decimal)cantidad;
decimal montoImpuesto=subTotal*(decimal)tasaImpuesto;
decimal totalFinal=subTotal+montoImpuesto;

Console.WriteLine("\nSubtotal: " + subTotal);
Console.WriteLine($"Monto del impuesto: {montoImpuesto}");
Console.WriteLine("Total final: " + totalFinal);
Console.Read();



