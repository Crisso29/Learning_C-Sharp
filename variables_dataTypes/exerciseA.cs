/* Imagina que un cliente compra varios productos de un solo tipo, pero 
pueden ser pocos o miles, para ello quiero que hagas una calculadora que
le pida el precioUnitario del producto, la cantidad y la tasa impuesto
de su región, de acuerdo ello, se tiene que calcular:
Subtotal
Monto del impuesto
Total final
*/

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



