using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encriptador.Entidades
{
    public class listaASCII
    {
        private claseNodo _inicio;

        private claseNodo _final;

        private int _tamano;

        private List<claseNodo> lista = new List<claseNodo>();

        public listaASCII()
        {
        }

        public listaASCII(claseNodo inicio, claseNodo final, int tamano)
        {
            _inicio = inicio;
            _final = final;
            _tamano = tamano;
        }

        public bool esVacia()
        {
            return _inicio == null;
        }

        public void agregarAlFinal(claseNodo nodoNuevo)
        {
            // Define un nuevo nodo.
            claseNodo nodo = new claseNodo();

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

        public List<claseNodo> listar()
        {
            // Verifica si la lista contiene elementoa.
            if (!esVacia())
            {
                // Crea una copia de la lista.
                claseNodo aux = _inicio;
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

        public claseNodo buscarEncriptar(char caracter)
        {
            claseNodo nodoRetorno = new claseNodo();

            foreach (claseNodo nodo in lista)
            {
                if (nodo.Caracter.Equals(caracter))
                {
                    claseNodo nodoEncontrado = nodo;
                    for (int i = 1; i <= (int)Math.Pow(63, 2); i++)
                    {
                        for (int j = 333; j >= 1; j--)
                        {
                            nodoRetorno = nodoEncontrado;
                            nodoEncontrado = nodoEncontrado.Siguiente;
                        }
                    }
                    return nodoRetorno;
                }
            }
            return nodoRetorno;
        }

        public claseNodo buscarDesencriptar(char caracter)
        {
            claseNodo nodoRetorno = new claseNodo();
            foreach (claseNodo nodo in lista)
            {
                if (nodo.Caracter.Equals(caracter))
                {
                    claseNodo nodoEncontrado = nodo;
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
