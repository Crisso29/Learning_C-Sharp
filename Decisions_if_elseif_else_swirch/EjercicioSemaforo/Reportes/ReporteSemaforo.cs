using System;
using EjercicioSemaforo.Servicios;
using EjercicioSemaforo.Modelos;

namespace EjercicioSemaforo.Reportes
{
    public class ReporteSemaforo
    {
        private readonly EvaluadorSemaforo _evaluador;

        public ReporteSemaforo(EvaluadorSemaforo evaluador)
        {
            _evaluador= evaluador;
        }
        
        public void Mostrar (Semaforo semaforo)
        {
            string indicacion = _evaluador.ObtenerIndicacion(semaforo);
            Console.WriteLine($"Color  : {semaforo.Color}");
            Console.WriteLine($"Acción : {indicacion}");
        }
    }
}