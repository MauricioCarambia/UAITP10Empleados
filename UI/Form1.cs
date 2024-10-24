using BLL;
using Entity;

namespace UI
{
    public partial class Form1 : Form
    {
        private EmpleadosBusiness empleadosBusiness = new EmpleadosBusiness();

        private List<Empleados> listaEmpleados = new List<Empleados>();
        public Form1()
        {

            InitializeComponent();
        }

        private void btnBorrador_Click(object sender, EventArgs e)
        {
            try
            {
                Empleados empleados = new Empleados();
                empleados.Apellido = txtApellido.Text;
                empleados.DNI = Convert.ToInt64(txtDNI.Text);
                empleados.SueldoBruto = Convert.ToDouble(txtSueldo.Text);
                listaEmpleados.Add(empleados);
                MessageBox.Show("Empleado agregado en borrador");
                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                empleadosBusiness.GuardarEmpleados(listaEmpleados);
                listaEmpleados = new List<Empleados>();
                MessageBox.Show("Empleados confirmados");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Empleados> listaEmpleados = empleadosBusiness.MostrarEmpleados();

                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = listaEmpleados;

                Limpiar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
        private void Limpiar()
        {
                txtApellido.Text = "";
                txtDNI.Text = "";
                txtSueldo.Text = "";
        }
    }
}
