public class Persona
{
    // Definicion de Propiedades
    public string Nombre{get;set;}
    public string Apellido{get;set;}
    public DateTime FechaNacimiento{get;set;}
    public string Email{get;set;}
// Constructor
    public Persona()
    {

    }
    public Persona(string nom, string ape="", DateTime fn = new DateTime(),string gm="")
    {
        Nombre = nom;
        Apellido=ape;
        FechaNacimiento = fn;
        Email = gm;
    }

    // Métodos

    public int ObtnerEdad()
    {
        int Edad;
        DateTime FechaNacimientoHoy = new DateTime(DateTime.Today.Year, FechaNacimiento.Month, FechaNacimiento.Day);
        if (FechaNacimientoHoy< DateTime.Today)  Edad = DateTime.Today.Year - FechaNacimiento.Year;
            else   Edad = DateTime.Today.Year - FechaNacimiento.Year -1;
        return Edad; 
    }

    public bool PuedeVotar()
    {
        bool vota = ObtnerEdad() >=16;
        return vota;

    }
}