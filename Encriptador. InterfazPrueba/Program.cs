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
        public static System.Text.UnicodeEncoding All { get; }

        static void Main(string[] args)
        {

            //listaASCII claseLCDE = new listaASCII();


            //for (int i = 32; i <= 126; i++)
            //{
            //    claseLCDE.agregarAlFinal(new claseNodo(i, Convert.ToChar(i)));
            //}

            //foreach (claseNodo nodo in claseLCDE.listar())
            //{
            //    Console.WriteLine(" " + nodo.Valor + " " + nodo.Caracter + "\n");
            //}
            //Console.ReadKey();

            //int total = 0;
            //for (int i = 127; i >= 1; i--)
            //{
            //    total += i;
            //}

            //Console.WriteLine(total);


            //claseNodo nodo2 = claseLCDE.buscarEncriptar('!');
            //Console.WriteLine(nodo2.Caracter + " " + nodo2.Valor);


            //Console.WriteLine(nodo2.Valor + "  " + nodo2.Caracter);

            //claseNodo nodo3 = claseLCDE.buscarDesencriptar(nodo2.Caracter);
            //Console.WriteLine(nodo3.Valor + "  " + nodo3.Caracter);

            void PrintChars(string s)
            {
                Console.WriteLine($"\"{s}\".Length = {s.Length}");
                for (int i = 0; i < s.Length; i++)
                {
                    Console.WriteLine((int)s[i]);
                    Console.WriteLine($"s[{i}] = '{s[i]}' ('\\u{(int)s[i]:x4}')");
                }
                Console.WriteLine();
            }

            listaUNICODE claseUnicode = new listaUNICODE();
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            for (int i = 1; i <= 65535; i++)
            {
                string hex = $"u{i:x4}";

                claseUnicode.agregarAlFinal(new nodoUnicode(hex, Convert.ToChar(i)));
                
                
            }

            foreach (nodoUnicode nodo in claseUnicode.listar())
            {
                Console.WriteLine(" " + nodo.Valor + " " + nodo.Caracter + "\n");
            }

           
           
            //void PrintChars(string s)
            //{
            //    Console.WriteLine($"\"{s}\".Length = {s.Length}");
            //    for (int i = 0; i <= 65535; i++)
            //    {
            //        //Console.WriteLine((int)s[i]);
            //       // Console.WriteLine($"\\u{i:x4}");
            //        string hex = $"\\u{i:x4}";
            //        Console.WriteLine(hex + " " + (char)i);

            //    }
            //    Console.WriteLine();
            //}

            //string ConvertHexToString(string hex)
            //{
            //    int numberChars = hex.Length;
            //    byte[] bytes = new byte[numberChars / 2];
            //    for (int i = 0; i < numberChars; i += 2)
            //    {
            //        bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            //    }

            //    return Encoding.UTF8.GetString(bytes);
            //}

            //PrintChars("Jefferson");
            //string input = "uffec";
            //string word = input.Replace("u", string.Empty);
            //string a = ConvertHexToString(word);

            //Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
