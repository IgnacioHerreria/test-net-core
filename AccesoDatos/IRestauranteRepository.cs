using AccesoDatos.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;
using static AccesoDatos.Util.Enumeracion;

namespace AccesoDatos
{
    public interface IRestauranteRepository
    {
        List<RestauranteEntity> Ejecutar(Ejecucion tipoEjecucion, string nombre = "", long idRestaurante = 0, string telefono = "", short numero = 0, long idCiudad = 0);
        RestauranteEntity ConsultaId(long id);
    }
}
