using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ProyectoPeliculasPatronRepositorio.Entidades
{
    public class Pelicula
    {
        [Key]
        public int PeliculaId { get; set; }
        public DateTime Estreno { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaId { get; set; }

        public Pelicula()
        {

        }

        public Pelicula(int peliculaId, DateTime estreno, string descripcion, int categoriaId)
        {
            PeliculaId = peliculaId;
            Estreno = estreno;
            Descripcion = descripcion;
            CategoriaId = categoriaId;
        }
    }
}
