using FinanzasApp.API.Models;
using System.Net.Http.Json;

namespace FinanzasApp.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Aquí cargamos las opciones del ComboBox
            

            cbTipo.Items.Clear();
            cbTipo.Items.Add("Ingreso");
            cbTipo.Items.Add("Gasto");
            cbTipo.SelectedIndex = -1; // para que no haya nada seleccionado al cargar

            await CargarMovimientos();

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que txtMonto tenga un número válido
            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("Por favor ingresa un monto válido.");
                return;
            }

            // Validar que se haya seleccionado un tipo
            if (cbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor selecciona un tipo (Ingreso o Gasto).");
                return;
            }

            Movimiento mov = new Movimiento
            {
                Descripcion = txtDescripcion.Text,
                Fecha = dtpFecha.Value,
                Monto = monto,
                Tipo = cbTipo.SelectedItem.ToString()
            };

            bool exito = await GuardarMovimientoAsync(mov);

            if (exito)
            {
                MessageBox.Show("Movimiento guardado con éxito.");
                LimpiarCampos();
                await CargarMovimientos(); // <- recarga para que veas los movimientos en pantalla
            }
            else
            {
                MessageBox.Show("Error al guardar el movimiento.");
            }
        }
        public async Task<bool> GuardarMovimientoAsync(Movimiento movimiento)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/"); // Cambia este puerto si es otro

                HttpResponseMessage response = await client.PostAsJsonAsync("api/finanzas", movimiento);

                return response.IsSuccessStatusCode;
            }
        }

        private void LimpiarCampos()
        {
            txtDescripcion.Text = "";
            txtMonto.Text = "";
            cbTipo.SelectedIndex = -1;
            dtpFecha.Value = DateTime.Now;
        }

        public async Task<List<Movimiento>> ObtenerMovimientosAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/"); // Usá el puerto que tengas
                HttpResponseMessage response = await client.GetAsync("api/finanzas");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<List<Movimiento>>();
                }
                else
                {
                    MessageBox.Show("Error al obtener movimientos.");
                    return new List<Movimiento>();
                }
            }
        }

        private async Task CargarMovimientos()
        {
            var lista = await ObtenerMovimientosAsync();
           
            dgvMovimientos.AutoGenerateColumns = true;
            dgvMovimientos.DataSource = lista;
        }
    }
}
