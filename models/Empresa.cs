namespace elproyecto.models;

public class Empresa
{
    public Guid IdEmpresa { get; set; }
    public string? NombreEmpresa { get; set; }
    public string? Direccion { get; set; }
    public List<Employee>? ListaEmpleados { get; set; }

    public Empresa(Guid idEmpresa, string nombreEmpresa, string direccion)
    {
        IdEmpresa = idEmpresa;
        NombreEmpresa = nombreEmpresa;
        Direccion = direccion;
        ListaEmpleados = new List<Employee>();

    }


    public void AgregarEmpleado()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine()!;

        Console.Write("Apellido: ");
        string apellido = Console.ReadLine()!;

        Console.Write("Número de identificación: ");
        string numero = Console.ReadLine()!;

        Console.Write("Edad: ");
        byte edad = byte.Parse(Console.ReadLine()!);

        Console.Write("Posición: ");
        string posicion = Console.ReadLine()!;

        Console.Write("Salario: ");
        double salario = double.Parse(Console.ReadLine()!);

        Employee nuevoEmpleado = new Employee(nombre, apellido, numero, edad, posicion, salario);

        ListaEmpleados!.Add(nuevoEmpleado);

        Console.WriteLine("\nEmpleado agregado correctamente");
    }

    public void EliminarEmpleado()
    {
        Console.Write("Dame el nombre del empleado que quieres eliminar: ");
        String EmpleadoEliminar = Console.ReadLine() ?? "";
    }

}


