﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       
        private readonly DataContext _context;
        public EventoController(DataContext context )
        {
            _context = context;            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }
         [HttpGet("{id}")]
        public Evento GetbyId(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => 
            evento.EventoId == id
            );
        }

         [HttpPost]
         public string Post()
        {
            return "evento";                       
        }
    }
}