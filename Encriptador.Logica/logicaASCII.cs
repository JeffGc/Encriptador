using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encriptador.Entidades;

namespace Encriptador.Logica
{
    public class logicaASCII
    {
        claseLCDE claseLCDE = new claseLCDE();
        claseNodo nodo = new claseNodo();

        public char encriptarAsciiCHAR(char caracter) 
        {
            claseNodo a = claseLCDE.buscarEncriptar('!');
            return a.Caracter;
        }
    }
}
