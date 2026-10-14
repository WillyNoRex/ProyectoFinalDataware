namespace ProyectoFase3App
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btn_prueba = new Button();
            lblEstado = new Label();
            dgvDatos = new DataGridView();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // btn_prueba
            // 
            btn_prueba.Location = new Point(609, 14);
            btn_prueba.Margin = new Padding(3, 2, 3, 2);
            btn_prueba.Name = "btn_prueba";
            btn_prueba.Size = new Size(70, 24);
            btn_prueba.TabIndex = 4;
            btn_prueba.Text = "Probar";
            btn_prueba.UseVisualStyleBackColor = true;
            btn_prueba.Click += btn_prueba_Click;
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(21, 308);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(214, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "La aplicación leerá datos de SQL Server.";
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvDatos.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.EnableHeadersVisualStyles = false;
            dgvDatos.Location = new Point(21, 54);
            dgvDatos.Margin = new Padding(3, 2, 3, 2);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.RowHeadersWidth = 51;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(658, 219);
            dgvDatos.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(21, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(377, 23);
            txtBuscar.TabIndex = 8;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(404, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 34);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar Nombre";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvDatos);
            Controls.Add(lblEstado);
            Controls.Add(btn_prueba);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Consulta de clientes - SQL Server";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_prueba;
        private Label lblEstado;
        private DataGridView dgvDatos;
        private TextBox txtBuscar;
        private Button btnBuscar;
    }
}
