﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Encriptador.Entidades;

namespace Encriptador.Presentación
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnAscii_Click(object sender, EventArgs e)
        {
            Ascii ascii = new Ascii();
            ascii.Show();
            this.Hide();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUnicode_Click(object sender, EventArgs e)
        {
            Unicode unicode = new Unicode();
            unicode.Show();
            this.Hide();
            

        }
    }
        
}
