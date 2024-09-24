using app.DAL;
using app.EL;

namespace app.UI;

    public class UI_Empleado
{

    public void Ejecutar()
    {
        int Menu = 0;
        DAL_Empleado Datos = new();

        do
        {
            Console.Clear();
            Console.WriteLine("Gestion de Empleados");
            Console.WriteLine("Elija la opcion Correspondiente");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Show");
            Console.WriteLine("5. Go out");

            if (!int.TryParse(Console.ReadLine(), out Menu))
            {
                Console.WriteLine("Ingrese un valor valido");
                continue;
            }

            switch (Menu)
            {
                case 1:
                    Console.Clear();
                    Empleado ObjetoInsert = new();
                    Console.WriteLine("Ingrese el nombre del empleado: ");
                    ObjetoInsert.NombreEmpleado = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Ingrese el puesto del empleado: ");
                    ObjetoInsert.PuestoEmpleado = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Ingrese el salario del empleado: ");
                    decimal salario = 0;
                    decimal.TryParse(Console.ReadLine(), out salario);
                    ObjetoInsert.SalarioEmpleado = (int)salario;

                    if (Datos.Insert(ObjetoInsert) > 0)
                        Console.WriteLine("Empleado registrado con exito");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Empleado ObjetoUpdate = new();

                    Console.WriteLine("Ingrese el ID del empleado a modificar: ");
                    int IdModificar = 0;
                    int.TryParse(Console.ReadLine(), out IdModificar);
                    ObjetoUpdate.IdEmpleado = IdModificar;

                    Console.WriteLine("Ingrese el nombre del empleado: ");
                    ObjetoUpdate.NombreEmpleado = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Ingrese el puesto del empleado: ");
                    ObjetoUpdate.PuestoEmpleado = Console.ReadLine() ?? string.Empty;

                    Console.WriteLine("Ingrese el salario del empleado: ");
                    decimal nuevoSalario = 0;
                    decimal.TryParse(Console.ReadLine(), out nuevoSalario);
                    ObjetoUpdate.SalarioEmpleado = (int)nuevoSalario;

                    if (!Datos.Update(ObjetoUpdate))
                    {
                        Console.WriteLine("Error al actualizar");
                        Console.ReadKey();
                        continue;
                    }
                    Console.WriteLine("Registro actualizado con exito");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Ingrese el ID del registro a eliminar");
                    int IdEliminar = 0;
                    int.TryParse(Console.ReadLine(), out IdEliminar);

                    if (Datos.Delete(IdEliminar))
                        Console.WriteLine("Registro eliminado con exito");
                    Console.ReadKey();
                    break;

                case 4:
                    foreach (var item in Datos.Lista())
                    {
                        Console.WriteLine($"ID:{item.IdEmpleado}, Nombre: {item.NombreEmpleado}, Puesto: {item.PuestoEmpleado}, Salario: {item.SalarioEmpleado}");
                    }

                    Console.ReadKey();
                    break;


            }



        } while (Menu != 5);
    }

}

