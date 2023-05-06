using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Trabajador
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string FechaNacimiento { get; set; }
        public string TipoTrabajador { get; set; }
        public string Especialidad { get; set; }

        public Trabajador()
        {

        }
        public Trabajador(string cedula, string nombre, string fechanacimiento, string tipoTrabajador, string especialidad) : this(cedula)
        {
            Nombre = nombre;
            FechaNacimiento = fechanacimiento;
            TipoTrabajador = tipoTrabajador;
            Especialidad = especialidad;
        }

        public Trabajador(string linea)
        {
            Cedula = linea.Split(';')[0];
            Nombre = linea.Split(';')[1];
            FechaNacimiento = linea.Split(';')[2];
            TipoTrabajador = linea.Split(';')[3];
            Especialidad = linea.Split(';')[4];
        }
        public string Linea()
        {
            return Cedula + " - " + Nombre + " - " + FechaNacimiento + " - " + TipoTrabajador + " - " + Especialidad;
        }
    }
}
