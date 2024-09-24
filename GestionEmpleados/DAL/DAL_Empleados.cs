using app.EL;

namespace app.DAL
{
    public class DAL_Empleado
    {
        private List<Empleado> Listado = new();

        public int Insert(Empleado Entidad)
        {
            Entidad.IdEmpleado = Listado.Count() + 1;
            Listado.Add(Entidad);
            return Entidad.IdEmpleado;

        }

        public bool Update(Empleado Entidad)
        {
            var RegistroBD = Listado.Find(a => a.IdEmpleado == Entidad.IdEmpleado);
            if (RegistroBD != null)
            {
                RegistroBD.NombreEmpleado = Entidad.NombreEmpleado;
                RegistroBD.PuestoEmpleado = Entidad.PuestoEmpleado;
                RegistroBD.SalarioEmpleado = Entidad.SalarioEmpleado;
                return true;
            }
            return false;
        }


        public bool Delete(int IdEmpleado)
        {
            var RegistroBD = Listado.Find(a => a.IdEmpleado == IdEmpleado);
            if (RegistroBD != null)
            {
                Listado.Remove(RegistroBD);
                return true;
            }
            return false;

        }

        public List<Empleado> Lista()
        {
            return Listado;
        }
        
    }
}



