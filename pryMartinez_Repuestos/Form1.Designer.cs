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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            lblMarca = new Label();
            lblOrigen = new Label();
            lblNumero = new Label();
            lblPrecio = new Label();
            lblDescripcion = new Label();
            btnRegistar = new Button();
            textBox1 = new TextBox();
            rbPeugeot = new RadioButton();
            rbFiat = new RadioButton();
            rbRenault = new RadioButton();
            rbNacional = new RadioButton();
            rbImportado = new RadioButton();
            lstDescripcion = new ListBox();
            maskedTextBox1 = new MaskedTextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(14, 19);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(374, 416);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(maskedTextBox1);
            tabPage1.Controls.Add(lstDescripcion);
            tabPage1.Controls.Add(rbImportado);
            tabPage1.Controls.Add(rbNacional);
            tabPage1.Controls.Add(rbRenault);
            tabPage1.Controls.Add(rbFiat);
            tabPage1.Controls.Add(rbPeugeot);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(btnRegistar);
            tabPage1.Controls.Add(lblDescripcion);
            tabPage1.Controls.Add(lblPrecio);
            tabPage1.Controls.Add(lblNumero);
            tabPage1.Controls.Add(lblOrigen);
            tabPage1.Controls.Add(lblMarca);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(366, 388);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(366, 388);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            // textBox1
            // 
            textBox1.Location = new Point(109, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 23);
            textBox1.TabIndex = 6;
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
            // lstDescripcion
            // 
            lstDescripcion.FormattingEnabled = true;
            lstDescripcion.ItemHeight = 15;
            lstDescripcion.Location = new Point(19, 250);
            lstDescripcion.Name = "lstDescripcion";
            lstDescripcion.Size = new Size(305, 79);
            lstDescripcion.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(119, 124);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(197, 23);
            maskedTextBox1.TabIndex = 14;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 447);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Registro Repuestos";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
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
        private TextBox textBox1;
        private RadioButton rbImportado;
        private RadioButton rbNacional;
        private RadioButton rbRenault;
        private ListBox lstDescripcion;
        private MaskedTextBox maskedTextBox1;
    }
}
