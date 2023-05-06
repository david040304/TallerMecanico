using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class RepositorioMaestro
    {
        private string rutaArchivo = "registros.txt";

        public void GuardarRegistro(string registro)
        {
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine(registro);
            }
        }
    }
}
