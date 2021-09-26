using AccesoDatos.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using static AccesoDatos.Util.Enumeracion;

namespace AccesoDatos
{
    public class RestauranteRepository : IRestauranteRepository
    {
        private readonly SiberianDbContext _context;
        public RestauranteRepository(SiberianDbContext context)
        {
            _context = context;
        }

        public RestauranteEntity Delete(long id)
        {

            RestauranteEntity registro = _context.Restaurantes.Find(id);
            if (registro is null)
                return registro;
            else
            {
                _context.Restaurantes.Remove(registro);
                _context.SaveChanges();
                return registro;
            }
        }

        public List<RestauranteEntity> Get()
        {

            return _context.Restaurantes.ToList();
        }

        public List<RestauranteEntity> Ejecutar(Ejecucion tipoEjecucion, string nombre = "", long idRestaurante = 0, string telefono = "", short numero = 0, long idCiudad = 0)
        {
            SqlParameter a = new SqlParameter("@Accion", ((int)tipoEjecucion).ToString());
            SqlParameter n = new SqlParameter("@Nombre", string.IsNullOrEmpty(nombre) ? "" : nombre);
            SqlParameter r = new SqlParameter("@IdRestaurante", idRestaurante <= 0 ? "" : idRestaurante.ToString());
            SqlParameter t = new SqlParameter("@Telefono", string.IsNullOrEmpty(telefono) ? "" : telefono);
            SqlParameter nu = new SqlParameter("@NumeroAforo", numero <= 0 ? "" : numero.ToString());
            SqlParameter c = new SqlParameter("@IdCiudad", idCiudad <= 0 ? "" : idCiudad.ToString());
            var restaurantes = _context
                .Restaurantes
                .FromSqlRaw("exec Sp_Restauranes @Accion, @Nombre,@IdRestaurante,@Telefono,@NumeroAforo,@IdCiudad",
                a, n, r, t, nu, c)
                        .ToList();
            return restaurantes;
        }

        public RestauranteEntity ConsultaId(long id)
        {
            return _context.Restaurantes.Find(id);
        }
    }
}
