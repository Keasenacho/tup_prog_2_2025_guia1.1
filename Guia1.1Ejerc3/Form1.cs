using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        Peaje peaje = new Peaje();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrarPeaje_Click(object sender, EventArgs e)
        {
            Resumen ResumenPeaje = new Resumen();

            if (ResumenPeaje.ShowDialog() == DialogResult.OK)
            {
                int dia =Convert.ToInt32(ResumenPeaje.tbDias.Text);
                int cantidadVehiculos = Convert.ToInt32(ResumenPeaje.tbCantidadAutos.Text);

                peaje.RegistrarResumenDia(dia, cantidadVehiculos);
            }
        }

        private void btnVerResumen_Click(object sender, EventArgs e)
        {
            lbVerResumen.Items.Clear();
            lbVerResumen.Items.Add("Los días en que ingresaron más autos que el promedio en el mes:");
            int[] dias = peaje.CalcularLosDiasMayoresAlPromedio(out int cantDias);

            for (int n = 0; n < cantDias; n++)
            {
                lbVerResumen.Items.Add($"{dias[n]} (cantidad: {peaje.VerCantidadDeAutosEnUnDia(dias[n])})");
            }

            lbVerResumen.Items.Add("¿Cuál de los tercios del mes tuvo mayor movimiento?");
            int tercio = peaje.CalcularTercioDelMesMayor();

            lbVerResumen.Items.Add(tercio);
        }
    }
   }

