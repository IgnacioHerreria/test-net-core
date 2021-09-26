using AccesoDatos;
using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiberian.Services
{
    public class CiudadService : ICiudadService
    {
        private readonly ICiudadRepository _ciudadRepository;

        public CiudadService(ICiudadRepository ciudadRepository)
        {
            _ciudadRepository = ciudadRepository;
        }


        public List<CiudadEntity> ObtenerCiudades()
        {

            try
            {
                return _ciudadRepository.Get();
            }
            catch (Exception r)
            {

                throw;
            }
        }



    }
}
