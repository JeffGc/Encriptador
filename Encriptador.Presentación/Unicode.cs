using System;
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
   
    public partial class Unicode : Form
    {
        //listaUNICODE claseLCDE = new listaUNICODE();
        listaUNICODE claseUnicode = new listaUNICODE();

        public Unicode()
        {
            InitializeComponent();
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            for (int i = 1; i <= 65535; i++)
            {
                string hex = $"u{i:x4}";

                claseUnicode.agregarAlFinal(new claseNodoUnicode(hex, Convert.ToChar(i)));
            }
            foreach (claseNodoUnicode nodo in claseUnicode.listar())
            {
                Console.WriteLine(nodo.Valor + " " + nodo.Caracter + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Dispose();
            form1.Show();
        }

        private void btnCLSEncriptar_Click(object sender, EventArgs e)
        {
            txtPalabraEncriptar.Clear();
            txtCodigo.Clear();
            txtPalabra.Clear();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabraEncriptar.Text;
            string palabraEncriptada = "";
            string codigoEncriptado = "";

            for (int i = 0; i < palabra.Length; i++)
            {
                
                palabraEncriptada = palabraEncriptada + claseUnicode.buscarEncriptar(palabra[i]).Caracter;

                codigoEncriptado = codigoEncriptado + claseUnicode.buscarEncriptar(palabra[i]).Valor;
            }

            txtPalabra.Text = palabraEncriptada;
            txtCodigo.Text = codigoEncriptado;
        }

        private void btnDesencriptar_Click(object sender, EventArgs e)
        {
            string palabraDesencriptada = "";


            if (chkPalabra.Checked)
            {
                string palabraEncriptada = txtPalabraDesencriptar.Text;
                for (int i = 0; i < palabraEncriptada.Length; i++)
                {                    
                    palabraDesencriptada = palabraDesencriptada + claseUnicode.buscarDesencriptar(palabraEncriptada[i]).Caracter;
                }
                txtPalabraDesencriptada.Text = palabraDesencriptada;
            }
            else if (chkCodigo.Checked)
            {
                string codigoEncriptado = txtCodigoDesencriptar.Text;

                string codigo = string.Empty;

                for (int i = 0; i < codigoEncriptado.Length; i++)
                {
                    codigo = codigo + codigoEncriptado[i];

                    if (codigo.Length >= 5)
                    {
                        palabraDesencriptada = palabraDesencriptada + claseUnicode.buscarDesencriptar(codigo).Caracter;
                        codigo = string.Empty;
                    }

                }

            }
            txtPalabraDesencriptada.Text = palabraDesencriptada;
        }

        private void chkPalabra_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkPalabra.Checked)
            {
                chkCodigo.Checked = false;
                txtPalabraDesencriptar.Enabled = true;
                txtCodigoDesencriptar.Enabled = false;
                txtCodigoDesencriptar.Clear();
            }
            else
            {
                txtPalabraDesencriptar.Clear();
                txtPalabraDesencriptar.Enabled = false;
            }
        }

        private void chkCodigo_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkCodigo.Checked)
            {
                chkPalabra.Checked = false;
                txtCodigoDesencriptar.Enabled = true;
                txtPalabraDesencriptar.Enabled = false;
                txtPalabraDesencriptar.Clear();
            }
            else
            {
                txtCodigoDesencriptar.Clear();
                txtCodigoDesencriptar.Enabled = false;
            }
        }

        private void btnCLSDesencriptar_Click(object sender, EventArgs e)
        {
            txtCodigoDesencriptar.Clear();
            txtPalabraDesencriptar.Clear();
            txtPalabraDesencriptada.Clear();
            chkCodigo.Checked = false;
            chkPalabra.Checked = false;
        }
    }
}
