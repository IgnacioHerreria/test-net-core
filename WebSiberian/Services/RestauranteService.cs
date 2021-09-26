using AccesoDatos;
using AccesoDatos.Entidades;
using AccesoDatos.Util;
using System;
using System.Collections.Generic;
using static AccesoDatos.Util.Enumeracion;

namespace WebSiberian.Services
{
    public class RestauranteService : IRestauranteService
    {
        private readonly IRestauranteRepository _restauranteRepository;
        private readonly ICiudadRepository _ciudadRepository;

        public RestauranteService(IRestauranteRepository restauranteRepository, ICiudadRepository ciudadRepository)
        {
            _restauranteRepository = restauranteRepository;
            _ciudadRepository = ciudadRepository;
        }


        public List<RestauranteEntity> Consulta(DtoRestaurante dto)
        {
            try
            {
                return _restauranteRepository.Ejecutar(Ejecucion.CONSULTA, dto.Nombre, (long)dto.IdRestaurante, dto.Telefono, (short)dto.NumeroAforo, (long)dto.IdCiudad);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public List<RestauranteEntity> ConsultaId(DtoRestaurante dto)
        {
            try
            {
                if (dto.IdRestaurante <= 0)
                    throw new Exception("Valide que los campos enviados sean los correctos");
                return _restauranteRepository.Ejecutar(Ejecucion.CONSULTA_ID, dto.Nombre, (long)dto.IdRestaurante, dto.Telefono, (short)dto.NumeroAforo, (long)dto.IdCiudad);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public List<RestauranteEntity> Crear(DtoRestaurante dto)
        {
            try
            {
                if (string.IsNullOrEmpty(dto.Nombre) || dto.IdCiudad <= 0)
                    throw new Exception("Valide que los campos enviados sean los correctos");
                CiudadEntity ciudad = _ciudadRepository.ConsultaId((long)dto.IdCiudad);
                if (ciudad is null)
                    throw new Exception("Ciudad no encontrada");
                return _restauranteRepository.Ejecutar(Ejecucion.CREAR, dto.Nombre, (long)dto.IdRestaurante, dto.Telefono, (short)dto.NumeroAforo, (long)dto.IdCiudad);
            }
            catch (Exception e)
            {

                throw;
            }
        }


        public List<RestauranteEntity> Eliminar(DtoRestaurante dto)
        {
            try
            {
                if (dto.IdRestaurante <= 0)
                    throw new Exception("Valide que los campos enviados sean los correctos");

                RestauranteEntity restaurante = _restauranteRepository.ConsultaId((long)dto.IdRestaurante);
                if (restaurante is null)
                    throw new Exception("Restaurante no encontrado");

                return _restauranteRepository.Ejecutar(Ejecucion.ELIMINAR, dto.Nombre, (long)dto.IdRestaurante, dto.Telefono, (short)dto.NumeroAforo, (long)dto.IdCiudad);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public List<RestauranteEntity> Actualizar(DtoRestaurante dto)
        {
            try
            {
                if (string.IsNullOrEmpty(dto.Nombre) || dto.IdCiudad <= 0 || dto.IdRestaurante <= 0)
                    throw new Exception("Valide que los campos enviados sean los correctos");
                RestauranteEntity restaurante = _restauranteRepository.ConsultaId((long)dto.IdRestaurante);
                if (restaurante is null)
                    throw new Exception("Restaurante no encontrado");
                CiudadEntity ciudad = _ciudadRepository.ConsultaId((long)dto.IdCiudad);
                if (ciudad is null)
                    throw new Exception("Ciudad no encontrada");
                return _restauranteRepository.Ejecutar(Ejecucion.ACTUALIZAR, dto.Nombre, (long)dto.IdRestaurante, dto.Telefono, (short)dto.NumeroAforo, (long)dto.IdCiudad);
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
