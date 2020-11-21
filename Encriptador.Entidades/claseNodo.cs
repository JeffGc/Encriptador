using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encriptador.Entidades
{
    public class claseNodo
    {
        private int _valor;
        private char _caracter;

        private claseNodo _siguiente;
        private claseNodo _anterior;

        public int Valor { get => _valor; set => _valor = value; }
        public char Caracter { get => _caracter; set => _caracter = value; }
        public claseNodo Siguiente { get => _siguiente; set => _siguiente = value; }
        public claseNodo Anterior { get => _anterior; set => _anterior = value; }

        public claseNodo()
        {
        }
        public claseNodo(int valor, char caracter)
        {
            Valor = valor;
            Caracter = caracter;
        }

        public claseNodo(int valor, char caracter, claseNodo siguiente, claseNodo anterior)
        {
            Valor = valor;
            Caracter = caracter;
            Siguiente = siguiente;
            Anterior = anterior;
        }
    }
}
