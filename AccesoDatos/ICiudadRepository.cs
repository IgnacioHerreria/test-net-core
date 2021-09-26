using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos
{
    public interface ICiudadRepository
    {
        CiudadEntity Delete(long id);
        List<CiudadEntity> Get();

        CiudadEntity ConsultaId(long idCiudad);
    }
}
