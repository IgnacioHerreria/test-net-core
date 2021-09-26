using AccesoDatos.Entidades;
using AccesoDatos.Util;
using System.Collections.Generic;

namespace WebSiberian.Services
{
    public interface IRestauranteService
    {
        List<RestauranteEntity> Consulta(DtoRestaurante dto);

        List<RestauranteEntity> ConsultaId(DtoRestaurante dto);
        List<RestauranteEntity> Crear(DtoRestaurante dto);
        List<RestauranteEntity> Actualizar(DtoRestaurante dto);
        List<RestauranteEntity> Eliminar(DtoRestaurante dto);
    }
}
