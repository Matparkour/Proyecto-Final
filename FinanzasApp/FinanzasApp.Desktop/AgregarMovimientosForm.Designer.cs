namespace FinanzasApp.Desktop
{
    partial class AgregarMovimientosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbTipo = new ComboBox();
            txtDescripcion = new TextBox();
            dtpFecha = new DateTimePicker();
            btnGuradar = new Button();
            txtMonto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // cbTipo
            // 
            cbTipo.AutoCompleteCustomSource.AddRange(new string[] { "Ingreso", "Gasto" });
            cbTipo.FormattingEnabled = true;
            cbTipo.Location = new Point(106, 61);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(121, 23);
            cbTipo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(106, 101);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(200, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(102, 181);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 2;
            // 
            // btnGuradar
            // 
            btnGuradar.Location = new Point(148, 232);
            btnGuradar.Name = "btnGuradar";
            btnGuradar.Size = new Size(75, 23);
            btnGuradar.TabIndex = 3;
            btnGuradar.Text = "Guardar";
            btnGuradar.UseVisualStyleBackColor = true;
            btnGuradar.Click += btnGuradar_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(106, 141);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(121, 23);
            txtMonto.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 58);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 5;
            label1.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 104);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "Descripción:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 144);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 5;
            label3.Text = "Monto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 187);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 5;
            label4.Text = "Fecha:";
            // 
            // label5
            // 
            label5.Font = new Font("Adobe Fan Heiti Std B", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(55, 9);
            label5.Name = "label5";
            label5.Size = new Size(218, 25);
            label5.TabIndex = 6;
            label5.Text = "Agregar Movimiento";
            // 
            // AgregarMovimientosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(387, 322);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMonto);
            Controls.Add(btnGuradar);
            Controls.Add(dtpFecha);
            Controls.Add(txtDescripcion);
            Controls.Add(cbTipo);
            Name = "AgregarMovimientosForm";
            Text = "AgregarMovimientosForm";
            Load += AgregarMovimientosForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbTipo;
        private TextBox txtDescripcion;
        private DateTimePicker dtpFecha;
        private Button btnGuradar;
        private TextBox txtMonto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}