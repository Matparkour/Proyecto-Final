using FinanzasApp.API.Models;
using System.Net.Http.Json;
using FinanzasApp.Desktop;

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


            await CargarMovimientos();

        }
        public async Task<bool> GuardarMovimientoAsync(Movimiento movimiento)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/");

                HttpResponseMessage response = await client.PostAsJsonAsync("api/finanzas", movimiento);

                return response.IsSuccessStatusCode;
            }
        }      

        public async Task<List<Movimiento>> ObtenerMovimientosAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/");
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
            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// agregue esta linea para poder arreglar el problema de la data grid view

            //columnas que no quiero editar
            //if (dgvMovimientos.Columns["Id"] != null)
              //  dgvMovimientos.Columns["Id"].ReadOnly = true;

            //if (dgvMovimientos.Columns["Fecha"] != null)
              //  dgvMovimientos.Columns["Fecha"].ReadOnly = true;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            var formAgregar = new AgregarMovimientosForm();
            formAgregar.FormClosed += async (s, args) => await CargarMovimientos();
            formAgregar.ShowDialog();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await CargarMovimientos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            var form = new InformeForm();
            form.ShowDialog();
        }

        private void dgvMovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public async Task<bool> EliminarMovimientoAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7092/");
                HttpResponseMessage response = await client.DeleteAsync($"api/finanzas/{id}");
                return response.IsSuccessStatusCode;
            }
        }

        private async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvMovimientos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un movimiento para borrar.");
                return;
            }

            var confirmResult = MessageBox.Show("¿Estás seguro que querés borrar este movimiento?", "Confirmar borrado", MessageBoxButtons.YesNo);
            if (confirmResult != DialogResult.Yes) return;

            var movimiento = (Movimiento)dgvMovimientos.CurrentRow.DataBoundItem;

            bool borrado = await EliminarMovimientoAsync(movimiento.Id);

            if (borrado)
            {
                MessageBox.Show("Movimiento borrado correctamente.");
                await CargarMovimientos(); // refresca el grid
            }
            else
            {
                MessageBox.Show("Error al borrar el movimiento.");
            }
        }
    }
}
