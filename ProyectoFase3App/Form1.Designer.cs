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
            btn_prueba = new Button();
            lblEstado = new Label();
            SuspendLayout();
            //
            // btn_prueba
            //
            btn_prueba.Location = new Point(696, 19);
            btn_prueba.Name = "btn_prueba";
            btn_prueba.Size = new Size(80, 32);
            btn_prueba.TabIndex = 4;
            btn_prueba.Text = "Probar";
            btn_prueba.UseVisualStyleBackColor = true;
            btn_prueba.Click += btn_prueba_Click;
            //
            // lblEstado
            //
            lblEstado.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(24, 410);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(273, 20);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "La aplicación leerá datos de SQL Server.";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEstado);
            Controls.Add(btn_prueba);
            Name = "Form1";
            Text = "Consulta de clientes - SQL Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_prueba;
        private Label lblEstado;
    }
}
