using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AccesoDatos.Entidades
{
    public class CiudadEntity
    {
        public CiudadEntity()
        {
            Restaurantes = new HashSet<RestauranteEntity>();
        }
        public long Id { get; set; }
        [Required(ErrorMessage = "El nombre de la provincia es obligatorio")]
        [StringLength(50)]
        public string NombreCiudad { get; set; }
        public DateTime FechaCreacion { get; set; }
        public virtual ICollection<RestauranteEntity> Restaurantes { get; set; }

    }
}
