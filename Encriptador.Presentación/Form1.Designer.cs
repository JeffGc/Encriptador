namespace Encriptador.Presentación
{
    partial class Form1
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
            this.btnUnicode = new System.Windows.Forms.Button();
            this.btnAscii = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.btnUnicode);
            this.panel1.Controls.Add(this.btnAscii);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 498);
            this.panel1.TabIndex = 0;
            // 
            // btnUnicode
            // 
            this.btnUnicode.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUnicode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUnicode.FlatAppearance.BorderSize = 2;
            this.btnUnicode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnicode.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnicode.Location = new System.Drawing.Point(117, 345);
            this.btnUnicode.Name = "btnUnicode";
            this.btnUnicode.Size = new System.Drawing.Size(929, 125);
            this.btnUnicode.TabIndex = 2;
            this.btnUnicode.Text = "Unicode";
            this.btnUnicode.UseVisualStyleBackColor = false;
            this.btnUnicode.Click += new System.EventHandler(this.btnUnicode_Click);
            // 
            // btnAscii
            // 
            this.btnAscii.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAscii.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAscii.FlatAppearance.BorderSize = 2;
            this.btnAscii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAscii.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAscii.Location = new System.Drawing.Point(117, 155);
            this.btnAscii.Name = "btnAscii";
            this.btnAscii.Size = new System.Drawing.Size(929, 125);
            this.btnAscii.TabIndex = 1;
            this.btnAscii.Text = "Ascii";
            this.btnAscii.UseVisualStyleBackColor = false;
            this.btnAscii.Click += new System.EventHandler(this.btnAscii_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(951, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el tipo de encriptado";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatAppearance.BorderSize = 2;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(129, 552);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(929, 125);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1157, 737);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUnicode;
        private System.Windows.Forms.Button btnAscii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
    }
}

