namespace Indice.Formularios
{
    partial class FormNuevoAdmin
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
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ptrRetroceso = new System.Windows.Forms.PictureBox();
            this.btnConfirmarUsuario = new System.Windows.Forms.Button();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrRetroceso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.dtpFechaNacimiento);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ptrRetroceso);
            this.panel1.Controls.Add(this.btnConfirmarUsuario);
            this.panel1.Controls.Add(this.txtConfPass);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNuevoUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 409);
            this.panel1.TabIndex = 1;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(35, 258);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(257, 23);
            this.dtpFechaNacimiento.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(31, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de nacimiento: ";
            // 
            // ptrRetroceso
            // 
            this.ptrRetroceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptrRetroceso.Image = global::Indice.Properties.Resources.Retroceso;
            this.ptrRetroceso.Location = new System.Drawing.Point(35, 332);
            this.ptrRetroceso.Name = "ptrRetroceso";
            this.ptrRetroceso.Size = new System.Drawing.Size(40, 38);
            this.ptrRetroceso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrRetroceso.TabIndex = 7;
            this.ptrRetroceso.TabStop = false;
            this.ptrRetroceso.Click += new System.EventHandler(this.ptrRetroceso_Click);
            // 
            // btnConfirmarUsuario
            // 
            this.btnConfirmarUsuario.BackColor = System.Drawing.SystemColors.Info;
            this.btnConfirmarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarUsuario.Location = new System.Drawing.Point(131, 332);
            this.btnConfirmarUsuario.Name = "btnConfirmarUsuario";
            this.btnConfirmarUsuario.Size = new System.Drawing.Size(161, 38);
            this.btnConfirmarUsuario.TabIndex = 6;
            this.btnConfirmarUsuario.Text = "Confirmar";
            this.btnConfirmarUsuario.UseVisualStyleBackColor = false;
            this.btnConfirmarUsuario.Click += new System.EventHandler(this.btnConfirmarUsuario_Click);
            // 
            // txtConfPass
            // 
            this.txtConfPass.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtConfPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfPass.ForeColor = System.Drawing.SystemColors.Window;
            this.txtConfPass.Location = new System.Drawing.Point(35, 186);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.Size = new System.Drawing.Size(257, 26);
            this.txtConfPass.TabIndex = 5;
            this.txtConfPass.Enter += new System.EventHandler(this.txtConfPass_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(31, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmar contraseña: ";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPass.Location = new System.Drawing.Point(35, 111);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(257, 26);
            this.txtPass.TabIndex = 3;
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(31, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nueva contraseña: ";
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNuevoUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNuevoUsuario.Location = new System.Drawing.Point(35, 38);
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(257, 26);
            this.txtNuevoUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo usuario: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Indice.Properties.Resources.User_Enigma;
            this.pictureBox1.Location = new System.Drawing.Point(119, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormNuevoAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(328, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNuevoAdmin";
            this.Text = "FormNuevoAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrRetroceso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmarUsuario;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptrRetroceso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
    }
}