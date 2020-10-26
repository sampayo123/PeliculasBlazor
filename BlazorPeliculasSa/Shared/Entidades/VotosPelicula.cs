using BlazorPeliculasSa.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorPeliculasSa.Shared.Entidades
{
    public class VotosPelicula
    {
        public int Id { get; set; }
        public int Voto { get; set; }
        public DateTime FechaVoto { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; }
        public string UserId { get; set; }
    }
}
