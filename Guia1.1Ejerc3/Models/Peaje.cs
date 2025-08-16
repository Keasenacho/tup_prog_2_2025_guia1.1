using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Peaje
    {
        int[] Cantidades;


        public Peaje()
        {
            Cantidades = new int[31];

            for (int n = 0; n < 31; n++)
                Cantidades[n] = 0;
          
        }
        public double PromCantVehiculosDelMes
        { 
            get
            {
                int acum = 0;
                for (int n = 0; n < 31; n++)
                    acum += Cantidades[n];
                return acum / 31d;
            }
        }
        public int VerCantidadDeAutosEnUnDia(int dia)
        {
            if (dia >= 1 && dia <= 31)
                return Cantidades[dia - 1];
            return -1;

        }
        public void RegistrarResumenDia(int dia,int CantidadVehiculos) 
        {

            if (dia >= 1 && dia <= 31)
           Cantidades[dia - 1] = CantidadVehiculos;

        }
        public int[] CalcularLosDiasMayoresAlPromedio(out int CantDias)
        {
            CantDias = 0;
            double promedio = PromCantVehiculosDelMes;
            int[] dias=new int[31];
            for (int n = 0;n < 31; n++)
            {
                if (Cantidades[n] > promedio)
                {

                    dias[CantDias++] = n + 1;
                }

            }
            return dias;

        }
        public int CalcularTercioDelMesMayor()
        {
            int t1 = 0, t2 = 0, t3 = 0;

            for (int i = 0; i < 31; i++)
            {
                if (i < 10) t1 += Cantidades[i];      
                else if (i < 20) t2 += Cantidades[i]; 
                else t3 += Cantidades[i];             
            }
            if (t1 > t2 && t1 > t3) return 1;
            if (t2 > t1 && t2 > t3) return 2;
            if (t3 > t1 && t3 > t2) return 3;
            return 0; 
        }
    }

    
}









