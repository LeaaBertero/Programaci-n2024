namespace ListaPersonas
{
    partial class Lista
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
            btCargar = new Button();
            txNombre = new TextBox();
            txApellido = new TextBox();
            label1 = new Label();
            lbLista = new Label();
            label3 = new Label();
            label4 = new Label();
            btMostrar = new Button();
            txEdad = new TextBox();
            label5 = new Label();
            btCerrar = new Button();
            btBorrarlista = new Button();
            SuspendLayout();
            // 
            // btCargar
            // 
            btCargar.Cursor = Cursors.Hand;
            btCargar.Location = new Point(467, 227);
            btCargar.Name = "btCargar";
            btCargar.Size = new Size(94, 29);
            btCargar.TabIndex = 4;
            btCargar.Text = "Cargar";
            btCargar.UseVisualStyleBackColor = true;
            btCargar.Click += btCargar_Click;
            // 
            // txNombre
            // 
            txNombre.Location = new Point(58, 227);
            txNombre.Name = "txNombre";
            txNombre.Size = new Size(125, 27);
            txNombre.TabIndex = 1;
            // 
            // txApellido
            // 
            txApellido.Location = new Point(189, 227);
            txApellido.Name = "txApellido";
            txApellido.Size = new Size(125, 27);
            txApellido.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 204);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 3;
            label1.Text = "Apellido";
            // 
            // lbLista
            // 
            lbLista.AutoSize = true;
            lbLista.Location = new Point(743, 234);
            lbLista.Name = "lbLista";
            lbLista.Size = new Size(50, 20);
            lbLista.TabIndex = 4;
            lbLista.Text = "label2";
            lbLista.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 204);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(189, 42);
            label4.Name = "label4";
            label4.Size = new Size(598, 41);
            label4.TabIndex = 6;
            label4.Text = "PROYECTO - CARGA LISTA DE PERSONAS";
            // 
            // btMostrar
            // 
            btMostrar.Cursor = Cursors.Hand;
            btMostrar.Location = new Point(567, 226);
            btMostrar.Name = "btMostrar";
            btMostrar.Size = new Size(94, 29);
            btMostrar.TabIndex = 5;
            btMostrar.Text = "Mostrar";
            btMostrar.UseVisualStyleBackColor = true;
            btMostrar.Click += btMostrar_Click;
            // 
            // txEdad
            // 
            txEdad.Location = new Point(320, 227);
            txEdad.Name = "txEdad";
            txEdad.Size = new Size(125, 27);
            txEdad.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 204);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 9;
            label5.Text = "Edad";
            // 
            // btCerrar
            // 
            btCerrar.Cursor = Cursors.Hand;
            btCerrar.Location = new Point(893, 12);
            btCerrar.Name = "btCerrar";
            btCerrar.Size = new Size(94, 29);
            btCerrar.TabIndex = 10;
            btCerrar.Text = "Cerrar";
            btCerrar.UseVisualStyleBackColor = true;
            btCerrar.Click += btCerrar_Click;
            // 
            // btBorrarlista
            // 
            btBorrarlista.Cursor = Cursors.Hand;
            btBorrarlista.Location = new Point(467, 276);
            btBorrarlista.Name = "btBorrarlista";
            btBorrarlista.Size = new Size(194, 29);
            btBorrarlista.TabIndex = 11;
            btBorrarlista.Text = "Limpiar lista";
            btBorrarlista.UseVisualStyleBackColor = true;
            btBorrarlista.Click += btBorrarlista_Click;
            // 
            // Lista
            // 
            AcceptButton = btCargar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chartreuse;
            ClientSize = new Size(999, 599);
            Controls.Add(btBorrarlista);
            Controls.Add(btCerrar);
            Controls.Add(label5);
            Controls.Add(txEdad);
            Controls.Add(btMostrar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbLista);
            Controls.Add(label1);
            Controls.Add(txApellido);
            Controls.Add(txNombre);
            Controls.Add(btCargar);
            Name = "Lista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCargar;
        private TextBox txNombre;
        private TextBox txApellido;
        private Label label1;
        private Label lbLista;
        private Label label3;
        private Label label4;
        private Button btMostrar;
        private TextBox txEdad;
        private Label label5;
        private Button btCerrar;
        private Button btBorrarlista;
    }
}