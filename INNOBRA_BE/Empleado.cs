using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace INNOBRA_BE
{

    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public string Obra { get; set; }

        public void Agregar(
                            string aNombre,
                       string aApellido,
                       string aCargo,
                       string aObra)
        {

            Nombre = aNombre;
            Apellido = aApellido;
            Cargo = aCargo;
            Obra = aObra;
        }

    }

   
}
