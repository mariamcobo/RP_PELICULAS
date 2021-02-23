using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RP_PELICULAS.Modelos
{
    public class Pelicula
    {
        public int Id { get; set;}
        public string Titulo { get; set; }
        public string Genero { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Lanzamiento")]
        public DateTime Fechalanzamiento { get; set; }
    }
}
