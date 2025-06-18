namespace FinanzasApp.Desktop
{
    partial class InformeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeForm));
            cbMes = new ComboBox();
            nudAño = new NumericUpDown();
            btnGenerar = new Button();
            lblResultado = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSalir = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)nudAño).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // cbMes
            // 
            cbMes.FormattingEnabled = true;
            cbMes.Location = new Point(51, 59);
            cbMes.Name = "cbMes";
            cbMes.Size = new Size(121, 23);
            cbMes.TabIndex = 0;
            // 
            // nudAño
            // 
            nudAño.Location = new Point(52, 30);
            nudAño.Name = "nudAño";
            nudAño.Size = new Size(120, 23);
            nudAño.TabIndex = 1;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(62, 22);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Adobe Fan Heiti Std B", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(32, 35);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(50, 19);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 62);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 4;
            label1.Text = "Mes:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 38);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 5;
            label2.Text = "Año:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Adobe Fan Heiti Std B", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(145, 20);
            label3.Name = "label3";
            label3.Size = new Size(194, 26);
            label3.TabIndex = 6;
            label3.Text = "Informe Financiero";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(62, 60);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbMes);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(nudAño);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 102);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGenerar);
            groupBox2.Controls.Add(btnSalir);
            groupBox2.Location = new Point(12, 169);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblResultado);
            groupBox3.Location = new Point(231, 49);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(285, 259);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Informe";
            // 
            // InformeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(564, 333);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "InformeForm";
            Text = "InformeForm";
            Load += InformeForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudAño).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMes;
        private NumericUpDown nudAño;
        private Button btnGenerar;
        private Label lblResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSalir;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}