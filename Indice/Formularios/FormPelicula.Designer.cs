namespace Indice.Formularios
{
    partial class FormPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPelicula));
            this.lblNamePelicula = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaEstreno = new System.Windows.Forms.Label();
            this.lblCostoEntrada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.ptrRetroceso2 = new System.Windows.Forms.PictureBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrRetroceso2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNamePelicula
            // 
            this.lblNamePelicula.AutoSize = true;
            this.lblNamePelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePelicula.ForeColor = System.Drawing.SystemColors.Info;
            this.lblNamePelicula.Location = new System.Drawing.Point(12, 106);
            this.lblNamePelicula.Name = "lblNamePelicula";
            this.lblNamePelicula.Size = new System.Drawing.Size(274, 31);
            this.lblNamePelicula.TabIndex = 0;
            this.lblNamePelicula.Text = "Nombre de la pelicula";
            this.lblNamePelicula.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoEllipsis = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDescripcion.Location = new System.Drawing.Point(13, 188);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(469, 161);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblFechaEstreno
            // 
            this.lblFechaEstreno.AutoSize = true;
            this.lblFechaEstreno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEstreno.ForeColor = System.Drawing.SystemColors.Info;
            this.lblFechaEstreno.Location = new System.Drawing.Point(380, 391);
            this.lblFechaEstreno.Name = "lblFechaEstreno";
            this.lblFechaEstreno.Size = new System.Drawing.Size(54, 20);
            this.lblFechaEstreno.TabIndex = 2;
            this.lblFechaEstreno.Text = "Fecha";
            // 
            // lblCostoEntrada
            // 
            this.lblCostoEntrada.AutoSize = true;
            this.lblCostoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoEntrada.ForeColor = System.Drawing.SystemColors.Info;
            this.lblCostoEntrada.Location = new System.Drawing.Point(249, 453);
            this.lblCostoEntrada.Name = "lblCostoEntrada";
            this.lblCostoEntrada.Size = new System.Drawing.Size(51, 20);
            this.lblCostoEntrada.TabIndex = 3;
            this.lblCostoEntrada.Text = "Coste";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 93);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Indice.Properties.Resources.Cine_icono;
            this.pictureBox1.Location = new System.Drawing.Point(195, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.Gold;
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar.Location = new System.Drawing.Point(373, 435);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(98, 56);
            this.btnComprar.TabIndex = 6;
            this.btnComprar.Text = "Comprar entrada";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // ptrRetroceso2
            // 
            this.ptrRetroceso2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptrRetroceso2.Image = global::Indice.Properties.Resources.Retroceso;
            this.ptrRetroceso2.Location = new System.Drawing.Point(33, 435);
            this.ptrRetroceso2.Name = "ptrRetroceso2";
            this.ptrRetroceso2.Size = new System.Drawing.Size(57, 56);
            this.ptrRetroceso2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrRetroceso2.TabIndex = 8;
            this.ptrRetroceso2.TabStop = false;
            this.ptrRetroceso2.Click += new System.EventHandler(this.ptrRetroceso2_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.SystemColors.Info;
            this.lblGenero.Location = new System.Drawing.Point(29, 145);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(63, 20);
            this.lblGenero.TabIndex = 9;
            this.lblGenero.Text = "Género";
            // 
            // FormPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(494, 518);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.ptrRetroceso2);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCostoEntrada);
            this.Controls.Add(this.lblFechaEstreno);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNamePelicula);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPelicula";
            this.Text = "FormPelicula";
            this.Load += new System.EventHandler(this.FormPelicula_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrRetroceso2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNamePelicula;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaEstreno;
        private System.Windows.Forms.Label lblCostoEntrada;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.PictureBox ptrRetroceso2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGenero;
    }
}