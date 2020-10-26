using BlazorPeliculasSa.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPeliculasSa.Shared.DTOs
{
    public class PeliculaActualizacionDTO
    {
        public Pelicula Pelicula { get; set; }
        public List<Persona> Actores { get; set; }
        public List<Genero> GeneroSeleccionado { get; set; }
        public List<Genero> GeneroNoSeleccionado { get; set; }
    }
}
