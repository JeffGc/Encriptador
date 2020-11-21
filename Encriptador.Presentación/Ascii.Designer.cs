namespace Encriptador.Presentación
{
    partial class Ascii
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtPalabraEncriptar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncriptar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkCodigo = new System.Windows.Forms.CheckBox();
            this.chkPalabra = new System.Windows.Forms.CheckBox();
            this.txtPalabraDesencriptada = new System.Windows.Forms.TextBox();
            this.btnDesencriptar = new System.Windows.Forms.Button();
            this.txtCodigoDesencriptar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPalabraDesencriptar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCLSEncriptar = new System.Windows.Forms.Button();
            this.btnCLSDesencriptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            // 
            // txtPalabraEncriptar
            // 
            this.txtPalabraEncriptar.Font = new System.Drawing.Font("Consolas", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalabraEncriptar.Location = new System.Drawing.Point(0, 66);
            this.txtPalabraEncriptar.Name = "txtPalabraEncriptar";
            this.txtPalabraEncriptar.Size = new System.Drawing.Size(471, 39);
            this.txtPalabraEncriptar.TabIndex = 0;
            this.txtPalabraEncriptar.TextChanged += new System.EventHandler(this.txtPalabraEncriptar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 114);
            this.label1.TabIndex = 1;
            this.label1.Text = "Encriptador ASCII";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "Palabra a encriptar";
            // 
            // btnEncriptar
            // 
            this.btnEncriptar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEncriptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEncriptar.FlatAppearance.BorderSize = 2;
            this.btnEncriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncriptar.Location = new System.Drawing.Point(12, 332);
            this.btnEncriptar.Name = "btnEncriptar";
            this.btnEncriptar.Size = new System.Drawing.Size(327, 74);
            this.btnEncriptar.TabIndex = 3;
            this.btnEncriptar.Text = "Encriptar";
            this.btnEncriptar.UseVisualStyleBackColor = false;
            this.btnEncriptar.Click += new System.EventHandler(this.btnEncriptar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 51);
            this.label3.TabIndex = 5;
            this.label3.Text = "Codigo encriptado";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(0, 175);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(471, 31);
            this.txtCodigo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 51);
            this.label4.TabIndex = 7;
            this.label4.Text = "Palabra Encriptada";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(0, 277);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.ReadOnly = true;
            this.txtPalabra.Size = new System.Drawing.Size(471, 31);
            this.txtPalabra.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 98);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnCLSEncriptar);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtPalabra);
            this.splitContainer1.Panel1.Controls.Add(this.btnEncriptar);
            this.splitContainer1.Panel1.Controls.Add(this.txtPalabraEncriptar);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtCodigo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.btnCLSDesencriptar);
            this.splitContainer1.Panel2.Controls.Add(this.chkCodigo);
            this.splitContainer1.Panel2.Controls.Add(this.chkPalabra);
            this.splitContainer1.Panel2.Controls.Add(this.txtPalabraDesencriptada);
            this.splitContainer1.Panel2.Controls.Add(this.btnDesencriptar);
            this.splitContainer1.Panel2.Controls.Add(this.txtCodigoDesencriptar);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtPalabraDesencriptar);
            this.splitContainer1.Size = new System.Drawing.Size(1005, 419);
            this.splitContainer1.SplitterDistance = 501;
            this.splitContainer1.TabIndex = 9;
            // 
            // chkCodigo
            // 
            this.chkCodigo.AutoSize = true;
            this.chkCodigo.Location = new System.Drawing.Point(13, 128);
            this.chkCodigo.Name = "chkCodigo";
            this.chkCodigo.Size = new System.Drawing.Size(28, 27);
            this.chkCodigo.TabIndex = 13;
            this.chkCodigo.UseVisualStyleBackColor = true;
            this.chkCodigo.CheckedChanged += new System.EventHandler(this.chkCodigo_CheckedChanged);
            // 
            // chkPalabra
            // 
            this.chkPalabra.AutoSize = true;
            this.chkPalabra.Location = new System.Drawing.Point(13, 33);
            this.chkPalabra.Name = "chkPalabra";
            this.chkPalabra.Size = new System.Drawing.Size(28, 27);
            this.chkPalabra.TabIndex = 12;
            this.chkPalabra.UseVisualStyleBackColor = true;
            this.chkPalabra.CheckStateChanged += new System.EventHandler(this.chkPalabra_CheckStateChanged);
            // 
            // txtPalabraDesencriptada
            // 
            this.txtPalabraDesencriptada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtPalabraDesencriptada.Location = new System.Drawing.Point(3, 277);
            this.txtPalabraDesencriptada.Name = "txtPalabraDesencriptada";
            this.txtPalabraDesencriptada.ReadOnly = true;
            this.txtPalabraDesencriptada.Size = new System.Drawing.Size(471, 38);
            this.txtPalabraDesencriptada.TabIndex = 8;
            // 
            // btnDesencriptar
            // 
            this.btnDesencriptar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnDesencriptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDesencriptar.FlatAppearance.BorderSize = 2;
            this.btnDesencriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesencriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesencriptar.Location = new System.Drawing.Point(15, 332);
            this.btnDesencriptar.Name = "btnDesencriptar";
            this.btnDesencriptar.Size = new System.Drawing.Size(355, 74);
            this.btnDesencriptar.TabIndex = 8;
            this.btnDesencriptar.Text = "Desencriptar";
            this.btnDesencriptar.UseVisualStyleBackColor = false;
            this.btnDesencriptar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCodigoDesencriptar
            // 
            this.txtCodigoDesencriptar.Enabled = false;
            this.txtCodigoDesencriptar.Location = new System.Drawing.Point(3, 175);
            this.txtCodigoDesencriptar.Name = "txtCodigoDesencriptar";
            this.txtCodigoDesencriptar.Size = new System.Drawing.Size(471, 31);
            this.txtCodigoDesencriptar.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(408, 51);
            this.label7.TabIndex = 9;
            this.label7.Text = "Codigo desencriptar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(454, 51);
            this.label6.TabIndex = 11;
            this.label6.Text = "Palabra desencriptada";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 51);
            this.label5.TabIndex = 8;
            this.label5.Text = "Palabra a desencriptar";
            // 
            // txtPalabraDesencriptar
            // 
            this.txtPalabraDesencriptar.Enabled = false;
            this.txtPalabraDesencriptar.Location = new System.Drawing.Point(3, 80);
            this.txtPalabraDesencriptar.Name = "txtPalabraDesencriptar";
            this.txtPalabraDesencriptar.Size = new System.Drawing.Size(471, 31);
            this.txtPalabraDesencriptar.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(339, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(376, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "Menú";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCLSEncriptar
            // 
            this.btnCLSEncriptar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCLSEncriptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCLSEncriptar.FlatAppearance.BorderSize = 2;
            this.btnCLSEncriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLSEncriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLSEncriptar.Location = new System.Drawing.Point(345, 332);
            this.btnCLSEncriptar.Name = "btnCLSEncriptar";
            this.btnCLSEncriptar.Size = new System.Drawing.Size(140, 74);
            this.btnCLSEncriptar.TabIndex = 8;
            this.btnCLSEncriptar.Text = "Borrar";
            this.btnCLSEncriptar.UseVisualStyleBackColor = false;
            this.btnCLSEncriptar.Click += new System.EventHandler(this.btnCLSEncriptar_Click);
            // 
            // btnCLSDesencriptar
            // 
            this.btnCLSDesencriptar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCLSDesencriptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCLSDesencriptar.FlatAppearance.BorderSize = 2;
            this.btnCLSDesencriptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLSDesencriptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnCLSDesencriptar.Location = new System.Drawing.Point(376, 332);
            this.btnCLSDesencriptar.Name = "btnCLSDesencriptar";
            this.btnCLSDesencriptar.Size = new System.Drawing.Size(124, 74);
            this.btnCLSDesencriptar.TabIndex = 9;
            this.btnCLSDesencriptar.Text = "Borrar";
            this.btnCLSDesencriptar.UseVisualStyleBackColor = false;
            this.btnCLSDesencriptar.Click += new System.EventHandler(this.btnCLSDesencriptar_Click);
            // 
            // Ascii
            // 
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1057, 592);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Ascii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPalabraEncriptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncriptar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPalabra;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtPalabraDesencriptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDesencriptar;
        private System.Windows.Forms.TextBox txtCodigoDesencriptar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPalabraDesencriptada;
        private System.Windows.Forms.CheckBox chkCodigo;
        private System.Windows.Forms.CheckBox chkPalabra;
        private System.Windows.Forms.Button btnCLSEncriptar;
        private System.Windows.Forms.Button btnCLSDesencriptar;
    }
}