using System;
using System.Windows.Forms;

namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // R1: llenar los ComboBox
            cmbCombustible.Items.Add("Premium");
            cmbCombustible.Items.Add("Regular");
            cmbCombustible.Items.Add("Gasoil");
            cmbCombustible.SelectedIndex = 0;

            cmbPago.Items.Add("Efectivo");
            cmbPago.Items.Add("Tarjeta");
            cmbPago.SelectedIndex = 0;
        }

        // R3: revisa los datos antes de cotizar o despachar.
        // Si algo está mal, avisa con un MessageBox y devuelve false para no seguir.
        private bool DatosValidos()
        {
            string placa = txtPlaca.Text.Trim();

            if (placa.Length != 7)
            {
                MessageBox.Show("La placa debe tener 7 caracteres.\nEjemplo: A123456",
                    "Placa inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlaca.Focus();
                return false;
            }

            if (nudGalones.Value <= 0)
            {
                MessageBox.Show("Los galones deben ser más de 0.",
                    "Galones inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudGalones.Focus();
                return false;
            }

            return true;
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos())
            {
                return;
            }
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos())
            {
                return;
            }
        }

        private void btnPorCombustible_Click(object sender, EventArgs e)
        {
        }

        private void lstDespachos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
