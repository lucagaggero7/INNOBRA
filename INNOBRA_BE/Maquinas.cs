using INNOBRA_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;


namespace INNOBRA_BE
{
    public class Maquinas
    {
       


        //Creamos nuestra lista para la data table
        public DataTable ListaDT { get; set; } = new DataTable();

        //Crea la Estructura de la Lista de alumnos
        //
        public Maquinas()
        {
            ListaDT.TableName = "ListaMaquinas";
            ListaDT.Columns.Add("Id", typeof(int));
            ListaDT.Columns.Add("Marca");
            ListaDT.Columns.Add("Modelo");
            ListaDT.Columns.Add("Descripcion");
            ListaDT.Columns.Add("Obra");

            LeerArchivo();
        }

        //Lee el archivo Alumnos.xml si es que este existe
        //
        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Maquinas.xml"))
            {
                ListaDT.ReadXml("Maquinas.xml");
            }
        }

        // Inserta un nuevo alumno en la lista de alumnos y luego escribe esta lista en el archivo Alumnos.xml
        //
        public void InsertMaquina(Maquina aMaquina)
        {
            int id = NuevoId();

            ListaDT.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Id"] = id;
            ListaDT.Rows[NuevoRenglon]["Marca"] = aMaquina.Marca;
            ListaDT.Rows[NuevoRenglon]["Modelo"] = aMaquina.Modelo;
            ListaDT.Rows[NuevoRenglon]["Descripcion"] = aMaquina.Descripcion;
            ListaDT.Rows[NuevoRenglon]["Obra"] = aMaquina.Obra;

            ListaDT.WriteXml("Maquinas.xml");
        }


        public bool BorrarMaquina(string txtId)
        {
            bool existe = false;
            ListaDT.AcceptChanges();
            foreach (DataRow row in ListaDT.Rows)
            {
               
                if (txtId == (row["Id"].ToString()))
                {
                    row.Delete();
                    ListaDT.WriteXml("Maquinas.xml");
                    existe = true;
                }
            }
            ListaDT.AcceptChanges();
            return existe;
        }

        public bool ExisteMaquina(string txtId)
        {
            bool existe = false;
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtId == (row["Id"].ToString()))
                {
                    existe = true;
                }
            }
            return existe;

        }

        public int BuscarMaquina(string txtId)
        {
            int index = 0;
            foreach (DataRow row in ListaDT.Rows)
            {
                if (txtId == (row["Id"].ToString()))
                {
                    index = ListaDT.Rows.IndexOf(row);
                
                }
            }
            return index;

        }



        private int NuevoId()
        {
            int NuevoId = 0;

            foreach (DataRow fila in ListaDT.Rows)
            {
                if (NuevoId < Convert.ToInt32(fila["Id"]))
                {
                    NuevoId = Convert.ToInt32(fila["Id"]);
                }
            }

            NuevoId++;
            return NuevoId;
        }



    }

}

        