using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impresiones
{
    internal class Cola
    {
        public NodoArchivo inicio;
        public NodoArchivo fin;

        public void Insertar(NodoArchivo nombrearchivo)
        {
            if (inicio == null)
            {
                inicio = nombrearchivo;
                fin = nombrearchivo;
            }
            else
            {
                fin.siguiente = nombrearchivo;
                fin = nombrearchivo;
            }
        }
        public void Listar(ListBox lstEspera)
        {
            lstEspera.Items.Clear();
            if (inicio == null) lstEspera.Items.Add("No hay archivos");
            else
            {
                NodoArchivo aux = inicio;
                while (aux != null)
                {
                    lstEspera.Items.Add(aux.nombreArchivo);
                    aux = aux.siguiente;
                }
            }
        }
        public void Eliminar()
        {
            if (inicio != null)
            {
                NodoArchivo aux = inicio;
                inicio = aux.siguiente;
                aux = null;

                if (inicio == null) fin = null;
            }
        }
    }
}
