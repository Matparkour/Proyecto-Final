namespace FinanzasApp.Desktop
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
            lblTipo = new Label();
            cbTipo = new ComboBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblMonto = new Label();
            txtMonto = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            dgvMovimientos = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(94, 91);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(33, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo:";
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Ingreso", "Gasto" });
            cbTipo.Location = new Point(158, 88);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(55, 135);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(158, 132);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(192, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(81, 180);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(46, 15);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(158, 177);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(160, 23);
            txtMonto.TabIndex = 5;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(81, 224);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(158, 216);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(204, 269);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(422, 53);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.Size = new Size(353, 295);
            dgvMovimientos.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(252, 34);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 10;
            label1.Text = "Administrador de finanzas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvMovimientos);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(cbTipo);
            Controls.Add(lblTipo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipo;
        private ComboBox cbTipo;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblMonto;
        private TextBox txtMonto;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
        private DataGridView dgvMovimientos;
        private Label label1;
    }
}
