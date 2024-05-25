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
    public class Empleados
    {
       


        //Creamos nuestra lista para la data table
        public DataTable ListaDT { get; set; } = new DataTable();

        //Crea la Estructura de la Lista de alumnos
        //
        public Empleados()
        {
            ListaDT.TableName = "ListaEmpleados";
            ListaDT.Columns.Add("Id", typeof(int));
            ListaDT.Columns.Add("Nombre");
            ListaDT.Columns.Add("Apellido");
            ListaDT.Columns.Add("Cargo");
            ListaDT.Columns.Add("Obra");

            LeerArchivo();
        }

        //Lee el archivo Alumnos.xml si es que este existe
        //
        public void LeerArchivo()
        {
            if (System.IO.File.Exists("Empleados.xml"))
            {
                ListaDT.ReadXml("Empleados.xml");
            }
        }

        // Inserta un nuevo alumno en la lista de alumnos y luego escribe esta lista en el archivo Alumnos.xml
        //
        public void InsertEmpleado(Empleado aEmpleado)
        {
            int id = NuevoId();

            ListaDT.Rows.Add(); //agrego renglon vacio
            int NuevoRenglon = ListaDT.Rows.Count - 1;
            ListaDT.Rows[NuevoRenglon]["Id"] = id;
            ListaDT.Rows[NuevoRenglon]["Nombre"] = aEmpleado.Nombre;
            ListaDT.Rows[NuevoRenglon]["Apellido"] = aEmpleado.Apellido;
            ListaDT.Rows[NuevoRenglon]["Cargo"] = aEmpleado.Cargo;
            ListaDT.Rows[NuevoRenglon]["Obra"] = aEmpleado.Obra;

            ListaDT.WriteXml("Empleados.xml");
        }


        public bool BorrarEmpleado(string txtId)
        {
            bool existe = false;
            ListaDT.AcceptChanges();
            foreach (DataRow row in ListaDT.Rows)
            {
               
                if (txtId == (row["Id"].ToString()))
                {
                    row.Delete();
                    ListaDT.WriteXml("Empleados.xml");
                    existe = true;
                }
            }
            ListaDT.AcceptChanges();
            return existe;
        }

        public bool BuscarEmpleado(string txtId)
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

        