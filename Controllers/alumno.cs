namespace WebApplication1.Controllers
{
    public class Alumno
    {
        //creando propiedades
        string nombre;
        string apellido;
        string dni;
        DateTime fechanacimiento;

        public Alumno()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            dni = string.Empty;
            fechanacimiento = DateTime.Now;
        }
        //constructor con parametros
        public Alumno(string pnombre, string papellido, string pdni)
        {
            nombre = pnombre;
            apellido = papellido;
            dni = pdni;
        }

        public Alumno(string pnombre, string papellido, string pdni, DateTime pfechanaciemineto)
        {
            nombre = pnombre;
            apellido = papellido;
            dni = pdni;
            fechanacimiento = pfechanaciemineto;
        }
        public string DevolverNombreCompleto()
        {
            return nombre + " " + apellido;
        }

        public string DevolverDocumento()
        {
            return dni;
        }

        public int DevolverEdad()
        {
            return DateTime.Now.Year - fechanacimiento.Year;
        }
    }
}
