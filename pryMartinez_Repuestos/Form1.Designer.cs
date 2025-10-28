namespace pryMartinez_Repuestos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtNumero = new MaskedTextBox();
            lstDescripcion = new ListBox();
            rbImportado = new RadioButton();
            rbNacional = new RadioButton();
            rbRenault = new RadioButton();
            rbFiat = new RadioButton();
            rbPeugeot = new RadioButton();
            txtPrecio = new TextBox();
            btnRegistar = new Button();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            lblNumero = new Label();
            lblOrigen = new Label();
            lblMarca = new Label();
            tabPage2 = new TabPage();
            cmbOrigen = new ComboBox();
            cmbMarca = new ComboBox();
            lblOrigen2 = new Label();
            lblMarca2 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView1 = new DataGridView();
            colMarca = new DataGridViewTextBoxColumn();
            colOrigen = new DataGridViewTextBoxColumn();
            colNumero = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            lstResultados = new ListBox();
            rbImpoprtadoConsulta = new RadioButton();
            rbNacionalConsulta = new RadioButton();
            cmbConsultaMarca = new ComboBox();
            lblOrigenConsulta = new Label();
            lblMarcaConsulta = new Label();
            btnConsultar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(5, 19);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(461, 416);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtNumero);
            tabPage1.Controls.Add(lstDescripcion);
            tabPage1.Controls.Add(rbImportado);
            tabPage1.Controls.Add(rbNacional);
            tabPage1.Controls.Add(rbRenault);
            tabPage1.Controls.Add(rbFiat);
            tabPage1.Controls.Add(rbPeugeot);
            tabPage1.Controls.Add(txtPrecio);
            tabPage1.Controls.Add(btnRegistar);
            tabPage1.Controls.Add(lblDescripcion);
            tabPage1.Controls.Add(lblPrecio);
            tabPage1.Controls.Add(lblNumero);
            tabPage1.Controls.Add(lblOrigen);
            tabPage1.Controls.Add(lblMarca);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(453, 388);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(119, 124);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(197, 23);
            txtNumero.TabIndex = 14;
            txtNumero.ValidatingType = typeof(int);
            // 
            // lstDescripcion
            // 
            lstDescripcion.FormattingEnabled = true;
            lstDescripcion.ItemHeight = 15;
            lstDescripcion.Location = new Point(19, 250);
            lstDescripcion.Name = "lstDescripcion";
            lstDescripcion.Size = new Size(305, 79);
            lstDescripcion.TabIndex = 12;
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(252, 77);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(81, 19);
            rbImportado.TabIndex = 11;
            rbImportado.TabStop = true;
            rbImportado.Text = "Importado";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(133, 77);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(72, 19);
            rbNacional.TabIndex = 10;
            rbNacional.TabStop = true;
            rbNacional.Text = "Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            rbNacional.CheckedChanged += rbNacional_CheckedChanged;
            // 
            // rbRenault
            // 
            rbRenault.AutoSize = true;
            rbRenault.Location = new Point(275, 21);
            rbRenault.Name = "rbRenault";
            rbRenault.Size = new Size(32, 19);
            rbRenault.TabIndex = 9;
            rbRenault.TabStop = true;
            rbRenault.Text = "R";
            rbRenault.UseVisualStyleBackColor = true;
            rbRenault.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbFiat
            // 
            rbFiat.AutoSize = true;
            rbFiat.Location = new Point(202, 21);
            rbFiat.Name = "rbFiat";
            rbFiat.Size = new Size(31, 19);
            rbFiat.TabIndex = 8;
            rbFiat.TabStop = true;
            rbFiat.Text = "F";
            rbFiat.UseVisualStyleBackColor = true;
            // 
            // rbPeugeot
            // 
            rbPeugeot.AutoSize = true;
            rbPeugeot.Location = new Point(130, 21);
            rbPeugeot.Name = "rbPeugeot";
            rbPeugeot.Size = new Size(35, 19);
            rbPeugeot.TabIndex = 7;
            rbPeugeot.TabStop = true;
            rbPeugeot.Text = "P ";
            rbPeugeot.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(109, 178);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(207, 23);
            txtPrecio.TabIndex = 6;
            // 
            // btnRegistar
            // 
            btnRegistar.Location = new Point(263, 346);
            btnRegistar.Name = "btnRegistar";
            btnRegistar.Size = new Size(96, 36);
            btnRegistar.TabIndex = 5;
            btnRegistar.Text = "Registrar";
            btnRegistar.UseVisualStyleBackColor = true;
            btnRegistar.Click += btnRegistar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(6, 222);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(89, 20);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(19, 173);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(52, 20);
            lblPrecio.TabIndex = 3;
            lblPrecio.Text = "Precio";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(19, 124);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(66, 20);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Nùmero";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrigen.Location = new Point(19, 75);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(56, 20);
            lblOrigen.TabIndex = 1;
            lblOrigen.Text = "Origen";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(19, 21);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(52, 20);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(cmbOrigen);
            tabPage2.Controls.Add(cmbMarca);
            tabPage2.Controls.Add(lblOrigen2);
            tabPage2.Controls.Add(lblMarca2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(453, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Grilla";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "Nacional", "Importado" });
            cmbOrigen.Location = new Point(156, 71);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(234, 23);
            cmbOrigen.TabIndex = 9;
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "P- Peugeot", "F - Fiat", "R - Renault" });
            cmbMarca.Location = new Point(156, 28);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(234, 23);
            cmbMarca.TabIndex = 7;
            // 
            // lblOrigen2
            // 
            lblOrigen2.AutoSize = true;
            lblOrigen2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrigen2.Location = new Point(32, 74);
            lblOrigen2.Name = "lblOrigen2";
            lblOrigen2.Size = new Size(56, 20);
            lblOrigen2.TabIndex = 3;
            lblOrigen2.Text = "Origen";
            // 
            // lblMarca2
            // 
            lblMarca2.AutoSize = true;
            lblMarca2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca2.Location = new Point(32, 28);
            lblMarca2.Name = "lblMarca2";
            lblMarca2.Size = new Size(52, 20);
            lblMarca2.TabIndex = 2;
            lblMarca2.Text = "Marca";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(290, 220);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(8, 8);
            dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colMarca, colOrigen, colNumero, colDescripcion });
            dataGridView1.Location = new Point(9, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(441, 121);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // colMarca
            // 
            colMarca.HeaderText = "Marca";
            colMarca.Name = "colMarca";
            // 
            // colOrigen
            // 
            colOrigen.HeaderText = "Origen";
            colOrigen.Name = "colOrigen";
            // 
            // colNumero
            // 
            colNumero.HeaderText = "Número";
            colNumero.Name = "colNumero";
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripción";
            colDescripcion.Name = "colDescripcion";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(lstResultados);
            tabPage3.Controls.Add(rbImpoprtadoConsulta);
            tabPage3.Controls.Add(rbNacionalConsulta);
            tabPage3.Controls.Add(cmbConsultaMarca);
            tabPage3.Controls.Add(lblOrigenConsulta);
            tabPage3.Controls.Add(lblMarcaConsulta);
            tabPage3.Controls.Add(btnConsultar);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(453, 388);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Consulta";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.ItemHeight = 15;
            lstResultados.Location = new Point(42, 176);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(384, 94);
            lstResultados.TabIndex = 6;
            lstResultados.SelectedIndexChanged += lstResultados_SelectedIndexChanged;
            // 
            // rbImpoprtadoConsulta
            // 
            rbImpoprtadoConsulta.AutoSize = true;
            rbImpoprtadoConsulta.Location = new Point(311, 66);
            rbImpoprtadoConsulta.Name = "rbImpoprtadoConsulta";
            rbImpoprtadoConsulta.Size = new Size(81, 19);
            rbImpoprtadoConsulta.TabIndex = 5;
            rbImpoprtadoConsulta.TabStop = true;
            rbImpoprtadoConsulta.Text = "Importado";
            rbImpoprtadoConsulta.UseVisualStyleBackColor = true;
            // 
            // rbNacionalConsulta
            // 
            rbNacionalConsulta.AutoSize = true;
            rbNacionalConsulta.Location = new Point(153, 64);
            rbNacionalConsulta.Name = "rbNacionalConsulta";
            rbNacionalConsulta.Size = new Size(72, 19);
            rbNacionalConsulta.TabIndex = 4;
            rbNacionalConsulta.TabStop = true;
            rbNacionalConsulta.Text = "Nacional";
            rbNacionalConsulta.UseVisualStyleBackColor = true;
            // 
            // cmbConsultaMarca
            // 
            cmbConsultaMarca.FormattingEnabled = true;
            cmbConsultaMarca.Items.AddRange(new object[] { "F - FIAT", "R - RENAULT", "P - PEUGEOT" });
            cmbConsultaMarca.Location = new Point(153, 18);
            cmbConsultaMarca.Name = "cmbConsultaMarca";
            cmbConsultaMarca.Size = new Size(215, 23);
            cmbConsultaMarca.TabIndex = 3;
            // 
            // lblOrigenConsulta
            // 
            lblOrigenConsulta.AutoSize = true;
            lblOrigenConsulta.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrigenConsulta.Location = new Point(27, 65);
            lblOrigenConsulta.Name = "lblOrigenConsulta";
            lblOrigenConsulta.Size = new Size(56, 20);
            lblOrigenConsulta.TabIndex = 2;
            lblOrigenConsulta.Text = "Origen";
            // 
            // lblMarcaConsulta
            // 
            lblMarcaConsulta.AutoSize = true;
            lblMarcaConsulta.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarcaConsulta.Location = new Point(30, 21);
            lblMarcaConsulta.Name = "lblMarcaConsulta";
            lblMarcaConsulta.Size = new Size(52, 20);
            lblMarcaConsulta.TabIndex = 1;
            lblMarcaConsulta.Text = "Marca";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(330, 124);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(96, 28);
            btnConsultar.TabIndex = 0;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(478, 447);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Registro Repuestos";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Label lblNumero;
        private Label lblOrigen;
        private Label lblMarca;
        private TabPage tabPage2;
        private Button btnRegistar;
        private RadioButton rbFiat;
        private RadioButton rbPeugeot;
        private TextBox txtPrecio;
        private RadioButton rbImportado;
        private RadioButton rbNacional;
        private RadioButton rbRenault;
        private ListBox lstDescripcion;
        private MaskedTextBox txtNumero;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colOrigen;
        private DataGridViewTextBoxColumn colNumero;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridView dataGridView2;
        private Label lblOrigen2;
        private Label lblMarca2;
        private ComboBox cmbMarca;
        private ComboBox cmbOrigen;
        private TabPage tabPage3;
        private RadioButton rbImpoprtadoConsulta;
        private RadioButton rbNacionalConsulta;
        private ComboBox cmbConsultaMarca;
        private Label lblOrigenConsulta;
        private Label lblMarcaConsulta;
        private Button btnConsultar;
        private ListBox lstResultados;
    }
}
