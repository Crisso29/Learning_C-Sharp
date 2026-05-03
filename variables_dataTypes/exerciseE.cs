/*DevCrisso gana muy bien, donde está prestando dinero de manera legal a un socio, 
en el cual fijan el monto prestado, tasa de interés anual (%), numero de años. Para
ello crea un chiquito programa que le calcule y muestre:
(a) Monto total a devolver
(b) Total de interés generado
(c) Cuota mensual estimado (total/mes) */

using System;

decimal montoPrestado, montoTotalDevolver, totalInteresGenerado, cuotaMensual;
const decimal tasaInteresAnual=0.08m;
int numeroAñosPrestado;

Console.Write("Ingrese el capital prestado: ");
decimal.TryParse(Console.ReadLine(), out montoPrestado);
Console.Write("Ingrese para cuantos años se prestó el dinero: ");
int.TryParse(Console.ReadLine(), out numeroAñosPrestado);

montoTotalDevolver=montoPrestado* (decimal)Math.Pow((1+(double)tasaInteresAnual),numeroAñosPrestado);
totalInteresGenerado=montoTotalDevolver-montoPrestado;
cuotaMensual=montoTotalDevolver/(numeroAñosPrestado*12);

Console.WriteLine("\n=========================================");
Console.WriteLine($"Capital prestado: \t{montoPrestado:C}");
Console.WriteLine($"Tasa anual: \t\t{tasaInteresAnual:P}");
Console.WriteLine($"Plazo: \t\t\t{numeroAñosPrestado} años");
Console.WriteLine("------------------------------------------");
Console.WriteLine($"Monto total a pagar: \t{montoTotalDevolver:C}");
Console.WriteLine($"Total en interés: \t{totalInteresGenerado:C}");
Console.WriteLine($"Cuota mensual: \t\t{cuotaMensual:C}");

Console.ReadKey();
