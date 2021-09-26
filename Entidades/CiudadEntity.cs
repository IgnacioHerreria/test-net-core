using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class CiudadEntity
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "El nombre de la provincia es obligatorio")]
        [StringLength(50)]
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }

        public class Mapping {

            public Mapping(EntityType)
            {

            }
        }
    }
}
