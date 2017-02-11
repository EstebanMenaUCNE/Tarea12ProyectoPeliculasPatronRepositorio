﻿using ProyectoPeliculasPatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace ProyectoPeliculasPatronRepositorio.DAL
{
    public class PeliculasDb : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }

        public PeliculasDb() : base("ConStr")
        {

        }
    }
}
