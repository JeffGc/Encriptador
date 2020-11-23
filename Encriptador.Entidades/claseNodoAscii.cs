using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encriptador.Entidades
{
    public class claseNodoAscii
    {
        // Atributos
        private int _valor;
        private char _caracter;

        private claseNodoAscii _siguiente;
        private claseNodoAscii _anterior;

        // Propiedades
        public int Valor { get => _valor; set => _valor = value; }
        public char Caracter { get => _caracter; set => _caracter = value; }
        public claseNodoAscii Siguiente { get => _siguiente; set => _siguiente = value; }
        public claseNodoAscii Anterior { get => _anterior; set => _anterior = value; }

        // Constructores
        public claseNodoAscii()
        {
        }
        public claseNodoAscii(int valor, char caracter)
        {
            Valor = valor;
            Caracter = caracter;
        }

        public claseNodoAscii(int valor, char caracter, claseNodoAscii siguiente, claseNodoAscii anterior)
        {
            Valor = valor;
            Caracter = caracter;
            Siguiente = siguiente;
            Anterior = anterior;
        }
    }
}
