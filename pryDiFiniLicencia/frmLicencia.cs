using System.Diagnostics.Eventing.Reader;

namespace pryDiFiniLicencia
{
    public partial class frmLicencia : Form
    {
        public frmLicencia()
        {
            InitializeComponent();
        }

        int Edad;
        bool Licencia;
        int Multas;
        bool Medico; 

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Edad = Convert.ToInt32(txtEdad.Text);
            Multas = Convert.ToInt32(txtMultas.Text);
            Licencia = cmbLicencia.SelectedIndex == 0;
            Medico = cmbMedico.SelectedIndex == 0;

            if (Edad < 0)
            {
                MessageBox.Show("La edad es inválida");
                return; 
            }
            else if (Multas < 0)
            {
                MessageBox.Show("Cantidad de multas es inválida");
                return;
            }
            else if (Edad < 18)
            {
                MessageBox.Show("No puede conducir");
                return; 
            }
            else if (!Licencia)
            {
                MessageBox.Show("No puede conducir porque no tiene licencia");
            }
            else if (!Medico)
            {
                MessageBox.Show("No puede conducir: examen médico desaprobado");
            }
            else if (Multas >= 3)
            {
                MessageBox.Show("Licencia suspendida por multas");
            }
            else
            {
                MessageBox.Show("Puede conducir");
            }
        }
        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
