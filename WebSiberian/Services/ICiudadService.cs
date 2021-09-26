using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiberian.Services
{
    public interface ICiudadService 
    {
        List<CiudadEntity> ObtenerCiudades();
    }
}
