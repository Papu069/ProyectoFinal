namespace Indice.Formularios
{
    partial class FormPago
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
            this.btnPagar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.rbtEfectivo = new System.Windows.Forms.RadioButton();
            this.rbtTarjeta = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpTarjeta = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.grpTarjeta.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPagar.Location = new System.Drawing.Point(499, 315);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(112, 50);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 23);
            this.txtNombre.TabIndex = 0;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(8, 21);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(166, 23);
            this.txtCI.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(8, 22);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(166, 23);
            this.txtTelefono.TabIndex = 2;
            // 
            // rbtEfectivo
            // 
            this.rbtEfectivo.AutoSize = true;
            this.rbtEfectivo.Checked = true;
            this.rbtEfectivo.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEfectivo.ForeColor = System.Drawing.SystemColors.Info;
            this.rbtEfectivo.Location = new System.Drawing.Point(40, 129);
            this.rbtEfectivo.Name = "rbtEfectivo";
            this.rbtEfectivo.Size = new System.Drawing.Size(81, 21);
            this.rbtEfectivo.TabIndex = 3;
            this.rbtEfectivo.TabStop = true;
            this.rbtEfectivo.Text = "Efectivo";
            this.rbtEfectivo.UseVisualStyleBackColor = true;
            this.rbtEfectivo.CheckedChanged += new System.EventHandler(this.rbtEfectivo_CheckedChanged);
            // 
            // rbtTarjeta
            // 
            this.rbtTarjeta.AutoSize = true;
            this.rbtTarjeta.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtTarjeta.ForeColor = System.Drawing.SystemColors.Info;
            this.rbtTarjeta.Location = new System.Drawing.Point(40, 170);
            this.rbtTarjeta.Name = "rbtTarjeta";
            this.rbtTarjeta.Size = new System.Drawing.Size(75, 21);
            this.rbtTarjeta.TabIndex = 4;
            this.rbtTarjeta.Text = "Tarjeta";
            this.rbtTarjeta.UseVisualStyleBackColor = true;
            this.rbtTarjeta.CheckedChanged += new System.EventHandler(this.rbtTarjeta_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(19, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Método de pago: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.lblTotal.Location = new System.Drawing.Point(496, 286);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 15);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grpTarjeta);
            this.groupBox1.Controls.Add(this.btnCancelarCompra);
            this.groupBox1.Controls.Add(this.btnPagar);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.rbtTarjeta);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.rbtEfectivo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 384);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // grpTarjeta
            // 
            this.grpTarjeta.Controls.Add(this.dateTimePicker1);
            this.grpTarjeta.Controls.Add(this.textBox4);
            this.grpTarjeta.Controls.Add(this.label5);
            this.grpTarjeta.Controls.Add(this.label4);
            this.grpTarjeta.Controls.Add(this.textBox2);
            this.grpTarjeta.Controls.Add(this.label2);
            this.grpTarjeta.Controls.Add(this.textBox1);
            this.grpTarjeta.Controls.Add(this.label1);
            this.grpTarjeta.ForeColor = System.Drawing.SystemColors.Window;
            this.grpTarjeta.Location = new System.Drawing.Point(185, 96);
            this.grpTarjeta.Name = "grpTarjeta";
            this.grpTarjeta.Size = new System.Drawing.Size(267, 269);
            this.grpTarjeta.TabIndex = 12;
            this.grpTarjeta.TabStop = false;
            this.grpTarjeta.Text = "Datos de tarjeta";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(38, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 26);
            this.textBox4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "cvv";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "fecha de expiracion";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 126);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 26);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre del titular";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "numero de tarjeta";
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCancelarCompra.Location = new System.Drawing.Point(16, 315);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(112, 50);
            this.btnCancelarCompra.TabIndex = 10;
            this.btnCancelarCompra.Text = "Cancelar";
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            this.btnCancelarCompra.Click += new System.EventHandler(this.btnCancelarCompra_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTelefono);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox4.Location = new System.Drawing.Point(431, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 51);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Teléfono";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCI);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Location = new System.Drawing.Point(223, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 51);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Location = new System.Drawing.Point(16, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 51);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre";
            // 
            // FormPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(656, 409);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPago";
            this.Load += new System.EventHandler(this.FormPago_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpTarjeta.ResumeLayout(false);
            this.grpTarjeta.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.RadioButton rbtEfectivo;
        private System.Windows.Forms.RadioButton rbtTarjeta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.GroupBox grpTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}