﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Model;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
       
       public IEnumerable<Evento> _evento = new Evento[] {
         new Evento() {
            EventoId = 1,
            Tema = "Angular 5",
            Local = "Rio de Janeiro",
            Lote = "1º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
         },
         new Evento() {
            EventoId = 2,
            Tema = "Angular 5 e .NET 5",
            Local = "Rio de Janeiro",
            Lote = "2º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString(),
            ImagemURL = "foto.png"
         }
       };
       
        public EventoController()
        {
           
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
          return _evento.Where(evento => evento.EventoId == id );
        }

         [HttpPost]
        public String Post()
        {
           return "POST";
        }

        [HttpPut("{id}")]
        public String Put(int id)
        {
           return $"PUT ID: {id}";
        }

        [HttpDelete("{id}")]
        public String Delete(int id)
        {
           return $"Delete ID: {id}";
        }
    }
}
