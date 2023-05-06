using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Coche
    {
        public string Marca { get; set; }
        public string Matricula { get; set; }
        public string Dueño { get; set; }
        public string ProblemaPresentado { get; set; }
        public string FechaReparacion { get; set; }
        public decimal CostoReparacion { get; set; }

        public Coche(string marca, string matricula, string dueño, string problemaPresentado, string fechaReparacion, decimal costoReparacion)
        {
            Marca = marca;
            Matricula = matricula;
            Dueño = dueño;
            ProblemaPresentado = problemaPresentado;
            FechaReparacion = fechaReparacion;
            CostoReparacion = costoReparacion;
        }
        public Coche(string linea)
        { 
            Marca = linea.Split(';')[0];
            Matricula = linea.Split(';')[1];
            Dueño = linea.Split(';')[2];
            ProblemaPresentado = linea.Split(';')[3];
            FechaReparacion = linea.Split(';')[4];
            CostoReparacion =decimal.Parse(linea.Split(';')[5]);
        }

        public Coche()
        {
        }

        public string Linea()
        {
            return Marca + " - " + Matricula + " - " + Dueño + " - " + ProblemaPresentado + " - " + FechaReparacion + " - " + CostoReparacion;
        }
    }
}
