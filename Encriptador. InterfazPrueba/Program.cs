using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encriptador.Entidades;


namespace Encriptador.InterfazPrueba
{
    class Program
    {
        static void Main(string[] args)
        {

            listaASCII claseLCDE = new listaASCII();

           
            for (int i = 32; i <= 126; i++)
            {
                claseLCDE.agregarAlFinal(new claseNodo(i, Convert.ToChar(i)));
            }

            foreach (claseNodo nodo in claseLCDE.listar())
            {
                Console.WriteLine(" " + nodo.Valor + " " + nodo.Caracter + "\n");
            }
            Console.ReadKey();

            int total = 0;
            for (int i = 127; i >= 1; i--)
            {
                total += i;
            }

            Console.WriteLine(total);

            Console.ReadKey();
            //claseNodo nodo2 = claseLCDE.buscarEncriptar('!');
            //Console.WriteLine(nodo2.Caracter + " " + nodo2.Valor);

           
            //Console.WriteLine(nodo2.Valor + "  " + nodo2.Caracter);

            //claseNodo nodo3 = claseLCDE.buscarDesencriptar(nodo2.Caracter);
            //Console.WriteLine(nodo3.Valor + "  " + nodo3.Caracter);

            Console.ReadKey();
        }
    }
}
