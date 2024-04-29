namespace EjemploHerencia
{
    public class Alumno : Persona
    {
        public string NoCarne { get; set; }
        public List<int> Notas { get; set; }

        public Alumno()
        {
            Notas = new List<int>();
            NoCarne = string.Empty;
        }


    }
}
