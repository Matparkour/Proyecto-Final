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
    public partial class InformeForm : Form
    {
        public InformeForm()
        {
            InitializeComponent();
            cbMes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMes.Items.AddRange(System.Globalization.DateTimeFormatInfo.CurrentInfo.MonthNames
                .Where(m => !string.IsNullOrEmpty(m)).ToArray());

            cbMes.SelectedIndex = DateTime.Now.Month - 1;
            nudAño.Minimum = 2000;
            nudAño.Maximum = 2100;
            nudAño.Value = DateTime.Now.Year;

        }

        private void InformeForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnGenerar_Click(object sender, EventArgs e)
        {
            int mesSeleccionado = cbMes.SelectedIndex + 1;
            int anioSeleccionado = (int)nudAño.Value;

            List<Movimiento> movimientos;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/");
                var response = await client.GetAsync("api/finanzas");
                movimientos = await response.Content.ReadFromJsonAsync<List<Movimiento>>();
            }

            var movimientosFiltrados = movimientos
                .Where(m => m.Fecha.Month == mesSeleccionado && m.Fecha.Year == anioSeleccionado)
                .ToList();

            decimal totalIngresos = movimientosFiltrados
                .Where(m => m.Tipo == "Ingreso")
                .Sum(m => m.Monto);

            decimal totalGastos = movimientosFiltrados
                .Where(m => m.Tipo == "Gasto")
                .Sum(m => m.Monto);

            decimal balance = totalIngresos - totalGastos;

            lblResultado.Text = $"Informe de {cbMes.SelectedItem} {anioSeleccionado}\n\n" +
                                $"✔ Total Ingresos: {totalIngresos:C}\n" +
                                $"❌ Total Gastos: {totalGastos:C}\n" +
                                $"💰 Balance: {balance:C}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
