using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesoDatos.Util
{
    public class Enumeracion
    {
        public enum Ejecucion
        {
            CONSULTA = 1,
            CONSULTA_ID = 2,
            CREAR = 3,
            ACTUALIZAR = 4,
            ELIMINAR = 5,
        }
    }
}
