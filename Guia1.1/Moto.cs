using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Guia1._1
{
    public class Moto
    {
        string Marca { get; set; }

        int Modelo { get; set; }    
        
        double ValorFabricacion { get; set; }   
    
    public Moto (string marca, int modelo, double valorfabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorfabricacion;

        }
        public double CalcularDepreciacionLineal(int AñoAcalcular,int VidaUtil)
        {
            return ValorFabricacion - (ValorFabricacion*(AñoAcalcular-Modelo)/VidaUtil);

        }

        public double CalcularDepreciacionAnual(int AñoAcalcular, double TasaDepreciacion)
        {

            return ValorFabricacion * (Math.Pow(1 - 0.1, AñoAcalcular - Modelo));
        }
        public string VerDescripcion()
        {
            return $"Marca:{Marca}, Modelo:{Modelo}, Valor Fabriación:${ValorFabricacion,10:f2}";
        }
    }

}
