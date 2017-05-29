using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATENCION_DE_PROCESOS_LISTAS
{
    class Lista_Circular
    {
        private Proceso _inicio;
        public Proceso Inicio { get { return _inicio; } }

        private Proceso _ultimo;
        public Proceso Ultimo { get { return _ultimo; } }

        private int _cont;
        public int cont { get { return _cont; } }

        private int _ciclosPendientes;
        public int CiclosPendientes { get { return _ciclosPendientes; } }



        public void Agregar(Proceso nuevo)
        {
            if (_inicio == null)
            {
                _inicio = nuevo;
                nuevo.Siguiente = _inicio;
                nuevo.Anterior = _inicio;
            }
            else
            {
                nuevo.Siguiente = _inicio;
                nuevo.Anterior = _ultimo;

                _ultimo.Siguiente = nuevo;
                _inicio.Anterior = nuevo;
            }
            _ultimo = nuevo;
            _cont++;
        }

        public void Eliminar(Proceso proceso)
        {
            Proceso temp = null;
            bool encontrado = false;

            if (_inicio != null)
            {
                if (proceso == _inicio)
                    EliminarPrimero();
                else if (proceso == _ultimo)
                    EliminarUltimo();
                else
                {
                    temp = _inicio.Siguiente;

                    while (temp != _inicio && encontrado != true && temp != null)
                    {
                        if (temp.Siguiente == proceso)
                        {
                            temp.Siguiente = proceso.Siguiente;
                            proceso.Siguiente.Anterior = temp;
                            encontrado = true;
                            _cont--;
                        }
                        temp = temp.Siguiente;
                    }
                }
            }
        }


        public void EliminarPrimero()
        {
            if (Inicio != null)
            {
                if (_inicio == _ultimo)
                {
                    _inicio = null;
                    _ultimo = null;
                }
                else
                {
                    _ultimo.Siguiente = _inicio.Siguiente;
                    _inicio = Inicio.Siguiente;
                    _inicio.Anterior = _ultimo;
                }
                _cont--;
            }
        }

        public void EliminarUltimo()
        {
            if (Inicio != null)
            {
                if (_inicio == _ultimo)
                {
                    _inicio = null;
                    _ultimo = null;
                }
                else
                {
                    _inicio.Anterior = _ultimo.Anterior;
                    _ultimo = _ultimo.Anterior;
                    _ultimo.Siguiente = _inicio;
                }
                _cont--;
            }
        }

        public Proceso Actual()
        {
            return _inicio;
        }

        public void moverAsiguiente()
        {
            _inicio = _inicio.Siguiente;
        }


        public override string ToString()
        {
            string cadena = "";
            _ciclosPendientes = 0;

            Proceso temp = _inicio;

            while (temp != _ultimo)
            {
                cadena += temp.ToString();
                _ciclosPendientes += temp.VidaRestante;

                temp = temp.Siguiente;
            }
            cadena += _ultimo.ToString();
            _ciclosPendientes += _ultimo.VidaRestante;

            return cadena;
        }
    }
}
