using EjercicioSemaforo.Modelos;
namespace EjercicioSemaforo.Servicios
{
    public class EvaluadorSemaforo
    {
        public string ObtenerIndicacion(Semaforo semaforo)
        {
            if (semaforo.Color=="rojo")
            {
                return "Detente";
            }
            else if (semaforo.Color=="amarillo")
            {
                return "Precaución";
            }
            else if (semaforo.Color=="verde")
            {
                return "Avanza";
            }
            else
            {
                return "Color no reconocido";
            }
        }
    }
}