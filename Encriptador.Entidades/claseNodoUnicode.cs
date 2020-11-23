using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encriptador.Entidades
{
    public class claseNodoUnicode
    {
        // Atributos
        private string _valor;
        private char _caracter;

        private claseNodoUnicode _siguiente;
        private claseNodoUnicode _anterior;

        //Propiedades
        public string Valor { get => _valor; set => _valor = value; }
        public char Caracter { get => _caracter; set => _caracter = value; }
        public claseNodoUnicode Siguiente { get => _siguiente; set => _siguiente = value; }
        public claseNodoUnicode Anterior { get => _anterior; set => _anterior = value; }

        // Contructores
        public claseNodoUnicode()
        {
        }
        public claseNodoUnicode(string valor, char caracter)
        {
            Valor = valor;
            Caracter = caracter;
        }

        public claseNodoUnicode(string valor, char caracter, claseNodoUnicode siguiente, claseNodoUnicode anterior)
        {
            Valor = valor;
            Caracter = caracter;
            Siguiente = siguiente;
            Anterior = anterior;
        }
    }
}
