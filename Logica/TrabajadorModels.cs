using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Entidades;
using Datos.Repositorios;

namespace Logica
{
    public class TrabajadorModels
    {
       
        //trabajador
        private string cedula;
        private string nombre;
        private string fechaNacimiento;
        private string tipoTrabajador;
        private string especialidad;
        //coche
        private string marca;
        private string matricula;
        private string dueño;
        private string problemaPresentado;
        private string fechaReparacionCoche;
        private decimal costoReparacionCoche;
        //reparacion
        private string id;
        private Trabajador trabajadorEncargado;
        private Coche cocheReparado;
        private string fechaReparacion;
        private string tipoReparacion;
        private decimal costoReparacion;
        private string estadoCocheDespuesReparacion;

        //trabajador
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string TipoTrabajador { get => tipoTrabajador; set => tipoTrabajador = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        //coche
        public string Marca { get => marca; set => marca = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string Dueño { get => dueño; set => dueño = value; }
        public string ProblemaPresentado { get => problemaPresentado; set => problemaPresentado = value; }
        public string FechaReparacionCoche { get => fechaReparacionCoche; set => fechaReparacionCoche = value; }
        public decimal CostoReparacionCoche { get => costoReparacionCoche; set => costoReparacionCoche = value; }
        //reparacion
        public string Id { get => id; set => id = value; }
        public Trabajador TrabajadorEncargado { get => trabajadorEncargado; set => trabajadorEncargado = value; }
        public Coche CocheReparado { get => cocheReparado; set => cocheReparado = value; }
        public string FechaReparacion { get => fechaReparacion; set => fechaReparacion = value; }
        public string TipoReparacion { get => tipoReparacion; set => tipoReparacion = value; }
        public decimal CostoReparacion { get => costoReparacion; set => costoReparacion = value; }
        public string EstadoCocheDespuesReparacion { get => estadoCocheDespuesReparacion; set => estadoCocheDespuesReparacion = value; }

        public TrabajadorModels()
        {

        }
        RepositorioTrabajador repositorio;
        public string InsertarTxt()
        {
            string mensaje = null;
            try
            {
                var repacionDataModel = new Reparacion();
                repacionDataModel.Id = Id;
                repacionDataModel.TrabajadorEncargado.Nombre = TrabajadorEncargado.Nombre;
                repacionDataModel.CocheReparado.Matricula = CocheReparado.Matricula;
                repacionDataModel.FechaReparacion = FechaReparacion;
                repacionDataModel.CostoReparacion = CostoReparacion;
                repacionDataModel.EstadoCocheDespuesReparacion = EstadoCocheDespuesReparacion;
                var cocheDataModel = new Coche();
                cocheDataModel.Marca = Marca;
                cocheDataModel.Matricula = Matricula;
                cocheDataModel.Dueño = Dueño;
                cocheDataModel.ProblemaPresentado = problemaPresentado;
                cocheDataModel.FechaReparacion = FechaReparacionCoche;
                cocheDataModel.CostoReparacion = CostoReparacionCoche;
                var trabajadorDataModel = new Trabajador();
                trabajadorDataModel.Cedula = Cedula;
                trabajadorDataModel.Nombre = Nombre;
                trabajadorDataModel.FechaNacimiento = FechaNacimiento;
                trabajadorDataModel.TipoTrabajador = TipoTrabajador;
                trabajadorDataModel.Especialidad = Especialidad;
                mensaje = repositorio.InsertarTrabajador(trabajadorDataModel,cocheDataModel,repacionDataModel);

            }
            catch (Exception ex)
            {
                mensaje = ex.Message.ToString();
            }
            return mensaje;
        }

    }
}
