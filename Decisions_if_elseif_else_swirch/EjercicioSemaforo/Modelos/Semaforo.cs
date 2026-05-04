namespace EjercicioSemaforo.Modelos
{
    public class Semaforo
    {
        public string Color {get; set; }
        public Semaforo(string color)
        {
            Color=color.ToLower().Trim();
        }
    }
}