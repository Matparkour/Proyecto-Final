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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvMovimientos = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button3 = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            btnBorrar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimientos.Location = new Point(6, 22);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.Size = new Size(611, 335);
            dgvMovimientos.TabIndex = 9;
            // 
            // label1
            // 
            label1.Font = new Font("Adobe Fan Heiti Std B", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 18);
            label1.Name = "label1";
            label1.Size = new Size(357, 36);
            label1.TabIndex = 10;
            label1.Text = "Administrador de finanzas";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvMovimientos);
            groupBox1.Location = new Point(147, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 363);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // button3
            // 
            button3.Location = new Point(17, 115);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 12;
            button3.Text = "Informe";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(17, 67);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(17, 22);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBorrar);
            groupBox2.Controls.Add(btnSalir);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(btnActualizar);
            groupBox2.Location = new Point(12, 96);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(111, 363);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Acciones";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(17, 164);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 14;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(17, 308);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(797, 483);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Administrador de Finanzas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvMovimientos;
        private Label label1;
        private GroupBox groupBox1;
        private Button button3;
        private Button btnActualizar;
        private Button btnAgregar;
        private GroupBox groupBox2;
        private Button btnBorrar;
        private Button btnSalir;
    }
}
