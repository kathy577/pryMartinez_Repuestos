namespace pryMartinez_Repuestos
{
    public partial class Form1 : Form
    {
        string[,] matRepuesto = new string[100, 5];
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
                dataGridView1.Rows.Add(matRepuesto[filas, 0], matRepuesto[filas, 1], matRepuesto[filas, 2], matRepuesto[filas, 3], matRepuesto[filas, 4]);
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
            string[] marcas = { "P", "F", "R" };
            string[] origenes = { "N", "I" };
            string[] descripciones = {
        "Filtro de aceite", "Pastillas de freno", "Bujía", "Amortiguador", "Correa de distribución",
        "Radiador", "Filtro de aire", "Kit de embrague", "Termostato", "Sensor de oxígeno",
        "Alternador", "Batería", "Espejo retrovisor", "Parabrisas", "Motor de arranque",
        "Bobina de encendido", "Compresor de aire", "Disco de freno", "Cilindro maestro", "Lámpara LED"
    };

            Random rnd = new Random();

            for (int i = 0; i < 100; i++)
            {
                string marca = marcas[rnd.Next(marcas.Length)];
                string origen = origenes[rnd.Next(origenes.Length)];
                string descripcion = descripciones[rnd.Next(descripciones.Length)] + $" {rnd.Next(1, 6)}";
                double precio = rnd.Next(1500, 12000) + rnd.NextDouble(); // precios entre 1500 y 12000
              

                matRepuesto[i, 0] = marca;
                matRepuesto[i, 1] = origen == "N" ? "Nacional" : "Importado";
                matRepuesto[i, 2] = descripcion;
                matRepuesto[i, 3] = precio.ToString("F2");
               
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void lstResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            // Validación de selección
            if (cmbMarca.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná una marca.");
                return;
            }

            string marcaSeleccionada = cmbMarca.SelectedItem.ToString();
            string origenSeleccionado = rbNacionalConsulta.Checked ? "Nacional" :
                                         rbImpoprtadoConsulta.Checked ? "Importado" : "";

            if (origenSeleccionado == "")
            {
                MessageBox.Show("Seleccioná un origen.");
                return;
            }

            // Limpiar resultados anteriores
            lstResultados.Items.Clear(); 
                                         

            int contador = 0;

            for (int i = 0; i < cantidad; i++)
            {
                string marcaLetra = repuestos[i].Marca.Substring(0, 1).ToUpper(); // P, F, R

                if (marcaLetra == marcaSeleccionada && repuestos[i].Origen == origenSeleccionado)
                {
                    contador++;
                    string resultado = $"{contador}. {repuestos[i].Descripcion} - ${repuestos[i].Precio:F2}";

                    lstResultados.Items.Add(resultado);
                                                       
                }
            }

            if (contador == 0)
            {
                MessageBox.Show("No se encontraron repuestos con esos criterios.");
            }
        }
    }
}
