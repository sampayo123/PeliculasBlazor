﻿using AutoMapper;
using BlazorPeliculasSa.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculasSa.Server.Helpers
{
    public class AutomapperPerfiles : Profile
    {
        public AutomapperPerfiles()
        {
            CreateMap<Persona, Persona>()
                .ForMember(x => x.Foto, option => option.Ignore());

            CreateMap<Pelicula, Pelicula>()
                .ForMember(x => x.Poster, option => option.Ignore());
        }
    }
}
