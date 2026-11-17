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

        private void btnCotizar_Click(object sender, EventArgs e)
        {
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
        }

        private void btnPorCombustible_Click(object sender, EventArgs e)
        {
        }

        private void lstDespachos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
