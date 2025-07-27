namespace PaginaCongreso.Models
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Password { get; set; }

    }
    public class Ticket
    {
        public string nom_Ticket { get; set; }
    }
    public class Persona
    {
        public string Carne { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
    }
}
