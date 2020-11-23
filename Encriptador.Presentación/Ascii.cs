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
    public partial class Ascii : Form
    {
        listaASCII claseLCDE = new listaASCII();

        public Ascii()
        {
            InitializeComponent();
            for (int i = 1; i <= 127; i++)
            {
                claseLCDE.agregarAlFinal(new claseNodoAscii(i, Convert.ToChar(i)));
            }

            foreach (claseNodoAscii nodo in claseLCDE.listar())
            {
                Console.WriteLine(" " + nodo.Valor + " " + nodo.Caracter + "\n");
            }
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalabraEncriptar.Text;
            string palabraEncriptada = "";
            string codigoEncriptado = null;

            for (int i = 0; i < palabra.Length; i++)
            {
                palabraEncriptada = palabraEncriptada + claseLCDE.buscarEncriptar(palabra[i]).Caracter;

                int codigo = claseLCDE.buscarEncriptar(palabra[i]).Valor;

                if (codigo < 1)
                {
                    MessageBox.Show(palabra[i] + " No pertene ASCII");
                }
                else if (codigo <= 9)
                {
                    codigoEncriptado = codigoEncriptado + "00" + codigo;
                }
                else if (codigo < 100)
                {
                    codigoEncriptado = codigoEncriptado + 0 + codigo;
                }
                else
                {
                    codigoEncriptado = codigoEncriptado + codigo;
                }
            }

            txtPalabra.Text = palabraEncriptada;
            txtCodigo.Text = codigoEncriptado;
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

        private void chkCodigo_CheckedChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            string palabraDesencriptada = "";

            if (chkPalabra.Checked)
            {
                string palabraEncriptada = txtPalabraDesencriptar.Text;
                for (int i = 0; i < palabraEncriptada.Length; i++)
                {
                    palabraDesencriptada = palabraDesencriptada + claseLCDE.buscarDesencriptar(palabraEncriptada[i]).Caracter;
                }
               // txtPalabraDesencriptada.Text = palabraDesencriptada;
            }
            else if (chkCodigo.Checked)
            {
                string codigoEncriptado = txtCodigoDesencriptar.Text;

                string codigo = string.Empty;

                for (int i = 0; i < codigoEncriptado.Length; i++)
                {
                    codigo = codigo + codigoEncriptado[i];

                    if (codigo.Length >= 3)
                    {
                        palabraDesencriptada = palabraDesencriptada + claseLCDE.buscarDesencriptar((char)int.Parse(codigo)).Caracter;
                        codigo = string.Empty;
                    }
                }
            }
            else
            {
                MessageBox.Show("Opción invalida");
            }
            txtPalabraDesencriptada.Text = palabraDesencriptada;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Dispose();
            form1.Show();
        }

        private void btnCLSEncriptar_Click(object sender, EventArgs e)
        {
            txtPalabra.Clear();
            txtCodigo.Clear();
            txtPalabraEncriptar.Clear();
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

