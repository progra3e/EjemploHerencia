using System.ComponentModel.DataAnnotations;

namespace EjemploHerencia
{
    public class Persona
    {        

     //   [Range(18, 80, ErrorMessage = "El número debe ser entre 18 y 80")]
    //    public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es Obligatorio")]
        public string Nombre { get; set; }
        
        [Required(ErrorMessage = "El apellido es Obligatorio")]
        public string Apellido { get; set; }
    
        public string Direccion {  get; set; }
        public DateTime FechaNacimiento { get; set; }

                
        //Constructor: Se ejecuta cada vez que se crea
        //un objeto de esta clase
        public Persona()
        {
            Nombre = "";
            Apellido = "";
            Direccion = "";
        }

        public int Edad()
        {

            TimeSpan edad = FechaNacimiento - DateTime.Now;

            return Convert.ToInt16(edad.TotalDays / 365);
        }
    }
}
