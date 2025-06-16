using FinanzasApp.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanzasApp.Desktop
{
    public partial class AgregarMovimientosForm : Form
    {
        public AgregarMovimientosForm()
        {
            InitializeComponent();
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.Items.Add("Ingreso");
            cbTipo.Items.Add("Gasto");
        }

        private async void btnGuradar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("La descripción no puede estar vacía.");
                return;
            }

            if (cbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un tipo de movimiento.");
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("El monto ingresado no es válido.");
                return;
            }

            Movimiento movimiento = new Movimiento
            {
                Descripcion = txtDescripcion.Text,
                Monto = monto,
                Tipo = cbTipo.SelectedItem.ToString(),
                Fecha = dtpFecha.Value
            };

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/");
                var response = await client.PostAsJsonAsync("api/finanzas", movimiento);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Movimiento guardado correctamente.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al guardar el movimiento.");
                }
            }
        }

        private void AgregarMovimientosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
