using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATENCION_DE_PROCESOS_LISTAS
{
    public partial class Form1 : Form
    {
        private Lista_Circular listaProcesos;
        private static Random alea = new Random();
        private static Random aleatorio = new Random();
        private int probabilidad;
        private int vidaProceso;
        private int ciclosVacio;
        private int numMayor;
        private int totalAtendidos;
        private string reporte;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            txtCiclosRest.Clear();
            txtNumeroMax.Clear();
            txtProcesoPend.Clear();
            txtProcesosAten.Clear();
            txtReporte.Clear();
            txtVacios.Clear();

            listaProcesos = new Lista_Circular();

            int num = 1;

            Proceso temp = null;

            for (int i = 1; i <= 200; i++)
            {
                reporte += "Ciclo:  " + i + Environment.NewLine;

                probabilidad = alea.Next(1, 12);
                vidaProceso = aleatorio.Next(4, 12);
                if (probabilidad >= 1 && probabilidad <= 3)
                {
                    Proceso nuevo = new Proceso(num++, vidaProceso);
                    listaProcesos.Agregar(nuevo);

                    if (num == 2)
                        temp = listaProcesos.Inicio;

                    totalAtendidos++;
                }

                if (listaProcesos.Actual() != null)
                {

                    if (listaProcesos.Actual().VidaRestante > 0)
                    {
                        listaProcesos.Actual().VidaRestante -= 1;
                        reporte += listaProcesos.Actual().ToString();
                        listaProcesos.moverAsiguiente();
                    }
                    else
                    {
                        reporte += "Proceso: " + listaProcesos.Actual().NumProceso + Environment.NewLine + "Ciclos originales:  Nada" + Environment.NewLine + "Proceso ELIMINADO" + Environment.NewLine;
                        listaProcesos.Eliminar(listaProcesos.Actual());
                    }
                }
                else
                {
                    reporte += "Proceso: Sin proceso" + Environment.NewLine + "Ciclos originales:  Nada" + Environment.NewLine + "Ciclos restantes:   Nada" + Environment.NewLine;
                    ciclosVacio++;
                }

                if (numMayor < listaProcesos.cont)
                {
                    numMayor = listaProcesos.cont;
                }
            }

            txtReporte.Text += reporte;
            txtVacios.Text = ciclosVacio.ToString();
            txtNumeroMax.Text = numMayor.ToString();
            txtProcesoPend.Text = listaProcesos.cont.ToString();
            txtCiclosRest.Text = listaProcesos.CiclosPendientes.ToString();
            txtProcesosAten.Text = totalAtendidos.ToString();
        }
    }
}
