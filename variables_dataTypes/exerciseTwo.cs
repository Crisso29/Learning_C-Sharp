/* Un programador cobra por horas en una empresa de desarrollo de
software, por el cual, su sistema de gestión de la empresa le pide 
siempre la hora de entrada, la hora de la salida, para así calcular 
las horas trabajadas al día. La empresa ya le da su tarifa por hora en
su contrato (imagina que eres de los recursos humanos y ponle una tarifa
a tu criterio). Calcula:
total de horas trbajadas al día
EL pago total del día */

using System;
using System.Data;

DateTime horaEntrada;
DateTime horaSalida;
const decimal tarifaPagoHora=20.80m;

Console.Write("\n\t BUENOS DÍAS, SEÑOR DESARROLLADOR");
Console.Write("\n Ingresa su hora de entrada \"HH:mm\": ");
horaEntrada=DateTime.Parse(Console.ReadLine());
Console.Write(" Ingresa su hora de salida \"HH:mm\": ");
horaSalida=DateTime.Parse(Console.ReadLine());

TimeSpan horasTrabajadas=horaSalida-horaEntrada;
decimal pagoTotal=(decimal)horasTrabajadas.TotalHours*tarifaPagoHora;

Console.WriteLine($"\n\t HORAS TRABAJADAS: {horasTrabajadas.TotalHours:F2} horas");
Console.WriteLine($"Pago total del día: {pagoTotal:C2}");
Console.ReadKey();