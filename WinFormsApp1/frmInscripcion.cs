using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class frmInscripcion : Form
    {
        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMeses_Click(object sender, EventArgs e)
        {

        }

        private void lblCuotas_Click(object sender, EventArgs e)
        {

        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            cboPlan.Items.Clear();
            cboPlan.Items.Add("Musculación");
            cboPlan.Items.Add("Funcional");
            cboPlan.Items.Add("Natación");
            cboPlan.SelectedIndex = 0;

            cboTurno.Items.Clear();
            cboTurno.Items.Add("Mañana");
            cboTurno.Items.Add("Tarde");
            cboTurno.Items.Add("Noche");
            cboTurno.SelectedIndex = 0;

            cboCuotas.Items.Clear();
            cboCuotas.Items.Add("1");
            cboCuotas.Items.Add("3");
            cboCuotas.Items.Add("6");
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;

            txtMeses.Text = "1";
            rbtEfectivo.Checked = true;
        }

        private void rbtTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtTarjeta.Checked)
            {
                cboCuotas.Enabled = true;
                cboCuotas.SelectedIndex = 0;
            }
            else
            {
                cboCuotas.Enabled = false;
                cboCuotas.SelectedIndex = -1;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtEdad.Text == "" || txtMeses.Text == "")
            {
                MessageBox.Show("Por favor complete todos los datos.");
                return;
            }

            int edad = int.Parse(txtEdad.Text);
            int meses = int.Parse(txtMeses.Text);

            if (edad < 14)
            {
                MessageBox.Show("El socio debe tener al menos 14 años.");
                return;
            }

            if (meses < 1 || meses > 12)
            {
                MessageBox.Show("Los meses deben estar entre 1 y 12.");
                return;
            }

            decimal precioMensual = 0;
            string plan = cboPlan.SelectedItem?.ToString() ?? "";

            switch (plan)
            {
                case "Musculación":
                    precioMensual = 15000;
                    break;
                case "Funcional":
                    precioMensual = 18000;
                    break;
                case "Natación":
                    precioMensual = 22000;
                    break;
            }

            string turno = "";
            switch (cboTurno.SelectedIndex)
            {
                case 0:
                    turno = "Mañana (7 a 12 h)";
                    break;
                case 1:
                    turno = "Tarde (14 a 18 h)";
                    break;
                case 2:
                    turno = "Noche (18 a 23 h)";
                    break;
            }

            if (chkCasillero.Checked) precioMensual += 3000;

            decimal subtotal = precioMensual * meses;

            decimal porcDescuento = 0;
            if (edad < 18)
            {
                porcDescuento = 0.25m;
            }
            else
            {
                if (edad >= 65)
                {
                    porcDescuento = 0.30m;
                }
                else if (chkEstudiante.Checked)
                {
                    porcDescuento = 0.15m;
                }
                else
                {
                    porcDescuento = 0;
                }
            }

            decimal totalConDescuento = subtotal - (subtotal * porcDescuento);

            decimal totalFinal = totalConDescuento;
            int cuotas = 1;

            if (rbtEfectivo.Checked)
            {
                totalFinal -= (totalConDescuento * 0.10m);
            }
            else
            {
                cuotas = int.Parse(cboCuotas.Text);

                if (cuotas == 3)
                {
                    totalFinal += (totalConDescuento * 0.10m);
                }
                else if (cuotas == 6)
                {
                    totalFinal += (totalConDescuento * 0.20m);
                }
            }

            decimal valorCuota = rbtEfectivo.Checked ? totalFinal : (totalFinal / cuotas);

            string resumen = "Detalle del cálculo:\n\n" +
                             "Nombre: " + txtNombre.Text + "\n" +
                             "Plan: " + plan + "\n" +
                             "Turno: " + turno + "\n" +
                             "Meses: " + meses + "\n\n" +
                             "Total: $" + totalFinal.ToString("N2") + "\n" +
                             "Cuota: $" + valorCuota.ToString("N2");

            MessageBox.Show(resumen, "Inscripción");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEdad.Clear();
            txtMeses.Text = "1";

            chkEstudiante.Checked = false;
            chkCasillero.Checked = false;

            cboPlan.SelectedIndex = 0;
            cboTurno.SelectedIndex = 0;

            rbtEfectivo.Checked = true;
            cboCuotas.SelectedIndex = -1;
            cboCuotas.Enabled = false;

            txtNombre.Focus();
        }

            
            private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
    }


