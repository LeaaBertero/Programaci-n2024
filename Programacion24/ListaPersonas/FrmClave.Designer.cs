namespace ListaPersonas
{
    partial class FrmClave
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
            btIngresar = new Button();
            txIngresar = new TextBox();
            btSalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btIngresar
            // 
            btIngresar.Cursor = Cursors.Hand;
            btIngresar.Location = new Point(307, 280);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(94, 29);
            btIngresar.TabIndex = 0;
            btIngresar.Text = "Ingresar";
            btIngresar.UseVisualStyleBackColor = true;
            btIngresar.Click += btIngresar_Click;
            // 
            // txIngresar
            // 
            txIngresar.Location = new Point(492, 282);
            txIngresar.Name = "txIngresar";
            txIngresar.PasswordChar = '*';
            txIngresar.Size = new Size(125, 27);
            txIngresar.TabIndex = 1;
            // 
            // btSalir
            // 
            btSalir.Cursor = Cursors.Hand;
            btSalir.Location = new Point(893, 12);
            btSalir.Name = "btSalir";
            btSalir.Size = new Size(94, 29);
            btSalir.TabIndex = 2;
            btSalir.Text = "Salir";
            btSalir.UseVisualStyleBackColor = true;
            btSalir.Click += btSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(336, 216);
            label1.Name = "label1";
            label1.Size = new Size(263, 20);
            label1.TabIndex = 3;
            label1.Text = "Ingrese clave para el sistema = \"clave\"";
            // 
            // FrmClave
            // 
            AcceptButton = btIngresar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chartreuse;
            ClientSize = new Size(999, 599);
            Controls.Add(label1);
            Controls.Add(btSalir);
            Controls.Add(txIngresar);
            Controls.Add(btIngresar);
            Name = "FrmClave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmClave";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btIngresar;
        private TextBox txIngresar;
        private Button btSalir;
        private Label label1;
    }
}