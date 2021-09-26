using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;

namespace AccesoDatos.Entidades
{
    public class RestauranteEntity
    {
        public long Id { get; set; }
        [StringLength(50)]
        public string NombreRestaurante { get; set; }
        public short NumeroAforo { get; set; }
        [StringLength(10)]
        public string Telefono { get; set; }

        public DateTime FechaCreacion { get; set; }

        public long CiudadId { get; set; }
        public virtual CiudadEntity Ciudad { get; set; }
    }
}
