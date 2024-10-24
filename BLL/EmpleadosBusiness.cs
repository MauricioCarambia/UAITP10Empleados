using Dal;
using Entity;
using System.Data.SqlClient;
using System.Net;
using System.Transactions;

namespace BLL
{
    public class EmpleadosBusiness
    {
        private EmpleadosData empleadoData = new EmpleadosData();
        public void GuardaEmpleado(Empleados empleado)
        {
            try
            {
               
                using (var trx = new TransactionScope())
                {

                  
                    empleado.SueldoNeto = CalcularSueldoNeto(empleado.SueldoBruto);
                    empleadoData.GuardarEmpleado(empleado);
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    public void GuardarEmpleados(List<Empleados> empleado)
        {
            try
            {
                using (var trx = new TransactionScope())
                {

                    foreach (Empleados empleados in empleado)
                    {
                        string dni = empleados.DNI.ToString();
                        if (empleados.Apellido.Length <= 5)
                        {
                            throw new Exception($"El apellido {empleados.Apellido} debe tener mas de 5 letras");
                        }
                        if (dni.Length != 11)
                        {
                            throw new Exception($"El DNI {empleados.DNI} debe tener 11 numeros");
                        }
                        if (empleados.SueldoBruto < 100000)
                        {
                            throw new Exception("El sueldo brutos debe ser mayor a $100.000");
                        }
                        GuardaEmpleado(empleados);
                    }
                    trx.Complete();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
        public double CalcularSueldoNeto(double sueldo)
        {
            try
            {
                double descuento = sueldo * 0.17;
                double Neto = sueldo - descuento;
                return Neto;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public List<Empleados> MostrarEmpleados()
        {
            try
            {
                return empleadoData.MostrarEmpleados();
            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
    }
}
