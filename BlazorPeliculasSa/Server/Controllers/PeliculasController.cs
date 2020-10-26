using AutoMapper;
using BlazorPeliculasSa.Server.Helpers;
using BlazorPeliculasSa.Shared.DTOs;
using BlazorPeliculasSa.Shared.Entidades;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculasSa.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "admin")]
    public class PeliculasController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorDeArchivos almacenadorDeArchivos;
        private readonly IMapper mapper;
        private readonly UserManager<IdentityUser> userManager;

        public PeliculasController(ApplicationDbContext context,
            IAlmacenadorDeArchivos almacenadorDeArchivos,
            IMapper mapper, UserManager<IdentityUser> userManager)

        {
            this.context = context;
            this.almacenadorDeArchivos = almacenadorDeArchivos;
            this.mapper = mapper;
            this.userManager = userManager;
        }



        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<HomePageDTO>> Get()
        {
            var limite = 6;

            var peliculaEnCartelera = await context.Peliculas
              .Where(x => x.EnCartelera).Take(limite)
              .OrderByDescending(x => x.Lanzamiento)
              .ToListAsync();

            var fechaActual = DateTime.Today;

            var proximosEstrenos = await context.Peliculas
                .Where(x => x.Lanzamiento > fechaActual)
                .OrderBy(x => x.Lanzamiento).Take(limite)
                .ToListAsync();

            var response = new HomePageDTO()
            {
                PeliculaEnCartelera = peliculaEnCartelera,
                ProximosEstrenos = proximosEstrenos
            };
            return response;
        }


        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<PeliculaVisualizarDTO>> Get(int id)
        {
            var pelicula = await context.Peliculas.Where(x => x.Id == id)
                .Include(x => x.GeneroPelicula).ThenInclude(x => x.Genero)
                .Include(x => x.PeliculaActor).ThenInclude(x => x.Persona)
                .FirstOrDefaultAsync();

            if (pelicula == null) { return NotFound(); }

            var promedioVotos = 0.0;
            var votoUsuario = 0;

   /*         if (await context.VotosPeliculas.AnyAsync(x => x.PeliculaId == id))
            {
                promedioVotos = await context.VotosPeliculas.Where(x => x.PeliculaId == id)
                    .AverageAsync(x => x.Voto);

                if (HttpContext.User.Identity.IsAuthenticated)
                {
                    var user = await userManager.FindByEmailAsync(HttpContext.User.Identity.Name);
                    var userId = user.Id;

                    var votoUsuarioDB = await context.VotosPeliculas
                        .FirstOrDefaultAsync(x => x.PeliculaId == id && x.UserId == userId);

                    if (votoUsuarioDB != null)
                    {
                        votoUsuario = votoUsuarioDB.Voto;
                    }
                }
            }
*/

            pelicula.PeliculaActor = pelicula.PeliculaActor.OrderBy(x => x.Orden).ToList();
            var model = new PeliculaVisualizarDTO();
            model.Pelicula = pelicula;
            model.Generos = pelicula.GeneroPelicula.Select(x => x.Genero).ToList();
            model.Actores = pelicula.PeliculaActor.Select(x => new Persona
            {
                Nombre = x.Persona.Nombre,
                Foto = x.Persona.Foto,
                Personaje = x.Personaje,
                Id = x.PersonaId
            }).ToList();

            model.PromedioVotos = promedioVotos;
            model.VotoUsuario = votoUsuario;
            return model;
        }


        [HttpGet("filtrar")]
        [AllowAnonymous]
        public async Task<ActionResult<List<Pelicula>>> Get([FromQuery] ParametrosBusquedaPeliculas parametrosBusqueda)
        {
            var peliculasQueryable = context.Peliculas.AsQueryable();

            if (!string.IsNullOrWhiteSpace(parametrosBusqueda.Titulo))
            {
                peliculasQueryable = peliculasQueryable
                    .Where(x => x.Titulo.ToLower().Contains(parametrosBusqueda.Titulo.ToLower()));
            }

            if (parametrosBusqueda.EnCartelera)
            {
                peliculasQueryable = peliculasQueryable.Where(x => x.EnCartelera);
            }

            if (parametrosBusqueda.Estrenos)
            {
                var hoy = DateTime.Today;
                peliculasQueryable = peliculasQueryable.Where(x => x.Lanzamiento >= hoy);
            }

            if (parametrosBusqueda.GeneroId != 0)
            {
                peliculasQueryable = peliculasQueryable
                    .Where(x => x.GeneroPelicula.Select(y => y.GeneroId)
                    .Contains(parametrosBusqueda.GeneroId));
            }

            // TODO: Implementar votacion

            await HttpContext.InsertarParametrosPaginacionEnRespuesta(peliculasQueryable,
                parametrosBusqueda.CantidadRegistros);

            var peliculas = await peliculasQueryable.Paginar(parametrosBusqueda.Paginacion).ToListAsync();

            return peliculas;
        }


        /* [HttpGet("filtrar")]
         public async Task<ActionResult<List<Pelicula>>> Get([FromQuery] ParametrosBusquedaPeliculas parametrosBusqueda)
         {
             var peliculasQueryable = context.Peliculas.AsQueryable();
             if (!string.IsNullOrWhiteSpace(parametrosBusqueda.Titulo))
             {
                 peliculasQueryable = peliculasQueryable.Where(x => x.Titulo.ToLower().Contains(parametrosBusqueda.Titulo.ToLower()));

             }

             if (parametrosBusqueda.EnCartelera)
             {
                 peliculasQueryable = peliculasQueryable.Where(x => x.EnCartelera);
             }


             if (parametrosBusqueda.Estrenos)
             {
                 var hoy = DateTime.Today;
                 peliculasQueryable = peliculasQueryable.Where(x => x.Lanzamiento >= hoy);
             }

             if(parametrosBusqueda.GeneroId != 0)
             {
                 peliculasQueryable = peliculasQueryable.Where(x => x.GeneroPelicula.Select(y => y.GeneroId)
                   .Contains(parametrosBusqueda.GeneroId));
             }

             //todo
             await HttpContext.InsertarParametrosPaginacionEnRespuesta(peliculasQueryable,
                 parametrosBusqueda.CantidadResgistro);

              var peliculas = await peliculasQueryable.Paginar( parametrosBusqueda.Paginacion).ToListAsync();
             return peliculas;

         }*/


        public class ParametrosBusquedaPeliculas
        {
            public int Pagina { get; set; } = 1;
            public int CantidadRegistros { get; set; } = 10;
            public Paginacion Paginacion
            {
                get { return new Paginacion() { Pagina = Pagina, CantidadRegistros = CantidadRegistros }; }
            }
            public string Titulo { get; set; }
            public int GeneroId { get; set; }
            public bool EnCartelera { get; set; }
            public bool Estrenos { get; set; }
            public bool MasVotadas { get; set; }
        }

        [HttpGet("actualizar/{id}")]
        public async Task<ActionResult<PeliculaActualizacionDTO>> PutGet(int id)
        {
            var peliculaActionResult = await Get(id);
            if (peliculaActionResult.Result is NotFoundResult) { return NotFound();}
            
            var peliculaVisualizarDTO = peliculaActionResult.Value;

            var generosSeleccionadosIds = peliculaVisualizarDTO.Generos.Select(x => x.Id).ToList();

            var generosNoSeleccionados = await context.Generos
                .Where(x => !generosSeleccionadosIds.Contains(x.Id)).ToListAsync();


            var model = new PeliculaActualizacionDTO();
            model.Pelicula = peliculaVisualizarDTO.Pelicula;
            model.GeneroNoSeleccionado = generosNoSeleccionados;
            model.GeneroSeleccionado = peliculaVisualizarDTO.Generos;
            model.Actores = peliculaVisualizarDTO.Actores;
            return model;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Pelicula pelicula)
        {
            if (!string.IsNullOrWhiteSpace(pelicula.Poster))
            {
                var posterPelicula = Convert.FromBase64String(pelicula.Poster);
                pelicula.Poster = await almacenadorDeArchivos.GuardarArchivo(posterPelicula, "jpg", "peliculas");
            }

            if (pelicula.PeliculaActor != null)
            {
                for (int i = 0; i < pelicula.PeliculaActor.Count; i++)
                {
                    pelicula.PeliculaActor[i].Orden = i + 1;
                }


            }


            context.Add(pelicula);
            await context.SaveChangesAsync();
            return pelicula.Id;
        }


        [HttpPut]
        public async Task<ActionResult> Put(Pelicula pelicula)
        {
            var peliculaDB = await context.Peliculas.FirstOrDefaultAsync(x => x.Id == pelicula.Id);
            
            if(peliculaDB == null) { return NotFound(); }

            peliculaDB = mapper.Map(pelicula, peliculaDB);

            if (!string.IsNullOrWhiteSpace(pelicula.Poster))
            {
                var posterImagen = Convert.FromBase64String(pelicula.Poster);
                peliculaDB.Poster = await almacenadorDeArchivos.EditarArchivo(posterImagen,
                    "jpg","peliculas", peliculaDB.Poster);
            }


            await context.Database.ExecuteSqlInterpolatedAsync($"DELETE from GenerosPeliculas WHERE PeliculaId ={pelicula.Id}; DELETE from PeliculasActores WHERE PeliculaId ={pelicula.Id}");

            if (pelicula.PeliculaActor != null)
            {
                for (int i = 0; i < pelicula.PeliculaActor.Count; i++)
                {
                    pelicula.PeliculaActor[i].Orden = i + 1;
                }


            }

            peliculaDB.PeliculaActor = pelicula.PeliculaActor;
            peliculaDB.GeneroPelicula = pelicula.GeneroPelicula;
            await context.SaveChangesAsync();
            return NoContent();

        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var existe = await context.Peliculas.AnyAsync(x => x.Id == id);
            if (!existe) { return NotFound(); }
            context.Remove(new Pelicula { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }

    }
}
