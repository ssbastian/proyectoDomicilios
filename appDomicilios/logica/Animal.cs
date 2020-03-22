using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appDomicilios.accesoDatos;
using System.Data;

namespace appDomicilios.logica
{
    class Animal
    {
        /*creo el objeto de la clase Datos que está en la
        capa accesoDatos para comunicarme con esa capa*/
        Datos dt = new Datos();

        public int ingresarAnimal(int codigo, string nombre, string genero, string tipo)
        {
            int result;
            /*PASO 1: construyo la sentencia sql para insertar*/
            string consulta;
            consulta = "insert into Animal(aniCodigo,aniNombre,aniGenero,aniTipo)values(" +
                      codigo + ",'" + nombre + "','" + genero + "','" + tipo + "')";


            /*PASO 2: Envío la consulta a la capa de accesoDatos y a
             * la clase Datos para ejecutarla*/
            result = dt.ejecutarDML(consulta);
            return result;
        }

        public DataSet consultarAnimales()
        {
            /*paso 0: creo un dataset vacio*/
            DataSet miDS = new DataSet();
            /*PASO 1: construyo la sentencia sql para consultar
             todos los animales*/
            string consulta;
            consulta = "select aniCodigo, aniNombre,aniGenero,aniTipo from animal";
            /*PASO 2: Envío la consulta a la capa de accesoDatos y a
             * la clase Datos para ejecutarla*/
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

        public DataSet buscarAnimalXCod(int cod)
        {
            /*paso 0: creo un dataset vacio*/
            DataSet miDS = new DataSet();
            /*PASO 1: construyo la sentencia sql para buscar
             animal por codigo*/
            string consulta;
            consulta = "select aniCodigo, aniNombre,aniGenero,aniTipo from animal where anicodigo = " + cod;
            /*PASO 2: Envío la consulta a la capa de accesoDatos y a
             * la clase Datos para ejecutarla*/
            miDS = dt.ejecutarSELECT(consulta);
            return miDS;
        }

    }
}
