using System;
using EjercicioSemaforo.Modelos;
using EjercicioSemaforo.Servicios;
using EjercicioSemaforo.Reportes;

Console.Write("Ingresa el color de semáforo:    ");
String color = Console.ReadLine();

var semaforo=new Semaforo(color);
var evaluador=new EvaluadorSemaforo();
var reporte=new ReporteSemaforo(evaluador);

reporte.Mostrar(semaforo);
