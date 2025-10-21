namespace pryMartinez_Repuestos
{
    public partial class Form1 : Form
    {
        string[,] matRepuesto = new string[4, 5];
        public Form1()
        {
            InitializeComponent();
        }
        public class Repuesto
        {
            public string Marca;
            public string Origen;
            public string Descripcion;
            public double Precio;
        }

        Repuesto[] repuestos = new Repuesto[100];
        int cantidad = 0;
        int indiceGrabar = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            {
                if (cantidad >= repuestos.Length)
                {
                    MessageBox.Show("No se pueden agregar más repuestos.");
                    return;
                }

                string marca = rbPeugeot.Checked ? "Peugeot" :
                               rbFiat.Checked ? "Fiat" :
                               rbRenault.Checked ? "Renault" : "";

                string origen = rbNacional.Checked ? "Nacional" :
                                rbImportado.Checked ? "Importado" : "";

                string descripcion = lstDescripcion.Text;
                if (!double.TryParse(txtPrecio.Text, out double precio))
                {
                    MessageBox.Show("Precio inválido.");
                    return;
                }

                repuestos[cantidad] = new Repuesto
                {
                    Marca = marca,
                    Origen = origen,
                    Descripcion = descripcion,
                    Precio = precio
                };

                cantidad++;
                MessageBox.Show("Repuesto agregado correctamente.");
                lstDescripcion.Items.Clear();
                txtPrecio.Clear();


                matRepuesto[indiceGrabar, 0] = marca;
                matRepuesto[indiceGrabar, 1] = origen;
                matRepuesto[indiceGrabar, 2] = descripcion;
                matRepuesto[indiceGrabar, 3] = precio.ToString();
                indiceGrabar++;



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargadorDatos();
            MessageBox.Show("Datos Cargados Correctamente");

            List<string> origenes = new List<string>();
            List<string> listaMarcas = new List<string>();

            for (int filas = 0; filas < matRepuesto.GetLength(0); filas++)
            {
                DataGridView.Rows.Add(matRepuesto[filas, 0], matRepuesto[filas, 1], matRepuesto[filas, 2], matRepuesto[filas, 3], matRepuesto[filas, 4]);
                if (!listaMarcas.Contains(matRepuesto[filas, 0]))
                {
                    listaMarcas.Add(matRepuesto[filas, 0]);
                }
                if (!origenes.Contains(matRepuesto[filas, 1]))
                {
                    origenes.Add(matRepuesto[filas, 1]);
                }

                cmbMarca.DataSource = listaMarcas;
                cmbOrigen.DataSource = origenes;    
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbNacional_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void CargadorDatos()
        { 
        }
private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }
    }
}
