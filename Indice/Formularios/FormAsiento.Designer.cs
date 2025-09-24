namespace Indice.Formularios
{
    partial class FormAsiento
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
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panelAsientos = new System.Windows.Forms.Panel();
            this.ptrExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptrExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("NSimSun", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(530, 458);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(125, 46);
            this.btnConfirmar.TabIndex = 0;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // panelAsientos
            // 
            this.panelAsientos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelAsientos.Location = new System.Drawing.Point(55, 23);
            this.panelAsientos.Name = "panelAsientos";
            this.panelAsientos.Size = new System.Drawing.Size(600, 400);
            this.panelAsientos.TabIndex = 1;
            // 
            // ptrExit
            // 
            this.ptrExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptrExit.Image = global::Indice.Properties.Resources.Exit;
            this.ptrExit.Location = new System.Drawing.Point(55, 458);
            this.ptrExit.Name = "ptrExit";
            this.ptrExit.Size = new System.Drawing.Size(51, 46);
            this.ptrExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptrExit.TabIndex = 2;
            this.ptrExit.TabStop = false;
            this.ptrExit.Click += new System.EventHandler(this.ptrExit_Click);
            // 
            // FormAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(698, 541);
            this.Controls.Add(this.ptrExit);
            this.Controls.Add(this.panelAsientos);
            this.Controls.Add(this.btnConfirmar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAsiento";
            this.Text = "FormAsiento";
            this.Load += new System.EventHandler(this.FormAsiento_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ptrExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Panel panelAsientos;
        private System.Windows.Forms.PictureBox ptrExit;
    }
}