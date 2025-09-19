namespace Indice.Formularios
{
    partial class FormInicio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnComprarEntrada = new System.Windows.Forms.Button();
            this.btnVerPeliculas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.tabDatosPersonales = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabAsientos = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.tabInicio.SuspendLayout();
            this.tabDatosPersonales.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.btnVerPeliculas);
            this.panel1.Controls.Add(this.btnComprarEntrada);
            this.panel1.Controls.Add(this.btnReservas);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(0, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 430);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Indice.Properties.Resources.LentesCine;
            this.pictureBox3.Location = new System.Drawing.Point(112, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "CINE+";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gold;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(394, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "Nose";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.Gold;
            this.btnReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservas.FlatAppearance.BorderSize = 0;
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.Location = new System.Drawing.Point(0, 181);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(394, 51);
            this.btnReservas.TabIndex = 3;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = false;
            // 
            // btnComprarEntrada
            // 
            this.btnComprarEntrada.BackColor = System.Drawing.Color.Gold;
            this.btnComprarEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprarEntrada.FlatAppearance.BorderSize = 0;
            this.btnComprarEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprarEntrada.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprarEntrada.Location = new System.Drawing.Point(0, 112);
            this.btnComprarEntrada.Name = "btnComprarEntrada";
            this.btnComprarEntrada.Size = new System.Drawing.Size(394, 51);
            this.btnComprarEntrada.TabIndex = 2;
            this.btnComprarEntrada.Text = "Comprar entrada";
            this.btnComprarEntrada.UseVisualStyleBackColor = false;
            this.btnComprarEntrada.Click += new System.EventHandler(this.btnComprarEntrada_Click);
            // 
            // btnVerPeliculas
            // 
            this.btnVerPeliculas.BackColor = System.Drawing.Color.Gold;
            this.btnVerPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPeliculas.FlatAppearance.BorderSize = 0;
            this.btnVerPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPeliculas.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPeliculas.Location = new System.Drawing.Point(0, 42);
            this.btnVerPeliculas.Name = "btnVerPeliculas";
            this.btnVerPeliculas.Size = new System.Drawing.Size(394, 51);
            this.btnVerPeliculas.TabIndex = 1;
            this.btnVerPeliculas.Text = "Ver peliculas";
            this.btnVerPeliculas.UseVisualStyleBackColor = false;
            this.btnVerPeliculas.Click += new System.EventHandler(this.btnVerPeliculas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Indice.Properties.Resources.Exit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AliceBlue;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AliceBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(323, 6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 60);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabInicio);
            this.tabGeneral.Controls.Add(this.tabDatosPersonales);
            this.tabGeneral.Controls.Add(this.tabAsientos);
            this.tabGeneral.Location = new System.Drawing.Point(400, 45);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(844, 392);
            this.tabGeneral.TabIndex = 3;
            // 
            // tabInicio
            // 
            this.tabInicio.BackColor = System.Drawing.Color.Black;
            this.tabInicio.Controls.Add(this.panel8);
            this.tabInicio.Controls.Add(this.panel7);
            this.tabInicio.Controls.Add(this.panel9);
            this.tabInicio.Controls.Add(this.panel6);
            this.tabInicio.Controls.Add(this.panel10);
            this.tabInicio.Controls.Add(this.panel11);
            this.tabInicio.Controls.Add(this.panel5);
            this.tabInicio.Controls.Add(this.panel12);
            this.tabInicio.Controls.Add(this.panel4);
            this.tabInicio.Controls.Add(this.panel3);
            this.tabInicio.Location = new System.Drawing.Point(4, 22);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(836, 366);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Inicio";
            // 
            // tabDatosPersonales
            // 
            this.tabDatosPersonales.BackColor = System.Drawing.SystemColors.WindowText;
            this.tabDatosPersonales.Controls.Add(this.label2);
            this.tabDatosPersonales.Location = new System.Drawing.Point(4, 22);
            this.tabDatosPersonales.Name = "tabDatosPersonales";
            this.tabDatosPersonales.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosPersonales.Size = new System.Drawing.Size(836, 366);
            this.tabDatosPersonales.TabIndex = 1;
            this.tabDatosPersonales.Text = "Datos Personales";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 70);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(26, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 141);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Location = new System.Drawing.Point(190, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 141);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gold;
            this.panel5.Location = new System.Drawing.Point(352, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(123, 141);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Location = new System.Drawing.Point(517, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(123, 141);
            this.panel6.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gold;
            this.panel7.Location = new System.Drawing.Point(684, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(123, 141);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gold;
            this.panel8.Location = new System.Drawing.Point(684, 193);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(123, 141);
            this.panel8.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gold;
            this.panel9.Location = new System.Drawing.Point(517, 193);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(123, 141);
            this.panel9.TabIndex = 4;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gold;
            this.panel10.Location = new System.Drawing.Point(352, 193);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(123, 141);
            this.panel10.TabIndex = 5;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Gold;
            this.panel11.Location = new System.Drawing.Point(190, 193);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(123, 141);
            this.panel11.TabIndex = 6;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Gold;
            this.panel12.Location = new System.Drawing.Point(26, 193);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(123, 141);
            this.panel12.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Comprar entradas aqui:";
            // 
            // tabAsientos
            // 
            this.tabAsientos.Location = new System.Drawing.Point(4, 22);
            this.tabAsientos.Name = "tabAsientos";
            this.tabAsientos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsientos.Size = new System.Drawing.Size(836, 366);
            this.tabAsientos.TabIndex = 2;
            this.tabAsientos.Text = "Asientos";
            this.tabAsientos.UseVisualStyleBackColor = true;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.BackgroundImage = global::Indice.Properties.Resources.MarcoDeCine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1248, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabGeneral);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.tabInicio.ResumeLayout(false);
            this.tabDatosPersonales.ResumeLayout(false);
            this.tabDatosPersonales.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnComprarEntrada;
        private System.Windows.Forms.Button btnVerPeliculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabDatosPersonales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabAsientos;
    }
}