namespace elproyecto.models;

public class Employee
{
    public Guid ID { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? NumeroDeIdentificacion { get; set; }
    public byte Edad { get; set; }
    public string? Posicion { get; set; }
    public double Salario { get; set; }


    private double CalcularBonificacion()
    {
        return Salario * 0.10;
    }

    public void MostrarInformacion()
    {
        double labonififacion = CalcularBonificacion();
        double todosumado = Salario + labonififacion;


        Console.WriteLine($"Nombre completo: '{Nombre} {Apellido}'");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Posición: {Posicion}");
        Console.WriteLine($"Salario: {Salario}");
        Console.WriteLine($"Salario + bonificación ({labonififacion}): {todosumado}");

    }

    public Employee(string nombre, string apellido, string numeroDeIdentificacion, byte edad, string posicion, double salario)
    {
        ID = Guid.NewGuid();
        Nombre = nombre;
        Apellido = apellido;
        NumeroDeIdentificacion = numeroDeIdentificacion;
        Edad = edad;
        Posicion = posicion;
        Salario = salario;
    }
}




