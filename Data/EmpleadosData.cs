using Entity;
using System.Configuration;
using System.Data.SqlClient;

namespace Dal
{
    public class EmpleadosData
    {
        public void GuardarEmpleado(Empleados empleado)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBEmpleados"].ConnectionString);

                    using (conn)
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Empleado (APELLIDO, DNI, SUELDOBRUTO, SUELDONETO) VALUES (@Apellido, @DNI, @SueldoBruto, @SueldoNeto)", conn);

                        using (cmd)
                        {
                            cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                            cmd.Parameters.AddWithValue("@DNI", empleado.DNI);
                            cmd.Parameters.AddWithValue("@SueldoBruto", empleado.SueldoBruto);
                            cmd.Parameters.AddWithValue("@SueldoNeto", empleado.SueldoNeto);
                            cmd.ExecuteNonQuery();
                        }
                    }
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        public List<Empleados> MostrarEmpleados()
        {
            List<Empleados> listaEmpleados = new List<Empleados>();
            try
            {
                
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DBEmpleados"].ConnectionString);
                using (conn)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Empleado", conn);
                    using (cmd)
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        using (reader)
                        {
                            while (reader.Read())
                            {
                                Empleados empleado = new Empleados();
                                {
                                    
                                    empleado.Apellido = reader.GetString(0);
                                    empleado.DNI = reader.GetInt64(1);
                                    empleado.SueldoBruto = reader.GetDouble(2);
                                    empleado.SueldoNeto = reader.GetDouble(3);
                                }
                                listaEmpleados.Add(empleado);
                            }

                        }
                    }
                }
            }
            
            catch (Exception)
            {

                throw;
            }
            return listaEmpleados;
        }
    }
}
