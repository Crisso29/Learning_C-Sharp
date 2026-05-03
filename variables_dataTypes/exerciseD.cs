/* Crisso, un Ingeniero de Sistemas, recibe su primer salario y su boleto de pago.
En el cual, nota que hay descuentos de AFP, seguros médicos y también hay bono por 
horas extras. Por el cual, se toma el reto de hacer una programa que haga los mismo. 
Pero se pone impone estas reglas: 
(a)El bono por horas extra se suma antes de calcular descuentos
(b) Los descuentos se aplican sobre salarioBruto + bonoHorasExtra */

using System;
decimal salarioBruto, bonoHorasExtra, salarioNeto;
int horaExtra;
const decimal descuentoAFP=0.10m, descuentoSeguroMédico=0.030m, valorHoraExtra= 20.00m;

Console.Write("Estimado usuario, ingrese su nombre: ");
string nombre= Console.ReadLine();
Console.Write("Ahora ingrese su salario bruto:");
decimal.TryParse(Console.ReadLine(), out salarioBruto);
Console.WriteLine("Ingrese las horas extra que hiciste este mes:");
int.TryParse(Console.ReadLine(), out horaExtra);

bonoHorasExtra=(decimal)horaExtra*valorHoraExtra;
salarioNeto=(salarioBruto+bonoHorasExtra)-(salarioBruto+bonoHorasExtra)*descuentoAFP-(salarioBruto+bonoHorasExtra)*descuentoSeguroMédico;

Console.WriteLine($"\t==========BOLETO DE PAGO-[{nombre}]=========");
Console.WriteLine($"Salario Bruto: \t\t\t{salarioBruto:C}");
Console.WriteLine($"Bono por Horas Extra: \t\t{bonoHorasExtra:C}");
Console.WriteLine("\t\t\t\t-----------------");
Console.WriteLine($"Base imponible: \t\t{salarioBruto+bonoHorasExtra:C}");
Console.WriteLine($"Descuento AFP: \t\t\t{(salarioBruto+bonoHorasExtra)*descuentoAFP:C}");
Console.WriteLine($"Descuento Seguro Médico: \t{(salarioBruto+bonoHorasExtra)*descuentoSeguroMédico:C}");
Console.WriteLine("\t\t\t\t-----------------");
Console.WriteLine($"Salario Neto: \t\t\t{salarioNeto:C}");

Console.ReadKey();