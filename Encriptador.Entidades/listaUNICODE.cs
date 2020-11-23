using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encriptador.Entidades
{
    public class listaUNICODE
    {
        private claseNodoUnicode _inicio;

        private claseNodoUnicode _final;

        private int _tamano;

        private List<claseNodoUnicode> lista = new List<claseNodoUnicode>();

        public listaUNICODE()
        {
        }

        public listaUNICODE(claseNodoUnicode inicio, claseNodoUnicode final)
        {
            _inicio = inicio;
            _final = final;
        }

        public bool esVacia()
        {
            return _inicio == null;
        }

        public void agregarAlFinal(claseNodoUnicode nodoNuevo)
        {
            // Define un nuevo nodo.
            claseNodoUnicode nodo = new claseNodoUnicode();

            // Consulta si la lista esta vacia.
            if (esVacia())
            {
                // Inicializa la lista agregando como inicio al nuevo nodo.
                _inicio = nodoNuevo;
                // El ultimo nodo sera el nuevo.
                _final = nodoNuevo;

                _inicio.Siguiente = _final;

                _inicio.Anterior = _final;

                _final.Siguiente = _inicio;

                _final.Anterior = _inicio;
            }
            else
            {
                _final.Siguiente = nodoNuevo;

                nodoNuevo.Siguiente = _inicio;

                _inicio.Anterior = nodoNuevo;

                nodoNuevo.Anterior = _final;

                _final = nodoNuevo;

            }
            // Incrementa el contador de tamaño de la lista
            _tamano++;
        }

        public List<claseNodoUnicode> listar()
        {
            // Verifica si la lista contiene elementoa.
            if (!esVacia())
            {
                // Crea una copia de la lista.
                claseNodoUnicode aux = _inicio;
                // Posicion de los elementos de la lista.
                int i = 1;

                // Recorre la lista 
                do
                {
                    lista.Add(aux);
                    // Avanza al siguiente nodo.
                    aux = aux.Siguiente;
                    // Incrementa el contador de la posión.
                    i++;
                } while (aux != _inicio);
            }

            return lista;
        }

        public claseNodoUnicode buscarEncriptar(char caracter)
        {
            claseNodoUnicode nodoRetorno = new claseNodoUnicode();

            foreach (claseNodoUnicode nodoUnicode in lista)
            {
                if (nodoUnicode.Caracter.Equals(caracter))
                {
                    claseNodoUnicode nodoEncontrado = nodoUnicode;
                    for (int i = 1; i <= (int)Math.Pow(63, 2); i++)
                    {
                        for (int j = 333; j >= 1; j--)
                        {
                            nodoRetorno = nodoEncontrado;
                            nodoEncontrado = nodoEncontrado.Siguiente;
                        }
                    }
                    break;
                }
            }
            return nodoRetorno;
        }

        public claseNodoUnicode buscarDesencriptar(char caracter)
        {
            claseNodoUnicode nodoRetorno = new claseNodoUnicode();
            foreach (claseNodoUnicode nodo in lista)
            {
                if (nodo.Caracter.Equals(caracter))
                {
                    claseNodoUnicode nodoEncontrado = nodo;
                    for (int i = (int)Math.Sqrt(15752961); i >= 1; i--)
                    {
                        for (int j = 333; j >= 1; j--)
                        {
                            nodoRetorno = nodoEncontrado;
                            nodoEncontrado = nodoEncontrado.Anterior;
                        }
                    }
                    break;
                }
            }
            return nodoRetorno;
        }

        public claseNodoUnicode buscarDesencriptar(string caracter)
        {
            
            claseNodoUnicode nodoRetorno = new claseNodoUnicode();
            foreach (claseNodoUnicode nodo in lista)
            {
                if (nodo.Valor == caracter)
                {
                    claseNodoUnicode nodoEncontrado = nodo;
                    for (int i = (int)Math.Sqrt(15752961); i >= 1; i--)
                    {
                        for (int j = 333; j >= 1; j--)
                        {
                            nodoRetorno = nodoEncontrado;
                            nodoEncontrado = nodoEncontrado.Anterior;
                        }
                    }
                    break;
                }
            }
            return nodoRetorno;
        }
    }
}
