using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularCosto_Click(object sender, EventArgs e)
        {
            string marca = tbMarca.Text;
            int modelo = Convert.ToInt32(nupModelo.Value);
            int añoACalcular = Convert.ToInt32(nupAño.Value);
            double valorFabrica = Convert.ToDouble(tbValorDeFabricacion.Text);
            int vidaUtil = Convert.ToInt32(tbValorDeFabricacion.Text);
            double tasaDepreciacion = Convert.ToDouble(tbValorDeFabricacion.Text);

            Moto motito = new Moto(marca, modelo, valorFabrica);


            VerResultados fVer = new VerResultados();
            fVer.lbResultados.Items.Add(motito.VerDescripcion());

            double valorLineal = motito.CalcularDepreciacionLineal(añoACalcular, vidaUtil);
            fVer.lbResultados.Items.Add($"Depreciación lineal: ${valorLineal,10:f2}");

            double valorAnual = motito.CalcularDepreciacionAnual(añoACalcular, tasaDepreciacion);
            fVer.lbResultados.Items.Add($"Depreciación anual: ${valorAnual,10:f2}");

            fVer.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nupModelo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
