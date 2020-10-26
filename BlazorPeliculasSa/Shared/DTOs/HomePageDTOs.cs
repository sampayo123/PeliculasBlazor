using BlazorPeliculasSa.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculasSa.Shared.DTOs
{
    public class HomePageDTO
    {
        public List<Pelicula> PeliculaEnCartelera { get; set; }
        public List<Pelicula> ProximosEstrenos { get; set; }
    }
}