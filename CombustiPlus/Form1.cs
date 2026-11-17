using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CombustiPlus
{
    public partial class Form1 : Form
    {
        // Reglas del negocio (ver enunciado)
        private const decimal GalonesParaDescuento = 20m;   // regla 3
        private const decimal PorcentajeDescuento = 0.02m;  // 2 %
        private const decimal PorcentajeTarjeta = 0.03m;    // regla 4: 3 %

        // R5: aquí se guardan todos los despachos del día.
        private List<Despacho> despachos = new List<Despacho>();

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

            MostrarResumen();
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

        // R5: guarda el despacho en la lista y actualiza la pantalla.
        private void btnDespachar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos())
            {
                return;
            }

            Despacho despacho = new Despacho();
            despacho.Numero = despachos.Count + 1;
            despacho.Placa = txtPlaca.Text.Trim().ToUpper();
            despacho.Combustible = cmbCombustible.Text;
            despacho.Galones = nudGalones.Value;
            despacho.Pago = cmbPago.Text;
            despacho.Total = CalcularTotal(despacho.Combustible, despacho.Galones, despacho.Pago);

            despachos.Add(despacho);
            lstDespachos.Items.Add(despacho);   // el ListBox usa el ToString() de Despacho

            MostrarResumen();
        }

        // R5: recorre la lista con un foreach para sacar el resumen del día.
        private void MostrarResumen()
        {
            decimal totalVendido = 0;
            decimal totalGalones = 0;
            Despacho mayor = null;

            foreach (Despacho d in despachos)
            {
                totalVendido += d.Total;
                totalGalones += d.Galones;

                if (mayor == null || d.Total > mayor.Total)
                {
                    mayor = d;
                }
            }

            if (mayor == null)
            {
                lblResumen.Text = "0 despachos · Vendido RD$ 0.00 · Galones 0.0";
                return;
            }

            string palabra = despachos.Count == 1 ? "despacho" : "despachos";
            lblResumen.Text = $"{despachos.Count} {palabra} · Vendido RD$ {totalVendido:N2} · " +
                              $"Galones {totalGalones:0.0} · " +
                              $"Mayor: #{mayor.Numero:00} {mayor.Placa} (RD$ {mayor.Total:N2})";
        }

        // R6: suma los galones de cada combustible con un Dictionary.
        // La clave es el nombre del combustible y el valor son los galones acumulados.
        private void btnPorCombustible_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> galonesPorCombustible = new Dictionary<string, decimal>();

            foreach (Despacho d in despachos)
            {
                if (galonesPorCombustible.ContainsKey(d.Combustible))
                {
                    galonesPorCombustible[d.Combustible] += d.Galones;
                }
                else
                {
                    galonesPorCombustible[d.Combustible] = d.Galones;
                }
            }

            lstDetalle.Items.Clear();
            lstDetalle.Items.Add("Galones por combustible:");

            if (galonesPorCombustible.Count == 0)
            {
                lstDetalle.Items.Add("(todavía no hay despachos)");
                return;
            }

            foreach (KeyValuePair<string, decimal> par in galonesPorCombustible)
            {
                lstDetalle.Items.Add($"  {par.Key,-8} {par.Value,6:0.0} gal");
            }
        }

        // Al seleccionar un despacho de la lista se ve su detalle paso a paso.
        private void lstDespachos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Despacho seleccionado = lstDespachos.SelectedItem as Despacho;

            if (seleccionado != null)
            {
                CalcularTotal(seleccionado.Combustible, seleccionado.Galones, seleccionado.Pago);
            }
        }
    }
}
