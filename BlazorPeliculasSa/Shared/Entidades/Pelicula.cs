using BlazorPeliculasSa.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorPeliculasSa.Shared.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public string Trailer { get; set; }
        public bool EnCartelera { get; set; }
        [Required(ErrorMessage = "El campo fecha de {0} es requerido")]
        public DateTime? Lanzamiento { get; set; }
        public string Poster { get; set; }
        public List<GeneroPelicula> GeneroPelicula { get; set; } = new List<GeneroPelicula>();
        public string TituloCortado
        {
            get
            {
                if (string.IsNullOrEmpty(Titulo))
                {
                    return null;
                }
                if (Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }
                else
                {
                    return Titulo;
                }
            }
        }
        public List<PeliculaActor> PeliculaActor { get; set; }





    }


}
