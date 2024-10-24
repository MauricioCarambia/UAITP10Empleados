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
                        SqlCommand cmd = new SqlCommand("INSERT INTO Empleado (APELLIDO, DNI, SUELDOBRUTO) VALUES (@Apellido, @DNI, @SueldoBruto)", conn);

                        using (cmd)
                        {
                            cmd.Parameters.AddWithValue("@Apellido", empleado.Apellido);
                            cmd.Parameters.AddWithValue("@DNI", empleado.DNI);
                            cmd.Parameters.AddWithValue("@SueldoBruto", empleado.Sueldo);
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
                                    
                                    empleado.Apellido = reader.GetString(1);
                                    empleado.DNI = reader.GetInt64(2);
                                    empleado.Sueldo = reader.GetDouble(3);
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
