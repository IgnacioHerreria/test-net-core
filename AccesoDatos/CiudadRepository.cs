using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace AccesoDatos
{
    public class CiudadRepository : ICiudadRepository
    {
        private readonly SiberianDbContext _context;
        public CiudadRepository(SiberianDbContext context)
        {
            _context = context;
        }

        public CiudadEntity Delete(long id)
        {

            CiudadEntity registro = _context.Ciudades.Find(id);
            if (registro is null)
                return registro;
            else
            {
                _context.Ciudades.Remove(registro);
                _context.SaveChanges();
                return registro;
            }
        }

        public List<CiudadEntity> Get()
        {

            return _context.Ciudades.Include(x => x.Restaurantes).ToList();
        }


        public CiudadEntity ConsultaId(long idCiudad)
        {
            return _context.Ciudades.Find(idCiudad);
        }
    }
}
