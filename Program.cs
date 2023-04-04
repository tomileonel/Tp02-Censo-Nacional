
bool salir = false;
Dictionary<int, Persona> dicpersonas = new Dictionary<int, Persona>();

do{
    leerMenu();
    int intMenu = IngresarInt("");

    switch(intMenu)
    {
        case 1:
        {
            IngresarPersona();
            break;
        }
        case 2:
        {
            break;
        }
        case 3:
        {
            break;
        }
        case 4:
        {
            break;
        }
        case 5:
        {
            Console.WriteLine("Hasta luego");
            salir = true;
            break;
        }
        default:
        {
            Console.WriteLine("Error");
            break;
        }
    }
} while(!salir);

void leerMenu()
{
    Console.WriteLine("1.Cargar Nueva Persona");
    Console.WriteLine("2.Obtener Estadísticas del Censo");
    Console.WriteLine("3.Buscar Persona");
    Console.WriteLine("4.Modificar Mail de una Persona.");
    Console.WriteLine("5.Salir");
}

string IngresarString(string txt)
{
    Console.WriteLine(txt);
    string str = Console.ReadLine();
    return str;
}

int IngresarInt(string txt)
{
    Console.WriteLine(txt);
    int num = -1;
    do
    {
        bool valido = int.TryParse(Console.ReadLine(),out num);
    }while(num <= -1);
    return num;
}

DateTime IngresarFecha(string msj)
{
    DateTime fechaDate;
    string fechaCadena = IngresarString(msj);
    while (!DateTime.TryParse(fechaCadena, out fechaDate))
    {
        fechaCadena = IngresarString("ERROR! " + msj);
    }
    return fechaDate;
}
    
void IngresarPersona()
{
    bool valido;
    int dni=0;
    do
    {
       dni = IngresarInt("Ingrese su dni");
       valido = dicpersonas.ContainsKey(dni);
    }while(valido);
    string nom;
    string ape;
    DateTime fn; 
    string gm;

    nom = IngresarString("Ingrese Nombre ");
    ape = IngresarString("Apellido ");
    fn =IngresarFecha("Ingrese Fecha de Nacimiento (aaaa/mm/dd) ");
    gm = IngresarString("Ingrese Gmail");
    Persona nuevaPersona =  new Persona(nom,ape,fn,gm);
    dicpersonas.Add(dni,nuevaPersona);
}

void ObtenerEstadisticas()
{
    foreach(int dni in dicpersonas.Keys)
    {

    }
    Console.WriteLine("Cantidad de personas:");
    Console.WriteLine("Cantidad de personas habilitadas para votar");
    Console.WriteLine("Promedio de edad:");
}