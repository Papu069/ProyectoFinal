namespace Indice.Formularios
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptrNuevoAdmin = new System.Windows.Forms.PictureBox();
            this.ptrExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngrearIndice = new System.Windows.Forms.Button();
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptrNuevoAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.ptrNuevoAdmin);
            this.panel1.Controls.Add(this.ptrExit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(202, 341);
            this.panel1.TabIndex = 0;
            // 
            // ptrNuevoAdmin
            // 
            this.ptrNuevoAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptrNuevoAdmin.Image = global::Indice.Properties.Resources.NuevoUsuario;
            this.ptrNuevoAdmin.Location = new System.Drawing.Point(3, 3);
            this.ptrNuevoAdmin.Name = "ptrNuevoAdmin";
            this.ptrNuevoAdmin.Size = new System.Drawing.Size(66, 67);
            this.ptrNuevoAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrNuevoAdmin.TabIndex = 5;
            this.ptrNuevoAdmin.TabStop = false;
            this.ptrNuevoAdmin.Click += new System.EventHandler(this.ptrNuevoAdmin_Click);
            // 
            // ptrExit
            // 
            this.ptrExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptrExit.Image = global::Indice.Properties.Resources.Exit;
            this.ptrExit.Location = new System.Drawing.Point(3, 302);
            this.ptrExit.Name = "ptrExit";
            this.ptrExit.Size = new System.Drawing.Size(42, 36);
            this.ptrExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrExit.TabIndex = 1;
            this.ptrExit.TabStop = false;
            this.ptrExit.Click += new System.EventHandler(this.ptrExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Indice.Properties.Resources.Cine_icono;
            this.pictureBox1.Location = new System.Drawing.Point(57, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsuario.Font = new System.Drawing.Font("Candara Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtUsuario.Location = new System.Drawing.Point(261, 112);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(344, 32);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "USUARIO";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Candara Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtPassword.Location = new System.Drawing.Point(261, 171);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(344, 32);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "CONTRASEÑA";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(397, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // btnIngrearIndice
            // 
            this.btnIngrearIndice.BackColor = System.Drawing.Color.Gold;
            this.btnIngrearIndice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngrearIndice.Enabled = false;
            this.btnIngrearIndice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngrearIndice.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngrearIndice.Location = new System.Drawing.Point(261, 228);
            this.btnIngrearIndice.Name = "btnIngrearIndice";
            this.btnIngrearIndice.Size = new System.Drawing.Size(344, 46);
            this.btnIngrearIndice.TabIndex = 3;
            this.btnIngrearIndice.Text = "INGRESAR";
            this.btnIngrearIndice.UseVisualStyleBackColor = false;
            this.btnIngrearIndice.Click += new System.EventHandler(this.btnIngrearIndice_Click);
            // 
            // linkHelp
            // 
            this.linkHelp.AutoSize = true;
            this.linkHelp.LinkColor = System.Drawing.Color.Olive;
            this.linkHelp.Location = new System.Drawing.Point(369, 302);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.Size = new System.Drawing.Size(133, 13);
            this.linkHelp.TabIndex = 4;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "He olvidado mi contraseña";
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(669, 341);
            this.Controls.Add(this.linkHelp);
            this.Controls.Add(this.btnIngrearIndice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptrNuevoAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptrExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIngrearIndice;
        private System.Windows.Forms.PictureBox ptrExit;
        private System.Windows.Forms.PictureBox ptrNuevoAdmin;
        private System.Windows.Forms.LinkLabel linkHelp;
    }
}