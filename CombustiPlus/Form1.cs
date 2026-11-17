using System;
using System.Windows.Forms;

namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        // Reglas del negocio (ver enunciado)
        private const decimal GalonesParaDescuento = 20m;   // regla 3
        private const decimal PorcentajeDescuento = 0.02m;  // 2 %
        private const decimal PorcentajeTarjeta = 0.03m;    // regla 4: 3 %

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

        // R4: precio por galón de cada combustible, con una expresión switch.
        private decimal PrecioPorGalon(string combustible)
        {
            return combustible switch
            {
                "Premium" => 290.00m,
                "Regular" => 272.00m,
                "Gasoil" => 225.00m,
                _ => 0m
            };
        }

        // R4: calcula el total con las reglas 3, 4 y 5
        // y lo muestra paso a paso en lstDetalle.
        private decimal CalcularTotal(string combustible, decimal galones, string pago)
        {
            lstDetalle.Items.Clear();

            decimal precio = PrecioPorGalon(combustible);
            decimal subtotal = galones * precio;
            lstDetalle.Items.Add($"{galones:0.0} gal × RD$ {precio:N2} = RD$ {subtotal:N2}");

            decimal total = subtotal;

            // Regla 3: 20 galones o más tienen 2 % de descuento.
            // Regla 5: primero se aplica el descuento...
            if (galones >= GalonesParaDescuento)
            {
                total = total - (total * PorcentajeDescuento);
                lstDetalle.Items.Add($"Descuento 20+ galones -2 %: RD$ {total:N2}");
            }
            else
            {
                lstDetalle.Items.Add("Sin descuento (menos de 20 gal)");
            }

            // Regla 4: con tarjeta se cobra 3 % más; en efectivo no cambia.
            // Regla 5: ...y después el recargo de la tarjeta.
            if (pago == "Tarjeta")
            {
                total = total + (total * PorcentajeTarjeta);
                lstDetalle.Items.Add($"Tarjeta +3 %: RD$ {total:N2}");
            }
            else
            {
                lstDetalle.Items.Add("Efectivo: sin recargo");
            }

            // Se redondea a 2 decimales (centavos) para que el total cuadre.
            total = Math.Round(total, 2, MidpointRounding.AwayFromZero);
            lstDetalle.Items.Add($"TOTAL: RD$ {total:N2}");

            return total;
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos())
            {
                return;
            }

            CalcularTotal(cmbCombustible.Text, nudGalones.Value, cmbPago.Text);
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
