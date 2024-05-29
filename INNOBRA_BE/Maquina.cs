using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace INNOBRA_BE
{

    public class Maquina
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public string Obra { get; set; }

        public void Agregar(
                            string aMarca,
                       string aModelo,
                       string aDescripcion,
                       string aObra)
        {

            Marca = aMarca;
            Modelo = aModelo;
            Descripcion = aDescripcion;
            Obra = aObra;
        }

    }

   
}
