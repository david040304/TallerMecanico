using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Reparacion
    {
        public string Id {  get; set; }
        public Trabajador TrabajadorEncargado { get; set; }
        public Coche CocheReparado { get; set; }
        public string FechaReparacion { get; set; }
        public string TipoReparacion { get; set; }
        public decimal CostoReparacion { get; set; }
        public string EstadoCocheDespuesReparacion { get; set; }
        
        public Reparacion()
        {

        }
        public Reparacion(string id, Trabajador trabajadorEncargado, Coche cocheReparado, string fechaReparacion, string tipoReparacion, decimal costoReparacion, string estadoCocheDespuesReparacion)
        {
            Id = id;
            TrabajadorEncargado = trabajadorEncargado;
            CocheReparado = cocheReparado;
            FechaReparacion = fechaReparacion;
            TipoReparacion = tipoReparacion;
            CostoReparacion = costoReparacion;
            EstadoCocheDespuesReparacion = estadoCocheDespuesReparacion;
        }
        public Reparacion(string linea)
        {
            Id = linea.Split(';')[0];
            TrabajadorEncargado.Nombre = linea.Split(';')[1];
            CocheReparado.Matricula = linea.Split(';')[2];
            FechaReparacion = linea.Split(';')[3];
            TipoReparacion = linea.Split(';')[4];
            CostoReparacion =decimal.Parse(linea.Split(';')[5]);
            EstadoCocheDespuesReparacion = linea.Split(';')[6];
        }
        public string Linea()
        {
            return Id + " - " + TrabajadorEncargado.Nombre + " - " + CocheReparado.Matricula + " - " + FechaReparacion + " - " + TipoReparacion +" - "+CostoReparacion + " - " +EstadoCocheDespuesReparacion;
        }
    }
}
