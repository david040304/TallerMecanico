using Datos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Datos.Repositorios
{
   
    public class RepositorioTrabajador
    {
        readonly string ArchivoTrabajador;
        readonly string ArchivoCoche;
        readonly string ArchivoReparacion;

        public RepositorioTrabajador()
        {
            ArchivoTrabajador = @"DatoTrabajor";
        }
        public string InsertarTrabajador(Trabajador Etrabajado, Coche Ecoche, Reparacion Ereparacion)
        {
            var trabajador = Mostrar();
            var coche = MostrarCoche();
            var reparacion = MostrarReparacion();
            if(ExistirReparacion(Ereparacion.Id, reparacion) == 0)
            {
                using(StreamWriter agregarReparacion = File.AppendText(ArchivoReparacion))
                {
                    agregarReparacion.WriteLine(Ereparacion.Linea());
                    agregarReparacion.Close();
                }
                using(StreamWriter agregarCoche = File.AppendText(ArchivoCoche))
                {
                    agregarCoche.WriteLine(Ecoche.Linea());
                    agregarCoche.Close();
                }
                using (StreamWriter agregarTrabajador = File.AppendText(ArchivoTrabajador))
                {
                    agregarTrabajador.WriteLine(Etrabajado.Linea());
                    agregarTrabajador.Close();
                }
                return  "Vehiculo Raparado";
            }
            else
            {
                return $"Vehiculo Reparado";
            }
        }
        public List<Trabajador> Mostrar()
        {
            List<Trabajador> trabajadors = new List<Trabajador>();
            try
            {
                StreamReader reader = new StreamReader(ArchivoTrabajador);
                while(!reader.EndOfStream)
                {
                    Trabajador trabajador = new Trabajador(reader.ReadLine());
                    trabajadors.Add(trabajador);
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
            return trabajadors;
        }
        public List<Coche> MostrarCoche()
        {
            List<Coche> coches = new List<Coche>();
            try
            {
                StreamReader reader = new StreamReader(ArchivoCoche);
                while (!reader.EndOfStream)
                {
                    Coche coche = new Coche(reader.ReadLine());
                    coches.Add(coche);
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
            return coches;
        }
        public List<Reparacion> MostrarReparacion()
        {
            List<Reparacion> reparaciones = new List<Reparacion>();
            try
            {
                StreamReader reader = new StreamReader(ArchivoReparacion);
                while (!reader.EndOfStream)
                {
                    Reparacion reparacion = new Reparacion(reader.ReadLine());
                    reparaciones.Add(reparacion);
                }
            }
            catch (Exception ex)
            {
                ex.Message.ToString().Trim();
            }
            return reparaciones;
        }

        public int ExistirTrabajador(string cedula, List<Trabajador> trabajador)
        {
            return trabajador.Where(c => c.Cedula == cedula).Count();
        }
        public int ExistirCoche(string cedula, List<Coche> coches)
        {
            return coches.Where(c => c.Matricula == cedula).Count();
        }
        public int ExistirReparacion(string id, List<Reparacion> trabajador)
        {
            return trabajador.Where(c => c.Id == id).Count();
        }
    }
}
